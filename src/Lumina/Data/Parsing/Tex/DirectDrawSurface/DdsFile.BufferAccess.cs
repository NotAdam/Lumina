using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Lumina.Data.Parsing.Tex.DirectDrawSurface;

public partial class DdsFile
{
    /// <summary>
    /// Offset to the pixel buffer in this file, after the header(s).
    /// </summary>
    public int BodyOffset => Unsafe.SizeOf< DdsHeaderWithMagic >() + ( UseDxt10Header ? Unsafe.SizeOf< DdsHeaderDxt10 >() : 0 );

    /// <summary>
    /// Offset to the tail in this file, after body.
    /// </summary>
    public int TailOffset => BodyOffset + BodySize;

    /// <summary>
    /// Get the number of bytes occupied by a slice(1D or 2D) in the specified mipmap in this file.
    /// </summary>
    /// <param name="mipmapIndex">Index of the mipmap.</param>
    /// <returns>Number of bytes, or 0 if invalid values are set in the headers.</returns>
    public int SliceSize( int mipmapIndex ) => PitchAndSliceSize( mipmapIndex, out _, out var sliceSize ) ? sliceSize : 0;

    /// <summary>
    /// Get the number of bytes occupied by the specified mipmap in this file.
    /// </summary>
    /// <param name="mipmapIndex">Index of the mipmap.</param>
    /// <returns></returns>
    public int MipmapSize( int mipmapIndex ) => SliceSize( mipmapIndex ) * Depth( mipmapIndex );

    /// <summary>
    /// Get the number of bytes occupied by a face in this file.
    /// </summary>
    public int FaceSize => Enumerable.Range( 0, NumMipmaps ).Sum( MipmapSize );

    /// <summary>
    /// Get the number of bytes occupied by one image in this file.
    /// </summary>
    public int ImageSize => FaceSize * NumFaces;

    /// <summary>
    /// Get the number of bytes occupied by all the images in this file.
    /// </summary>
    public int BodySize => ImageSize * NumImages;

    /// <summary>
    /// Get the offset of the specified image in bytes.
    /// </summary>
    /// <param name="imageIndex">Index of the image.</param>
    /// <param name="size">Number of bytes of the image.</param>
    /// <returns>Offset to the image in bytes.</returns>
    public int ImageBodyOffset( int imageIndex, out int size )
    {
        if( imageIndex < 0 || imageIndex >= NumImages )
            throw new ArgumentOutOfRangeException( nameof( imageIndex ), imageIndex, null );
        size = ImageSize;
        return size * imageIndex;
    }

    /// <summary>
    /// Get the offset of the specified face in bytes.
    /// </summary>
    /// <param name="imageIndex">Index of the image.</param>
    /// <param name="faceIndex">Index of the face.</param>
    /// <param name="size">Number of bytes of the face.</param>
    /// <returns>Offset to the face in bytes.</returns>
    public int FaceBodyOffset( int imageIndex, int faceIndex, out int size )
    {
        var offset = ImageBodyOffset( imageIndex, out _ );
        size = FaceSize;
        return offset + size * faceIndex;
    }

    /// <summary>
    /// Get the offset of the specified mipmap in bytes.
    /// </summary>
    /// <param name="imageIndex">Index of the image.</param>
    /// <param name="faceIndex">Index of the face.</param>
    /// <param name="mipmapIndex">Index of the mipmap.</param>
    /// <param name="size">Number of bytes of the mipmap.</param>
    /// <returns>Offset to the mipmap in bytes.</returns>
    public int MipmapBodyOffset( int imageIndex, int faceIndex, int mipmapIndex, out int size )
    {
        var baseOffset = FaceBodyOffset( imageIndex, faceIndex, out _ );
        var mipOffset = Enumerable.Range( 0, mipmapIndex ).Sum( MipmapSize );
        size = MipmapSize( mipmapIndex );
        return baseOffset + mipOffset;
    }

    /// <summary>
    /// Get the offset of the specified slice in bytes.
    /// </summary>
    /// <param name="imageIndex">Index of the image.</param>
    /// <param name="faceIndex">Index of the face.</param>
    /// <param name="mipmapIndex">Index of the mipmap.</param>
    /// <param name="sliceIndex">Index of the slice.</param>
    /// <param name="size">Number of bytes of the slice.</param>
    /// <returns>Offset to the slice in bytes.</returns>
    public int SliceBodyOffset( int imageIndex, int faceIndex, int mipmapIndex, int sliceIndex, out int size )
    {
        var offset = MipmapBodyOffset( imageIndex, faceIndex, mipmapIndex, out _ );
        size = SliceSize( mipmapIndex );
        return offset + size * sliceIndex;
    }

    /// <summary>
    /// Get a span view of the specified image contained in <see cref="Body"/>.
    /// </summary>
    /// <param name="imageIndex">Index of the image.</param>
    /// <returns>The span.</returns>
    public Span< byte > ImageSpan( int imageIndex )
    {
        var offset = ImageBodyOffset( imageIndex, out var size );
        return new( Body, offset, size );
    }

    /// <summary>
    /// Get a span view of the specified face contained in <see cref="Body"/>.
    /// </summary>
    /// <param name="imageIndex">Index of the image.</param>
    /// <param name="faceIndex">Index of the face.</param>
    /// <returns>The span.</returns>
    public Span< byte > FaceSpan( int imageIndex, int faceIndex )
    {
        var offset = FaceBodyOffset( imageIndex, faceIndex, out var size );
        return new( Body, offset, size );
    }

    /// <summary>
    /// Get a span view of the specified mipmap contained in <see cref="Body"/>.
    /// </summary>
    /// <param name="imageIndex">Index of the image.</param>
    /// <param name="faceIndex">Index of the face.</param>
    /// <param name="mipmapIndex">Index of the mipmap.</param>
    /// <returns>The span.</returns>
    public Span< byte > MipmapSpan( int imageIndex, int faceIndex, int mipmapIndex )
    {
        var offset = MipmapBodyOffset( imageIndex, faceIndex, mipmapIndex, out var size );
        return new( Body, offset, size );
    }

    /// <summary>
    /// Get a span view of the specified slice contained in <see cref="Body"/>.
    /// </summary>
    /// <param name="imageIndex">Index of the image.</param>
    /// <param name="faceIndex">Index of the face.</param>
    /// <param name="mipmapIndex">Index of the mipmap.</param>
    /// <param name="sliceIndex">Index of the slice.</param>
    /// <returns>The span.</returns>
    public Span< byte > SliceSpan( int imageIndex, int faceIndex, int mipmapIndex, int sliceIndex )
    {
        var offset = SliceBodyOffset( imageIndex, faceIndex, mipmapIndex, sliceIndex, out var size );
        return new( Body, offset, size );
    }

    /// <summary>
    /// Get a memory view of the specified image contained in <see cref="Body"/>.
    /// </summary>
    /// <param name="imageIndex">Index of the image.</param>
    /// <returns>The memory.</returns>
    public Memory< byte > ImageMemory( int imageIndex )
    {
        var offset = ImageBodyOffset( imageIndex, out var size );
        return new( Body, offset, size );
    }

    /// <summary>
    /// Get a memory view of the specified face contained in <see cref="Body"/>.
    /// </summary>
    /// <param name="imageIndex">Index of the image.</param>
    /// <param name="faceIndex">Index of the face.</param>
    /// <returns>The memory.</returns>
    public Memory< byte > FaceMemory( int imageIndex, int faceIndex )
    {
        var offset = FaceBodyOffset( imageIndex, faceIndex, out var size );
        return new( Body, offset, size );
    }

    /// <summary>
    /// Get a memory view of the specified mipmap contained in <see cref="Body"/>.
    /// </summary>
    /// <param name="imageIndex">Index of the image.</param>
    /// <param name="faceIndex">Index of the face.</param>
    /// <param name="mipmapIndex">Index of the mipmap.</param>
    /// <returns>The memory.</returns>
    public Memory< byte > MipmapMemory( int imageIndex, int faceIndex, int mipmapIndex )
    {
        var offset = MipmapBodyOffset( imageIndex, faceIndex, mipmapIndex, out var size );
        return new( Body, offset, size );
    }

    /// <summary>
    /// Get a memory view of the specified slice contained in <see cref="Body"/>.
    /// </summary>
    /// <param name="imageIndex">Index of the image.</param>
    /// <param name="faceIndex">Index of the face.</param>
    /// <param name="mipmapIndex">Index of the mipmap.</param>
    /// <param name="sliceIndex">Index of the slice.</param>
    /// <returns>The memory.</returns>
    public Memory< byte > SliceMemory( int imageIndex, int faceIndex, int mipmapIndex, int sliceIndex )
    {
        var offset = SliceBodyOffset( imageIndex, faceIndex, mipmapIndex, sliceIndex, out var size );
        return new( Body, offset, size );
    }
}