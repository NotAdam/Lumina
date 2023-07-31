using System;
using Lumina.Data.Files;

namespace Lumina.Data.Parsing.Tex.Buffers
{
    /// <summary>
    /// Represent a face in .tex file, in R16G16B16A16F texture format.
    /// </summary>
    public class R16G16B16A16FTextureBuffer : TextureBuffer
    {
        /// <inheritdoc />
        public R16G16B16A16FTextureBuffer( TexFile.Attribute attribute, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer )
            : base( attribute, width, height, depth, mipmapAllocations, buffer )
        {
        }

        /// <inheritdoc />
        public override int NumBytesOfMipmapPerPlane( int mipmapIndex ) => NumPixelsOfMipmapPerPlane( mipmapIndex ) * 8;

        /// <inheritdoc />
        protected override unsafe void ConvertToB8G8R8A8( byte[] buffer, int destOffset, int sourceOffset, int width, int height, int depth )
        {
            fixed( byte* dstb = buffer, srcb = RawData )
            {
                var src = new Span< Half >( srcb + sourceOffset, width * height * depth * 4 );
                var dst = new Span< byte >( dstb + destOffset, width * height * depth * 4 );
                for( var i = 0; i < dst.Length; i += 4 )
                {
                    dst[ i + 0 ] = (byte)Math.Round( (float)src[ i + 2 ] * byte.MaxValue );
                    dst[ i + 1 ] = (byte)Math.Round( (float)src[ i + 1 ] * byte.MaxValue );
                    dst[ i + 2 ] = (byte)Math.Round( (float)src[ i + 0 ] * byte.MaxValue );
                    dst[ i + 3 ] = (byte)Math.Round( (float)src[ i + 3 ] * byte.MaxValue );
                }
            }
        }

        /// <inheritdoc />
        protected override TextureBuffer CreateNew( TexFile.Attribute attribute, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer )
            => new R16G16B16A16FTextureBuffer( attribute, width, height, depth, mipmapAllocations, buffer );
    }
}