using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

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
            ReadOnlySpan< byte > data = br.ReadBytes( Marshal.SizeOf( typeof( T ) ) );

            return MemoryMarshal.AsRef< T >( data );
        }
    }
}