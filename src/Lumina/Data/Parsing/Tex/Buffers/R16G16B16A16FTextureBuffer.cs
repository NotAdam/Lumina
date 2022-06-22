using System;
using Lumina.Extensions;

namespace Lumina.Data.Parsing.Tex.Buffers
{
    /// <summary>
    /// Represent a face in .tex file, in R16G16B16A16F texture format.
    /// </summary>
    public class R16G16B16A16FTextureBuffer : TextureBuffer
    {
        /// <inheritdoc />
        public R16G16B16A16FTextureBuffer( bool isDepthConstant, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer )
            : base( isDepthConstant, width, height, depth, mipmapAllocations, buffer )
        {
        }

        /// <inheritdoc />
        public override int NumBytesOfMipmapPerPlane( int mipmapIndex ) => NumPixelsOfMipmapPerPlane( mipmapIndex ) * 8;

        /// <inheritdoc />
        protected override unsafe void ConvertToB8G8R8A8( byte[] buffer, int destOffset, int sourceOffset, int width, int height, int depth )
        {
            fixed( byte* dstb = buffer, srcb = RawData )
            {
                var src = new Span< ushort >( srcb + sourceOffset, width * height * depth * 4 );
                var dst = new Span< byte >( dstb + destOffset, width * height * depth * 4 );
                for( var i = 0; i < dst.Length; i++ )
                    dst[ i ] = (byte)Math.Round( src[ i ].Unpack() * byte.MaxValue );
            }
        }

        /// <inheritdoc />
        protected override TextureBuffer CreateNew( bool isDepthConstant, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer )
            => new R16G16B16A16FTextureBuffer( isDepthConstant, width, height, depth, mipmapAllocations, buffer );
    }
}