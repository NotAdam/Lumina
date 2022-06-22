using System;

namespace Lumina.Data.Parsing.Tex.Buffers
{
    /// <summary>
    /// Represent a face in .tex file, in R32G32B32A32F texture format.
    /// </summary>
    public class R32G32B32A32FTextureBuffer : TextureBuffer
    {
        /// <inheritdoc />
        public R32G32B32A32FTextureBuffer( bool isDepthConstant, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer )
            : base( isDepthConstant, width, height, depth, mipmapAllocations, buffer )
        {
        }

        /// <inheritdoc />
        public override int NumBytesOfMipmapPerPlane( int mipmapIndex ) => NumPixelsOfMipmapPerPlane( mipmapIndex ) * 16;

        /// <inheritdoc />
        protected override unsafe void ConvertToB8G8R8A8( byte[] buffer, int destOffset, int sourceOffset, int width, int height, int depth )
        {
            fixed( byte* dstb = buffer, srcb = RawData )
            {
                var src = new Span< float >( srcb + sourceOffset, width * height * depth * 4 );
                var dst = new Span< byte >( dstb + destOffset, width * height * depth * 4 );
                for( var i = 0; i < dst.Length; i++ )
                    dst[ i ] = (byte)Math.Round( src[ i ] * byte.MaxValue );
            }
        }

        /// <inheritdoc />
        protected override TextureBuffer CreateNew( bool isDepthConstant, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer )
            => new R32G32B32A32FTextureBuffer( isDepthConstant, width, height, depth, mipmapAllocations, buffer );
    }
}