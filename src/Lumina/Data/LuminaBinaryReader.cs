using Lumina.Data.Structs;
using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Lumina.Data
{
    public class LuminaBinaryReader : BinaryReader
    {
        public PlatformId PlatformId { get; internal set; }

        private bool isLittleEndian;
        public bool IsLittleEndian
        {
            get => isLittleEndian;
            set => isLittleEndian = value;
        }

        public bool ConvertEndianness => BitConverter.IsLittleEndian != isLittleEndian;

        public long Position
        {
            get => BaseStream.Position;
            set => BaseStream.Position = value;
        }

        public LuminaBinaryReader( byte[] array, PlatformId platformId = PlatformId.Win32 ) : this( new MemoryStream( array, false ), Encoding.UTF8, false, platformId )
        {
        }

        public LuminaBinaryReader( Stream stream, PlatformId platformId = PlatformId.Win32 ) : this( stream, Encoding.UTF8, false, platformId )
        {
        }

        public LuminaBinaryReader( Stream stream, Encoding encoding, PlatformId platformId ) : this( stream, encoding, false, platformId )
        {
        }

        public LuminaBinaryReader( Stream stream, Encoding encoding, bool leaveOpen, PlatformId platformId ) : base( stream, encoding, leaveOpen )
        {
            PlatformId = platformId;
            isLittleEndian = platformId != PlatformId.PS3;
        }

        public override short ReadInt16() => isLittleEndian ? base.ReadInt16() : BinaryPrimitives.ReverseEndianness( base.ReadInt16() );
        public override ushort ReadUInt16() => isLittleEndian ? base.ReadUInt16() : BinaryPrimitives.ReverseEndianness( base.ReadUInt16() );
        public override int ReadInt32() => isLittleEndian ? base.ReadInt32() : BinaryPrimitives.ReverseEndianness( base.ReadInt32() );
        public override uint ReadUInt32() => isLittleEndian ? base.ReadUInt32() : BinaryPrimitives.ReverseEndianness( base.ReadUInt32() );
        public override long ReadInt64() => isLittleEndian ? base.ReadInt64() : BinaryPrimitives.ReverseEndianness( base.ReadInt64() );
        public override ulong ReadUInt64() => isLittleEndian ? base.ReadUInt64() : BinaryPrimitives.ReverseEndianness( base.ReadUInt64() );
        public override float ReadSingle() => isLittleEndian ? base.ReadSingle() : ReverseEndianness( base.ReadSingle() );
        public override double ReadDouble() => isLittleEndian ? base.ReadDouble() : ReverseEndianness( base.ReadDouble() );

#if NET6_0_OR_GREATER
        public override Half ReadHalf() => isLittleEndian ? base.ReadHalf() : ReverseEndianness( base.ReadHalf() );
#else
        public unsafe Half ReadHalf()
        {
            var half = ReadUInt16();

            return *(Half*)&half;
        }
#endif

        public sbyte[] ReadSByteArray( int count ) => ReadPrimitiveArray< sbyte >( count );
        public bool[] ReadBooleanArray( int count ) => ReadPrimitiveArray< bool >( count );
        public short[] ReadInt16Array( int count ) => ReadPrimitiveArray< short >( count );
        public ushort[] ReadUInt16Array( int count ) => ReadPrimitiveArray< ushort >( count );
        public int[] ReadInt32Array( int count ) => ReadPrimitiveArray< int >( count );
        public uint[] ReadUInt32Array( int count ) => ReadPrimitiveArray< uint >( count );
        public long[] ReadInt64Array( int count ) => ReadPrimitiveArray< long >( count );
        public ulong[] ReadUInt64Array( int count ) => ReadPrimitiveArray< ulong >( count );
        public Half[] ReadHalfArray( int count ) => ReadPrimitiveArray< Half >( count );
        public float[] ReadSingleArray( int count ) => ReadPrimitiveArray< float >( count );
        public double[] ReadDoubleArray( int count ) => ReadPrimitiveArray< double >( count );

        /// <summary>
        /// Reads a structure from the current stream position.
        /// </summary>
        /// <typeparam name="T">The structure to read in to</typeparam>
        /// <returns>The file data as a structure</returns>
        public T ReadStructure< T >() where T : struct
        {
            var data = ReadBytes( Unsafe.SizeOf< T >() );
            
            if( ConvertEndianness )
                ConvertEndian( typeof( T ), data );

            T structure = MemoryMarshal.Read< T >( data );
            
            return structure;
        }

        // this is fucked but it's better than forcing a convert method on every structure ever
        private static void ConvertEndian( Type type, Span< byte > data, int startOffset = 0 )
        {
            foreach ( var field in type.GetFields( BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic ) )
            {
                var fieldType = field.FieldType;
                if ( fieldType.IsEnum )
                    fieldType = Enum.GetUnderlyingType( fieldType );
                
                // small hack to obtain field offset
                var offset = startOffset + Marshal.ReadInt32( field.FieldHandle.Value + ( IntPtr.Size + 4 ) ) & 0x07FFFFFF;
                
                if( fieldType.IsPrimitive )
                {
                    data.Slice( offset, SizeOfHelper( fieldType ) ).Reverse();
                }
                else
                {
                    var attr = (FixedBufferAttribute?)Attribute.GetCustomAttribute( field, typeof( FixedBufferAttribute ) );
                    if( attr != null )
                    {
                        var fieldSize = SizeOfHelper( attr.ElementType );
                        if( fieldSize <= 1 )
                            continue;
                        
                        for( var i = 0; i < attr.Length; i++ )
                        {
                            data.Slice( offset, fieldSize ).Reverse();
                            offset += fieldSize;
                        }
                    }
                    else
                    {
                        ConvertEndian( fieldType, data, offset );
                    }
                }
            }
        }

        private static int SizeOfHelper( Type type ) => Type.GetTypeCode( type ) switch
        {
            TypeCode.Boolean or TypeCode.SByte or TypeCode.Byte  => 1,
            TypeCode.Char or TypeCode.Int16 or TypeCode.UInt16 => 2,
            TypeCode.Int32 or TypeCode.UInt32 or TypeCode.Single => 4,
            TypeCode.Int64 or TypeCode.UInt64 or TypeCode.Double => 8,
            _ => Marshal.SizeOf( type )
        };
        
        /// <summary>
        /// Reads many structures from the current stream position.
        /// </summary>
        /// <param name="count">The number of T to read from the stream</param>
        /// <typeparam name="T">The structure to read in to</typeparam>
        /// <returns>A list containing the structures read from the stream</returns>
        public List<T> ReadStructures< T >( int count ) where T : struct
        {
            var structs = ReadStructuresAsSpan< T >( count );
            var list = new List< T >( structs.Length );

            for( var i = 0; i < structs.Length; i++ )
            {
                list.Add( structs[ i ] );
            }

            return list;
        }

        /// <summary>
        /// Reads many structures from the current stream position.
        /// </summary>
        /// <param name="count">The number of T to read from the stream</param>
        /// <typeparam name="T">The structure to read in to</typeparam>
        /// <returns>An array containing the structures read from the stream</returns>
        public T[] ReadStructuresAsArray< T >( int count ) where T : struct
        {
            return ReadStructuresAsSpan< T >( count ).ToArray();
        }

        /// <summary>
        /// Reads many structures from the current stream position.
        /// </summary>
        /// <param name="count">The number of T to read from the stream</param>
        /// <typeparam name="T">The structure to read in to</typeparam>
        /// <returns>A span containing the structures read from the stream</returns>
        public Span< T > ReadStructuresAsSpan< T >( int count ) where T : struct
        {
            var tSize = Unsafe.SizeOf< T >();
            Span< byte > data = ReadBytes( tSize * count );
            
            if( ConvertEndianness )
                for( var i = 0; i < count; i++ )
                    ConvertEndian( typeof( T ), data, tSize * i );

            return MemoryMarshal.Cast< byte, T >( data );
        }

        private T[] ReadPrimitiveArray< T >( int count ) where T : struct
        {
            var size = Unsafe.SizeOf< T >();
            var span = MemoryMarshal.Cast< byte, T >( ReadBytes( count * size ) );

            if( ConvertEndianness )
            {
                switch( size )
                {
                    case 1:
                        break;

                    case 2:
                        var sSpan = MemoryMarshal.Cast< T, ushort >( span );

                        for( var i = 0; i < count; i++ )
                        {
                            sSpan[ i ] = BinaryPrimitives.ReverseEndianness( sSpan[ i ] );
                        }

                        break;

                    case 4:
                        var iSpan = MemoryMarshal.Cast< T, uint >( span );

                        for( var i = 0; i < count; i++ )
                        {
                            iSpan[ i ] = BinaryPrimitives.ReverseEndianness( iSpan[ i ] );
                        }

                        break;

                    case 8:
                        var lSpan = MemoryMarshal.Cast< T, ulong >( span );

                        for( var i = 0; i < count; i++ )
                        {
                            lSpan[ i ] = BinaryPrimitives.ReverseEndianness( lSpan[ i ] );
                        }

                        break;
                }
            }

            return span.ToArray();
        }

        public static unsafe Half ReverseEndianness( Half value )
        {
            var sValue = BinaryPrimitives.ReverseEndianness( *(ushort*)&value );

            return *(Half*)&sValue;
        }

        public static float ReverseEndianness( float value )
        {
            var iValue = BitConverter.SingleToInt32Bits( value );
            iValue = BinaryPrimitives.ReverseEndianness( iValue );

            return BitConverter.Int32BitsToSingle( iValue );
        }

        public static double ReverseEndianness( double value )
        {
            var lValue = BitConverter.DoubleToInt64Bits( value );
            lValue = BinaryPrimitives.ReverseEndianness( lValue );

            return BitConverter.Int64BitsToDouble( lValue );
        }
    }
}
