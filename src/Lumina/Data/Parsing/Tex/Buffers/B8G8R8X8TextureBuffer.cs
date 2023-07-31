using System;
using Lumina.Data.Files;

namespace Lumina.Data.Parsing.Tex.Buffers
{
    /// <summary>
    /// Represent a face in .tex file, in B8G8R8X8 texture format.
    /// </summary>
    public class B8G8R8X8TextureBuffer : TextureBuffer
    {
        /// <inheritdoc />
        public B8G8R8X8TextureBuffer( TexFile.Attribute attribute, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer )
            : base( attribute, width, height, depth, mipmapAllocations, buffer )
        {
        }

        /// <inheritdoc />
        public override int NumBytesOfMipmapPerPlane( int mipmapIndex ) => NumPixelsOfMipmapPerPlane( mipmapIndex ) * 4;

        /// <inheritdoc />
        protected override unsafe void ConvertToB8G8R8A8( byte[] buffer, int destOffset, int sourceOffset, int width, int height, int depth )
        {
            fixed( byte* dstb = buffer, srcb = RawData )
            {
                var src = new Span< uint >( srcb + sourceOffset, width * height * depth );
                var dst = new Span< uint >( dstb + destOffset, width * height * depth );
                for( var i = 0; i < dst.Length; i++ )
                    dst[ i ] = 0xFF000000U | src[ i ];
            }
        }

        /// <inheritdoc />
        protected override TextureBuffer CreateNew( TexFile.Attribute attribute, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer )
            => new B8G8R8X8TextureBuffer( attribute, width, height, depth, mipmapAllocations, buffer );
    }
}