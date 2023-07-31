using System;
using Lumina.Data.Files;

namespace Lumina.Data.Parsing.Tex.Buffers
{
    /// <summary>
    /// Represent a face in .tex file, in B4G4R4A4 texture format.
    /// </summary>
    public class B4G4R4A4TextureBuffer : TextureBuffer
    {
        /// <inheritdoc />
        public B4G4R4A4TextureBuffer( TexFile.Attribute attribute, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer )
            : base( attribute, width, height, depth, mipmapAllocations, buffer )
        {
        }

        /// <inheritdoc />
        public override int NumBytesOfMipmapPerPlane( int mipmapIndex ) => NumPixelsOfMipmapPerPlane( mipmapIndex ) * 2;

        /// <inheritdoc />
        protected override unsafe void ConvertToB8G8R8A8( byte[] buffer, int destOffset, int sourceOffset, int width, int height, int depth )
        {
            fixed( byte* dstb = buffer, srcb = RawData )
            {
                var src = new Span< ushort >( srcb + sourceOffset, width * height * depth );
                var dst = new Span< uint >( dstb + destOffset, width * height * depth );
                for( var i = 0; i < dst.Length; i++ )
                {
                    dst[ i ] = (uint)( 17U * (
                        ( ( ( src[ i ] >> 0 ) & 0xF ) << 0 )
                        | ( ( ( src[ i ] >> 4 ) & 0xF ) << 8 )
                        | ( ( ( src[ i ] >> 8 ) & 0xF ) << 16 )
                        | ( ( ( src[ i ] >> 12 ) & 0xF ) << 24 )
                    ) );
                }
            }
        }

        /// <inheritdoc />
        protected override TextureBuffer CreateNew( TexFile.Attribute attribute, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer )
            => new B4G4R4A4TextureBuffer( attribute, width, height, depth, mipmapAllocations, buffer );
    }
}