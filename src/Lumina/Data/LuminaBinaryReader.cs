using Lumina.Data.Parsing;
using Lumina.Data.Structs;
using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lumina.Data
{
    public interface IConvertEndianness
    {
        public void ConvertEndianness();
    }

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

        public unsafe Half ReadHalf()
        {
            var half = ReadUInt16();

            return *(Half*)&half;
        }

        public sbyte[] ReadSBytes( int count ) => MemoryMarshal.Cast< byte, sbyte >( ReadBytes( count ) ).ToArray();

        public bool[] ReadBooleans( int count ) => MemoryMarshal.Cast< byte, bool >( ReadBytes( count ) ).ToArray();

        public short[] ReadInt16s( int count )
        {
            var span = MemoryMarshal.Cast< byte, short >( ReadBytes( count * sizeof( short ) ) );

            if( ConvertEndianness )
            {
                for( int i = 0; i < count; i++ )
                {
                    span[ i ] = BinaryPrimitives.ReverseEndianness( span[ i ] );
                }
            }

            return span.ToArray();
        }

        public ushort[] ReadUInt16s( int count )
        {
            var span = MemoryMarshal.Cast< byte, ushort >( ReadBytes( count * sizeof( ushort ) ) );

            if( ConvertEndianness )
            {
                for( int i = 0; i < count; i++ )
                {
                    span[ i ] = BinaryPrimitives.ReverseEndianness( span[ i ] );
                }
            }

            return span.ToArray();
        }

        public int[] ReadInt32s( int count )
        {
            var span = MemoryMarshal.Cast< byte, int >( ReadBytes( count * sizeof( int ) ) );

            if( ConvertEndianness )
            {
                for( int i = 0; i < count; i++ )
                {
                    span[ i ] = BinaryPrimitives.ReverseEndianness( span[ i ] );
                }
            }

            return span.ToArray();
        }

        public uint[] ReadUInt32s( int count )
        {
            var span = MemoryMarshal.Cast< byte, uint >( ReadBytes( count * sizeof( uint ) ) );

            if( ConvertEndianness )
            {
                for( int i = 0; i < count; i++ )
                {
                    span[ i ] = BinaryPrimitives.ReverseEndianness( span[ i ] );
                }
            }

            return span.ToArray();
        }

        public long[] ReadInt64s( int count )
        {
            var span = MemoryMarshal.Cast< byte, long >( ReadBytes( count * sizeof( long ) ) );

            if( ConvertEndianness )
            {
                for( int i = 0; i < count; i++ )
                {
                    span[ i ] = BinaryPrimitives.ReverseEndianness( span[ i ] );
                }
            }

            return span.ToArray();
        }

        public ulong[] ReadUInt64s( int count )
        {
            var span = MemoryMarshal.Cast< byte, ulong >( ReadBytes( count * sizeof( ulong ) ) );

            if( ConvertEndianness )
            {
                for( int i = 0; i < count; i++ )
                {
                    span[ i ] = BinaryPrimitives.ReverseEndianness( span[ i ] );
                }
            }

            return span.ToArray();
        }

        public Half[] ReadHalfs( int count )
        {
            var span = MemoryMarshal.Cast< byte, Half >( ReadBytes( count * sizeof( ushort ) ) );

            if( ConvertEndianness )
            {
                for( int i = 0; i < count; i++ )
                {
                    span[ i ] = ReverseEndianness( span[ i ] );
                }
            }

            return span.ToArray();
        }

        public float[] ReadSingles( int count )
        {
            var span = MemoryMarshal.Cast< byte, float >( ReadBytes( count * sizeof( float ) ) );

            if( ConvertEndianness )
            {
                for( int i = 0; i < count; i++ )
                {
                    span[ i ] = ReverseEndianness( span[ i ] );
                }
            }

            return span.ToArray();
        }

        public double[] ReadDoubles( int count )
        {
            var span = MemoryMarshal.Cast< byte, double >( ReadBytes( count * sizeof( double ) ) );

            if( ConvertEndianness )
            {
                for( int i = 0; i < count; i++ )
                {
                    span[ i ] = ReverseEndianness( span[ i ] );
                }
            }

            return span.ToArray();
        }

        /// <summary>
        /// Reads a structure from the current stream position.
        /// </summary>
        /// <typeparam name="T">The structure to read in to</typeparam>
        /// <remarks>Requires interface <see cref="Lumina.Data.IConvertEndianness"/> in structure for converting endianness</remarks>
        /// <returns>The file data as a structure</returns>
        public T ReadStructure< T >() where T : struct, IConvertEndianness
        {
            var data = ReadBytes( Unsafe.SizeOf< T >() );
            T structure = MemoryMarshal.Read< T >( data );

            if( ConvertEndianness )
            {
                structure.ConvertEndianness();
            }

            return structure;
        }

        /// <summary>
        /// Reads many structures from the current stream position.
        /// </summary>
        /// <param name="count">The number of T to read from the stream</param>
        /// <typeparam name="T">The structure to read in to</typeparam>
        /// <remarks>Requires interface <see cref="Lumina.Data.IConvertEndianness"/> in structure for converting endianness</remarks>
        /// <returns>A list containing the structures read from the stream</returns>
        public List<T> ReadStructures< T >( int count ) where T : struct, IConvertEndianness
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
        /// <remarks>Requires interface <see cref="Lumina.Data.IConvertEndianness"/> in structure for converting endianness</remarks>
        /// <returns>An array containing the structures read from the stream</returns>
        public T[] ReadStructuresAsArray< T >( int count ) where T : struct, IConvertEndianness
        {
            return ReadStructuresAsSpan< T >( count ).ToArray();
        }

        /// <summary>
        /// Reads many structures from the current stream position.
        /// </summary>
        /// <param name="count">The number of T to read from the stream</param>
        /// <typeparam name="T">The structure to read in to</typeparam>
        /// <remarks>Requires interface <see cref="Lumina.Data.IConvertEndianness"/> in structure for converting endianness</remarks>
        /// <returns>A span containing the structures read from the stream</returns>
        public Span< T > ReadStructuresAsSpan< T >( int count ) where T : struct, IConvertEndianness
        {
            var data = ReadBytes( Unsafe.SizeOf< T >() * count );
            var span = MemoryMarshal.Cast< byte, T >( data );

            if( ConvertEndianness )
            {
                for( var i = 0; i < span.Length; i++ )
                {
                    span[ i ].ConvertEndianness();
                }
            }

            return span;
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
