using System;
using Lumina.Data.Files;

namespace Lumina.Data.Parsing.Tex.Buffers
{
    /// <summary>
    /// Represent a face in .tex file, in B8G8R8A8 texture format.
    /// </summary>
    public class UnsupportedTextureBuffer : TextureBuffer
    {
        private readonly int _numBytesPerPixel;

        /// <inheritdoc />
        public UnsupportedTextureBuffer( int numBytesPerPixel, TexFile.Attribute attribute, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer )
            : base( attribute, width, height, depth, mipmapAllocations, buffer )
        {
            _numBytesPerPixel = numBytesPerPixel;
        }

        /// <inheritdoc />
        public override int NumBytesOfMipmapPerPlane( int mipmapIndex ) => NumPixelsOfMipmapPerPlane( mipmapIndex ) * _numBytesPerPixel;

        /// <inheritdoc />
        protected override void ConvertToB8G8R8A8( byte[] buffer, int destOffset, int sourceOffset, int width, int height, int depth )
            => throw new NotSupportedException( "Decoding this texture format is currently not supported." );

        /// <inheritdoc />
        protected override TextureBuffer CreateNew( TexFile.Attribute attribute, int width, int height, int depth, int[] mipmapAllocations, byte[] buffer )
            => new UnsupportedTextureBuffer( _numBytesPerPixel, attribute, width, height, depth, mipmapAllocations, buffer );
    }
}