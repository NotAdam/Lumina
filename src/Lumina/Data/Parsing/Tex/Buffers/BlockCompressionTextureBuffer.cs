using System;
using Lumina.Data.Files;

namespace Lumina.Data.Parsing.Tex.Buffers {
    /// <summary>
    /// Represent a face in .tex file, in either BC1(DXT1), BC2(DXT3), BC3(DXT5), BC5(ATI2), or BC7 texture format.
    /// </summary>
    public class BlockCompressionTextureBuffer : TextureBuffer {
        private readonly SquishOptions2 _squishOption;

        private BlockCompressionTextureBuffer( SquishOptions2 squishOption, TexFile.Attribute attribute, int width, int height,
            int depth, int[] mipmapAllocations, byte[] buffer )
            : base( attribute, width, height, depth, mipmapAllocations, buffer ) {
            _squishOption = squishOption;
        }

        /// <inheritdoc />
        public BlockCompressionTextureBuffer( TexFile.TextureFormat format, TexFile.Attribute attribute, int width, int height, int depth, int[] mipmapAllocations,
            byte[] buffer )
            : base( attribute, width, height, depth, mipmapAllocations, buffer ) {
            switch( format ) {
                case TexFile.TextureFormat.BC1:
                    _squishOption = new(SquishMethod.Bc1);
                    break;
                case TexFile.TextureFormat.BC2:
                    _squishOption = new(SquishMethod.Bc2);
                    break;
                case TexFile.TextureFormat.BC3:
                    _squishOption = new(SquishMethod.Bc3);
                    break;
                case TexFile.TextureFormat.BC5:
                    _squishOption = new(SquishMethod.Bc5);
                    break;
                case TexFile.TextureFormat.BC7:
                    _squishOption = new(SquishMethod.Bc7);
                    break;
                default:
                    throw new InvalidOperationException( "Not a DXT texture format" );
            }
        }

        /// <inheritdoc />
        public override int NumBytesOfMipmapPerPlane( int mipmapIndex ) =>
            CalculateNumBytesPerPlane( WidthOfMipmap( mipmapIndex ), HeightOfMipmap( mipmapIndex ) );

        /// <inheritdoc />
        protected override void ConvertToB8G8R8A8( byte[] buffer, int destOffset, int sourceOffset, int width, int height, int depth ) {
            var cbPlane = CalculateNumBytesPerPlane( width, height );
            for( var i = 0; i < depth; i++ ) {
                Squish.DecompressImage< byte, byte >(
                    buffer.AsSpan( destOffset + width * height * 4 * i ),
                    width * 4,
                    width,
                    height,
                    RawData.AsSpan( sourceOffset + cbPlane * i ),
                    _squishOption );
            }
        }

        /// <inheritdoc />
        protected override TextureBuffer CreateNew( TexFile.Attribute attribute, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer )
            => new BlockCompressionTextureBuffer( _squishOption, attribute, width, height, depth, mipmapAllocations, buffer );

        private int CalculateNumBytesPerPlane( int w, int h ) =>
            Math.Max( 1, ( ( w + 3 ) / 4 ) ) *
            Math.Max( 1, ( ( h + 3 ) / 4 ) ) *
            _squishOption.BytesPerBlock;
    }
}