using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using DotNext.IO;

namespace Lumina.Data
{
    public class LuminaBinaryReader : BinaryReader
    {
        public PlatformType Platform { get; }
        public bool IsLittleEndian { get; set; }

        public bool ConvertEndianness => BitConverter.IsLittleEndian != IsLittleEndian;

        public long Position {
            get => BaseStream.Position;
            set => BaseStream.Position = value;
        }

        public LuminaBinaryReader( ReadOnlyMemory< byte > array, PlatformType platformId = PlatformType.Win32 ) : this(
            array.AsStream(), Encoding.UTF8, false, platformId )
        {
        }

        public LuminaBinaryReader( Stream stream, PlatformType platformId = PlatformType.Win32 ) : this( stream,
            Encoding.UTF8, false, platformId )
        {
        }

        public LuminaBinaryReader( Stream stream, Encoding encoding, PlatformType platformId ) : this( stream, encoding,
            false, platformId )
        {
        }

        public LuminaBinaryReader( Stream stream, Encoding encoding, bool leaveOpen, PlatformType platformId ) : base(
            stream, encoding, leaveOpen )
        {
            Platform = platformId;
            IsLittleEndian = platformId != PlatformType.PS3;
        }

        public override short ReadInt16()
        {
            return IsLittleEndian ? base.ReadInt16() : BinaryPrimitives.ReverseEndianness( base.ReadInt16() );
        }

        public override ushort ReadUInt16()
        {
            return IsLittleEndian ? base.ReadUInt16() : BinaryPrimitives.ReverseEndianness( base.ReadUInt16() );
        }

        public override int ReadInt32()
        {
            return IsLittleEndian ? base.ReadInt32() : BinaryPrimitives.ReverseEndianness( base.ReadInt32() );
        }

        public override uint ReadUInt32()
        {
            return IsLittleEndian ? base.ReadUInt32() : BinaryPrimitives.ReverseEndianness( base.ReadUInt32() );
        }

        public override long ReadInt64()
        {
            return IsLittleEndian ? base.ReadInt64() : BinaryPrimitives.ReverseEndianness( base.ReadInt64() );
        }

        public override ulong ReadUInt64()
        {
            return IsLittleEndian ? base.ReadUInt64() : BinaryPrimitives.ReverseEndianness( base.ReadUInt64() );
        }

        public override float ReadSingle()
        {
            return IsLittleEndian ? base.ReadSingle() : ReverseEndianness( base.ReadSingle() );
        }

        public override double ReadDouble()
        {
            return IsLittleEndian ? base.ReadDouble() : ReverseEndianness( base.ReadDouble() );
        }

        public override Half ReadHalf()
        {
            return IsLittleEndian ? base.ReadHalf() : ReverseEndianness( base.ReadHalf() );
        }

        public sbyte[] ReadSByteArray( int count )
        {
            return ReadPrimitiveArray< sbyte >( count );
        }

        public bool[] ReadBooleanArray( int count )
        {
            return ReadPrimitiveArray< bool >( count );
        }

        public short[] ReadInt16Array( int count )
        {
            return ReadPrimitiveArray< short >( count );
        }

        public ushort[] ReadUInt16Array( int count )
        {
            return ReadPrimitiveArray< ushort >( count );
        }

        public int[] ReadInt32Array( int count )
        {
            return ReadPrimitiveArray< int >( count );
        }

        public uint[] ReadUInt32Array( int count )
        {
            return ReadPrimitiveArray< uint >( count );
        }

        public long[] ReadInt64Array( int count )
        {
            return ReadPrimitiveArray< long >( count );
        }

        public ulong[] ReadUInt64Array( int count )
        {
            return ReadPrimitiveArray< ulong >( count );
        }

        public Half[] ReadHalfArray( int count )
        {
            return ReadPrimitiveArray< Half >( count );
        }

        public float[] ReadSingleArray( int count )
        {
            return ReadPrimitiveArray< float >( count );
        }

        public double[] ReadDoubleArray( int count )
        {
            return ReadPrimitiveArray< double >( count );
        }

        /// <summary>
        /// Reads a structure from the current stream position.
        /// </summary>
        /// <typeparam name="T">The structure to read in to</typeparam>
        /// <returns>The file data as a structure</returns>
        public T ReadStructure< T >() where T : struct
        {
            byte[] data = ReadBytes( Unsafe.SizeOf< T >() );

            if( ConvertEndianness )
                ConvertEndian( typeof( T ), data );

            T structure = MemoryMarshal.Read< T >( data );

            return structure;
        }

        // this is fucked but it's better than forcing a convert method on every structure ever
        private static void ConvertEndian( Type type, Span< byte > data, int startOffset = 0 )
        {
            int offset = 0;
            foreach( FieldInfo field in type.GetFields( BindingFlags.Instance | BindingFlags.Public ) )
            {
                Type fieldType = field.FieldType;
                if( fieldType == typeof( string ) )
                    continue;

                if( fieldType.IsEnum )
                    fieldType = Enum.GetUnderlyingType( fieldType );

                FieldInfo[] subFields = fieldType.GetFields( BindingFlags.Instance | BindingFlags.Public );
                int effectiveOffset = startOffset + offset;

                if( subFields.Length == 0 )
                    data.Slice( effectiveOffset, Marshal.SizeOf( fieldType ) ).Reverse();
                else
                    ConvertEndian( fieldType, data, effectiveOffset );
                offset += Marshal.SizeOf( fieldType );
            }
        }

        /// <summary>
        /// Reads many structures from the current stream position.
        /// </summary>
        /// <param name="count">The number of T to read from the stream</param>
        /// <typeparam name="T">The structure to read in to</typeparam>
        /// <returns>A list containing the structures read from the stream</returns>
        public List< T > ReadStructures< T >( int count ) where T : struct
        {
            return [.. ReadStructuresAsSpan< T >( count )];
        }

        /// <summary>
        /// Reads many structures from the current stream position.
        /// </summary>
        /// <param name="count">The number of T to read from the stream</param>
        /// <typeparam name="T">The structure to read in to</typeparam>
        /// <returns>An array containing the structures read from the stream</returns>
        public T[] ReadStructuresAsArray< T >( int count ) where T : struct
        {
            return [.. ReadStructuresAsSpan< T >( count )];
        }

        /// <summary>
        /// Reads many structures from the current stream position.
        /// </summary>
        /// <param name="count">The number of T to read from the stream</param>
        /// <typeparam name="T">The structure to read in to</typeparam>
        /// <returns>A span containing the structures read from the stream</returns>
        public Span< T > ReadStructuresAsSpan< T >( int count ) where T : struct
        {
            int tSize = Unsafe.SizeOf< T >();
            Span< byte > data = ReadBytes( tSize * count ).AsSpan();

            if( ConvertEndianness )
                for( int i = 0; i < count; i++ )
                    ConvertEndian( typeof( T ), data, tSize * i );

            return MemoryMarshal.Cast< byte, T >( data );
        }

        private T[] ReadPrimitiveArray< T >( int count ) where T : struct
        {
            int size = Unsafe.SizeOf< T >();
            Span< T > span = MemoryMarshal.Cast< byte, T >( ReadBytes( count * size ).AsSpan() );

            if( ConvertEndianness )
            {
                switch( size )
                {
                    case 1:
                        break;

                    case 2:
                        Span< short > span2 = MemoryMarshal.Cast< T, short >( span );
                        BinaryPrimitives.ReverseEndianness( span2, span2 );
                        break;

                    case 4:
                        Span< int > span4 = MemoryMarshal.Cast< T, int >( span );
                        BinaryPrimitives.ReverseEndianness( span4, span4 );
                        break;

                    case 8:
                        Span< long > span8 = MemoryMarshal.Cast< T, long >( span );
                        BinaryPrimitives.ReverseEndianness( span8, span8 );
                        break;
                }
            }

            return span.ToArray();
        }

        public static unsafe Half ReverseEndianness( Half value )
        {
            ushort sValue = BinaryPrimitives.ReverseEndianness( *(ushort*)&value );

            return *(Half*)&sValue;
        }

        public static float ReverseEndianness( float value )
        {
            int iValue = BitConverter.SingleToInt32Bits( value );
            iValue = BinaryPrimitives.ReverseEndianness( iValue );

            return BitConverter.Int32BitsToSingle( iValue );
        }

        public static double ReverseEndianness( double value )
        {
            long lValue = BitConverter.DoubleToInt64Bits( value );
            lValue = BinaryPrimitives.ReverseEndianness( lValue );

            return BitConverter.Int64BitsToDouble( lValue );
        }
    }
}
