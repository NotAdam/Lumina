using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Lumina.Extensions
{
    public static class BinaryReaderExtensions
    {
        /// <summary>
        /// Reads a structure from the current stream position.
        /// </summary>
        /// <param name="br"></param>
        /// <typeparam name="T">The structure to read in to</typeparam>
        /// <returns>The file data as a structure</returns>
        public static T ReadStructure< T >( this BinaryReader br ) where T : struct
        {
            ReadOnlySpan< byte > data = br.ReadBytes( Unsafe.SizeOf< T >() );

            return MemoryMarshal.Read< T >( data );
        }

        /// <summary>
        /// Reads many structures from the current stream position.
        /// </summary>
        /// <param name="br"></param>
        /// <param name="count">The number of T to read from the stream</param>
        /// <typeparam name="T">The structure to read in to</typeparam>
        /// <returns>A list containing the structures read from the stream</returns>
        public static List< T > ReadStructures< T >( this BinaryReader br, int count ) where T : struct
        {
            var size = Marshal.SizeOf< T >();
            var data = br.ReadBytes( size * count );

            var list = new List< T >( count );

            for( int i = 0; i < count; i++ )
            {
                var offset = size * i;
                var span = new ReadOnlySpan< byte >( data, offset, size );

                list.Add( MemoryMarshal.Read< T >( span ) );
            }

            return list;
        }

        public static T[] ReadStructuresAsArray< T >( this BinaryReader br, int count ) where T : struct
        {
            var size = Marshal.SizeOf< T >();
            var data = br.ReadBytes( size * count );

            // im a pirate arr
            var arr = new T[ count ];

            for( int i = 0; i < count; i++ )
            {
                var offset = size * i;
                var span = new ReadOnlySpan< byte >( data, offset, size );

                arr[ i ] = MemoryMarshal.Read< T >( span );
            }

            return arr;
        }

        /// <summary>
        /// Moves the BinaryReader position to offset, reads a string, then
        /// sets the position back to the original.
        /// </summary>
        /// <param name="br"></param>
        /// <param name="offset">The offset to read a string starting from.</param>
        /// <returns></returns>
        public static string ReadStringOffset( this BinaryReader br, long offset )
        {
            long originalPosition = br.BaseStream.Position;
            br.BaseStream.Position = offset;

            List< byte > chars = new List< byte >();

            byte current;
            do
            {
                current = br.ReadByte();
                chars.Add( current );
            } while( current != 0 );

            br.BaseStream.Position = originalPosition;
            string ret = Encoding.UTF8.GetString( chars.ToArray(), 0, chars.Count );
            return ret;
        }
    }
}