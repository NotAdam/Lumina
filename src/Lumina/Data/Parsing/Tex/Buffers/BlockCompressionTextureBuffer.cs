using System;
using Lumina.Data.Files;

namespace Lumina.Data.Parsing.Tex.Buffers
{
    /// <summary>
    /// Represent a face in .tex file, in either BC1(DXT1), BC2(DXT3), BC3(DXT5), BC5(ATI2), or BC7 texture format.
    /// </summary>
    public class BlockCompressionTextureBuffer : TextureBuffer
    {
        private readonly SquishOptions _squishOption;
        private readonly int _lengthPerDxtBlock;

        private BlockCompressionTextureBuffer( SquishOptions squishOption, int lengthPerDxtBlock, bool isDepthConstant, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer )
            : base( isDepthConstant, width, height, depth, mipmapAllocations, buffer )
        {
            _squishOption = squishOption;
            _lengthPerDxtBlock = lengthPerDxtBlock;
        }

        /// <inheritdoc />
        public BlockCompressionTextureBuffer( TexFile.TextureFormat format, bool isDepthConstant, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer )
            : base( isDepthConstant, width, height, depth, mipmapAllocations, buffer )
        {
            switch( format )
            {
                case TexFile.TextureFormat.BC1:
                    _squishOption = SquishOptions.DXT1;
                    _lengthPerDxtBlock = 8;
                    break;
                case TexFile.TextureFormat.BC2:
                    _squishOption = SquishOptions.DXT3;
                    _lengthPerDxtBlock = 16;
                    break;
                case TexFile.TextureFormat.BC3:
                    _squishOption = SquishOptions.DXT5;
                    _lengthPerDxtBlock = 16;
                    break;
                case TexFile.TextureFormat.BC5:
                case TexFile.TextureFormat.BC7:
                    _squishOption = SquishOptions.None;
                    _lengthPerDxtBlock = 16;
                    break;
                default:
                    throw new InvalidOperationException( "Not a DXT texture format" );
            }
        }

        /// <inheritdoc />
        public override int NumBytesOfMipmapPerPlane( int mipmapIndex ) =>
            CalculateNumBytesPerPlane(WidthOfMipmap( mipmapIndex ), HeightOfMipmap( mipmapIndex ));
        
        /// <inheritdoc />
        protected override void ConvertToB8G8R8A8( byte[] buffer, int destOffset, int sourceOffset, int width, int height, int depth )
        {
            if( _squishOption == SquishOptions.None )
                throw new NotSupportedException( "Decoding BC5/BC7 data is currently not supported." );
            
            var cbPlane = CalculateNumBytesPerPlane( width, height );
            for( var i = 0; i < depth; i++ )
            {
                var dec = Squish.DecompressImage( RawData, sourceOffset + cbPlane * i, width, height, _squishOption );
                Array.Copy(
                    dec,
                    0,
                    buffer,
                    destOffset + width * height * 4 * i,
                    dec.Length );
            }
        }

        /// <inheritdoc />
        protected override TextureBuffer CreateNew( bool isDepthConstant, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer )
            => new BlockCompressionTextureBuffer( _squishOption, _lengthPerDxtBlock, isDepthConstant, width, height, depth, mipmapAllocations, buffer );

        private int CalculateNumBytesPerPlane( int w, int h ) =>
            Math.Max( 1, ( ( w + 3 ) / 4 ) ) *
            Math.Max( 1, ( ( h + 3 ) / 4 ) ) *
            _lengthPerDxtBlock;
    }
}