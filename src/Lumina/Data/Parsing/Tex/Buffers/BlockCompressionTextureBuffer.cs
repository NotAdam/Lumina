using System;
using Lumina.Data.Files;

namespace Lumina.Data.Parsing.Tex.Buffers
{
    /// <summary>
    /// Represent a face in .tex file, in either BC1(DXT1), BC2(DXT3), BC3(DXT5), BC5(ATI2), or BC7 texture format.
    /// </summary>
    public class BlockCompressionTextureBuffer : TextureBuffer
    {
        private int _version;

        private BlockCompressionTextureBuffer( int version, TexFile.Attribute attribute, int width, int height,
            int depth, int[] mipmapAllocations, byte[] buffer )
            : base( attribute, width, height, depth, mipmapAllocations, buffer, tb => ( (BlockCompressionTextureBuffer) tb )._version = version )
        {
            _version = version;
        }

        /// <inheritdoc />
        public BlockCompressionTextureBuffer( TexFile.TextureFormat format, TexFile.Attribute attribute, int width, int height, int depth,
            int[] mipmapAllocations, byte[] buffer )
            : base( attribute, width, height, depth, mipmapAllocations, buffer, tb => {
                ( (BlockCompressionTextureBuffer) tb )._version = format switch
                {
                    TexFile.TextureFormat.BC1 => 1,
                    TexFile.TextureFormat.BC2 => 2,
                    TexFile.TextureFormat.BC3 => 3,
                    TexFile.TextureFormat.BC5 => 5,
                    TexFile.TextureFormat.BC7 => 7,
                    _ => throw new ArgumentException( null, nameof( format ) ),
                };
            } )
        {
            _version = format switch
            {
                TexFile.TextureFormat.BC1 => 1,
                TexFile.TextureFormat.BC2 => 2,
                TexFile.TextureFormat.BC3 => 3,
                TexFile.TextureFormat.BC5 => 5,
                TexFile.TextureFormat.BC7 => 7,
                _ => throw new ArgumentException( null, nameof( format ) ),
            };
        }

        /// <inheritdoc />
        public override int NumBytesOfMipmapPerPlane( int mipmapIndex ) =>
            CalculateNumBytesPerPlane( WidthOfMipmap( mipmapIndex ), HeightOfMipmap( mipmapIndex ) );

        /// <inheritdoc />
        protected override void ConvertToB8G8R8A8( byte[] buffer, int destOffset, int sourceOffset, int width, int height, int depth )
        {
            var cbPlane = CalculateNumBytesPerPlane( width, height );
            for( var i = 0; i < depth; i++ )
            {
                var dec = Squish.DecompressImage( RawData, sourceOffset + cbPlane * i, width, height, _version switch
                {
                    1 => SquishOptions.DXT1,
                    2 => SquishOptions.DXT3,
                    3 => SquishOptions.DXT5,
                    _ => throw new NotSupportedException( "Decoding BC5/BC7 data is currently not supported." ),
                }  );
                Array.Copy(
                    dec,
                    0,
                    buffer,
                    destOffset + width * height * 4 * i,
                    dec.Length );
            }
        }

        /// <inheritdoc />
        protected override TextureBuffer CreateNew( TexFile.Attribute attribute, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer )
            => new BlockCompressionTextureBuffer( _version, attribute, width, height, depth, mipmapAllocations, buffer );

        private int CalculateNumBytesPerPlane( int w, int h ) =>
            Math.Max( 1, ( ( w + 3 ) / 4 ) ) *
            Math.Max( 1, ( ( h + 3 ) / 4 ) ) *
            ( _version == 1 ? 8 : 16 );
    }
}