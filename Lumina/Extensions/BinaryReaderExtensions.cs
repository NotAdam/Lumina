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
        public static unsafe T ReadStructure< T >( this BinaryReader br )
        {
            var data = br.ReadBytes( Marshal.SizeOf( typeof( T ) ) );

            fixed( byte* ptr = &data[ 0 ] )
            {
                return (T) Marshal.PtrToStructure( new IntPtr( ptr ), typeof( T ) );
            }
        }
    }
}