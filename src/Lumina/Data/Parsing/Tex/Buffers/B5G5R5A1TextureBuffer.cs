using System;

namespace Lumina.Data.Parsing.Tex.Buffers
{
    /// <summary>
    /// Represent a face in .tex file, in B5G5R5A1 texture format.
    /// </summary>
    public class B5G5R5A1TextureBuffer : TextureBuffer
    {
        /// <inheritdoc />
        public B5G5R5A1TextureBuffer( bool isDepthConstant, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer )
            : base( isDepthConstant, width, height, depth, mipmapAllocations, buffer )
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
                    var a = (uint)( src[ i ] & 0x8000 );
                    var r = (uint)( src[ i ] & 0x7C00 );
                    var g = (uint)( src[ i ] & 0x03E0 );
                    var b = (uint)( src[ i ] & 0x001F );

                    var rgb = ( r << 9 ) | ( g << 6 ) | ( b << 3 );
                    dst[ i ] = ( a * 0x1FE00 ) | rgb | ( ( rgb >> 5 ) & 0x070707 );
                }
            }
        }

        /// <inheritdoc />
        protected override TextureBuffer CreateNew( bool isDepthConstant, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer )
            => new B5G5R5A1TextureBuffer( isDepthConstant, width, height, depth, mipmapAllocations, buffer );
    }
}