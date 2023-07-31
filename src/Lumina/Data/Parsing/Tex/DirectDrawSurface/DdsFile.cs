using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lumina.Data.Parsing.Tex.DirectDrawSurface;

/// <summary>
/// Class that deals with DDS files.
/// </summary>
public partial class DdsFile
{
    /// <summary>
    /// Header of this DDS file.
    /// </summary>
    public DdsHeader Header;

    /// <summary>
    /// DXT10 header of this file, if specified. <see cref="Header"/>.<see cref="DdsPixelFormat.FourCc"/> should be <see cref="DdsFourCc.Dx10"/>.
    /// </summary>
    public DdsHeaderDxt10 HeaderDxt10;

    /// <summary>
    /// Buffer for the images contained in this file.
    /// </summary>
    public byte[] Body;

    /// <summary>
    /// Buffer for the extraneous data after the pixel buffer.
    /// </summary>
    public byte[] Tail;

    /// <summary>
    /// Whether to use DXT10 header.
    /// </summary>
    public bool UseDxt10Header => Header.PixelFormat.FourCc == DdsFourCc.Dx10;

    /// <summary>
    /// Number of images contained in this file.
    /// </summary>
    public int NumImages {
        get => UseDxt10Header ? HeaderDxt10.ArraySize : 1;
        set {
            if( value == 1 )
            {
                if( UseDxt10Header )
                    HeaderDxt10.ArraySize = 1;
            }
            else
            {
                if( !UseDxt10Header )
                    throw new NotSupportedException( "Enable DXT10 header to use texture array." );
                HeaderDxt10.ArraySize = value;
            }
        }
    }

    /// <summary>
    /// Number of mipmaps contained in this file.
    /// </summary>
    public int NumMipmaps {
        get => Header.Flags.HasFlag( DdsHeaderFlags.MipmapCount ) ? Header.MipMapCount : 1;
        set {
            switch( value )
            {
                case 1:
                    Header.MipMapCount = 0;
                    Header.Flags &= ~DdsHeaderFlags.MipmapCount;
                    break;
                case > 1:
                    Header.MipMapCount = value;
                    Header.Flags |= DdsHeaderFlags.MipmapCount;
                    break;
                default:
                    throw new ArgumentOutOfRangeException( nameof( value ), value, null );
            }
        }
    }

    /// <summary>
    /// Get whether this file represents an one-dimensional texture.
    ///
    /// Explicitly setting this to false will make this DDS file invalid until you set the appropriate values back.
    /// </summary>
    public bool Is1D {
        get => !Header.Caps2.HasFlag( DdsCaps2.Cubemap ) &&
            ( Header.Flags & DdsHeaderFlags.DimensionMask ) == DdsHeaderFlags.Dimension1;
        set {
            if( value )
            {
                Header.Caps2 &= ~DdsCaps2.Cubemap;
                Header.Flags = ( Header.Flags & ~DdsHeaderFlags.DimensionMask ) | DdsHeaderFlags.Dimension1;
            }
            else
            {
                Header.Caps2 &= ~DdsCaps2.Cubemap;
                Header.Flags &= ~DdsHeaderFlags.DimensionMask;
            }
        }
    }

    /// <summary>
    /// Get whether this file represents a two-dimensional texture.
    ///
    /// Explicitly setting this to false will make this DDS file invalid until you set the appropriate values back.
    /// </summary>
    public bool Is2D {
        get => !Header.Caps2.HasFlag( DdsCaps2.Cubemap ) &&
            ( Header.Flags & DdsHeaderFlags.DimensionMask ) == DdsHeaderFlags.Dimension2;
        set {
            if( value )
            {
                Header.Caps2 &= ~DdsCaps2.Cubemap;
                Header.Flags = ( Header.Flags & ~DdsHeaderFlags.DimensionMask ) | DdsHeaderFlags.Dimension2;
            }
            else
            {
                Header.Caps2 &= ~DdsCaps2.Cubemap;
                Header.Flags &= ~DdsHeaderFlags.DimensionMask;
            }
        }
    }

    /// <summary>
    /// Get whether this file represents a three-dimensional texture.
    ///
    /// Explicitly setting this to false will make this DDS file invalid until you set the appropriate values back.
    /// </summary>
    public bool Is3D {
        get => !Header.Caps2.HasFlag( DdsCaps2.Cubemap ) &&
            ( Header.Flags & DdsHeaderFlags.DimensionMask ) == DdsHeaderFlags.Dimension3;
        set {
            if( value )
            {
                Header.Caps2 &= ~DdsCaps2.Cubemap;
                Header.Flags = ( Header.Flags & ~DdsHeaderFlags.DimensionMask ) | DdsHeaderFlags.Dimension3;
            }
            else
            {
                Header.Caps2 &= ~DdsCaps2.Cubemap;
                Header.Flags &= ~DdsHeaderFlags.DimensionMask;
            }
        }
    }

    /// <summary>
    /// Get or set whether this file represents a cube map texture.
    ///
    /// Explicitly setting this to false will make this DDS file invalid until you set the appropriate values back.
    /// </summary>
    public bool IsCubeMap {
        get => Header.Caps2.HasFlag( DdsCaps2.Cubemap ) &&
            ( Header.Flags & DdsHeaderFlags.DimensionMask ) == DdsHeaderFlags.Dimension2;
        set {
            if( value )
            {
                Header.Caps2 |= DdsCaps2.Cubemap;
                Header.Flags = ( Header.Flags & ~DdsHeaderFlags.DimensionMask ) | DdsHeaderFlags.Dimension2;
            }
            else
            {
                Header.Caps2 &= ~DdsCaps2.Cubemap;
                Header.Flags &= ~DdsHeaderFlags.DimensionMask;
            }
        }
    }

    /// <summary>
    /// Get the width of the specified mipmap in this file.
    /// </summary>
    /// <param name="mipmapIndex">Index of the mipmap.</param>
    /// <returns>Width of the mipmap.</returns>
    public int Width( int mipmapIndex ) =>
        0 <= mipmapIndex && mipmapIndex < NumMipmaps
            ? Header.Flags.HasFlag( DdsHeaderFlags.Width ) ? Math.Max( 1, Header.Width >> mipmapIndex ) : 1
            : throw new ArgumentOutOfRangeException( nameof( mipmapIndex ), mipmapIndex, null );

    /// <summary>
    /// Get the pitch(stride) of the specified mipmap in this file.
    /// </summary>
    /// <param name="mipmapIndex">Index of the mipmap.</param>
    /// <returns>Pitch(stride) of the mipmap, or 0 if invalid values are set in the headers.</returns>
    public int Pitch( int mipmapIndex ) => PitchAndSliceSize( mipmapIndex, out var pitch, out _ ) ? pitch : 0;

    /// <summary>
    /// Get the height of the specified mipmap in this file.
    /// </summary>
    /// <param name="mipmapIndex">Index of the mipmap.</param>
    /// <returns>Height of the mipmap.</returns>
    public int Height( int mipmapIndex ) =>
        0 <= mipmapIndex && mipmapIndex < NumMipmaps
            ? Header.Flags.HasFlag( DdsHeaderFlags.Height ) ? Math.Max( 1, Header.Height >> mipmapIndex ) : 1
            : throw new ArgumentOutOfRangeException( nameof( mipmapIndex ), mipmapIndex, null );

    /// <summary>
    /// Get the depth of the specified mipmap in this file.
    /// </summary>
    /// <param name="mipmapIndex">Index of the mipmap.</param>
    /// <returns>Depth of the mipmap.</returns>
    public int Depth( int mipmapIndex ) => 0 <= mipmapIndex && mipmapIndex < NumMipmaps
        ? Header.Flags.HasFlag( DdsHeaderFlags.Depth ) ? Math.Max( 1, Header.Depth >> mipmapIndex ) : 1
        : throw new ArgumentOutOfRangeException( nameof( mipmapIndex ), mipmapIndex, null );

    /// <summary>
    /// Get the number of faces in this file.
    /// </summary>
    public int NumFaces => !IsCubeMap
        ? 1
        : ( Header.Caps2.HasFlag( DdsCaps2.CubemapNegativeX ) ? 1 : 0 )
        + ( Header.Caps2.HasFlag( DdsCaps2.CubemapPositiveX ) ? 1 : 0 )
        + ( Header.Caps2.HasFlag( DdsCaps2.CubemapNegativeY ) ? 1 : 0 )
        + ( Header.Caps2.HasFlag( DdsCaps2.CubemapPositiveY ) ? 1 : 0 )
        + ( Header.Caps2.HasFlag( DdsCaps2.CubemapNegativeZ ) ? 1 : 0 )
        + ( Header.Caps2.HasFlag( DdsCaps2.CubemapPositiveZ ) ? 1 : 0 );

    /// <summary>
    /// Get the depth or number of faces of the specified mipmap in this file.
    /// </summary>
    /// <param name="mipmapIndex">Index of the mipmap.</param>
    /// <returns></returns>
    public int DepthOrNumFaces( int mipmapIndex ) => IsCubeMap ? NumFaces : Depth( mipmapIndex );

    /// <summary>
    /// Whether the pixel format indicates an empty value. 
    /// </summary>
    public bool IsPixelFormatEmpty => Header.PixelFormat.Flags == 0 ||
        ( Header.PixelFormat.Flags.HasFlag( DdsPixelFormatFlags.FourCc ) && Header.PixelFormat.FourCc == 0 ) ||
        ( Header.PixelFormat.Flags.HasFlag( DdsPixelFormatFlags.FourCc ) &&
            Header.PixelFormat.FourCc == DdsFourCc.Dx10 && HeaderDxt10.DxgiFormat == 0 );

    /// <summary>
    /// Set Dxt10 header.
    /// </summary>
    /// <param name="format">Corresponding DXGI format.</param>
    /// <param name="arraySize">Number of images in the 2D Texture array. Set to 1 if 0 or negative value is provided.</param>
    /// <param name="miscFlags2">Specify how alpha values are stored.</param>
    public void SetDxt10Header( DxgiFormat format, int arraySize, DdsHeaderDxt10MiscFlags2 miscFlags2 )
    {
        if( arraySize < 1 )
            arraySize = 1;
        Header.PixelFormat = new()
        {
            Size = Unsafe.SizeOf< DdsPixelFormat >(),
            Flags = DdsPixelFormatFlags.FourCc,
            FourCc = DdsFourCc.Dx10,
        };
        HeaderDxt10 = new()
        {
            DxgiFormat = format,
            ResourceDimension = Is1D
                ? DdsHeaderDxt10ResourceDimension.Texture1D
                : Is3D
                    ? DdsHeaderDxt10ResourceDimension.Texture3D
                    : DdsHeaderDxt10ResourceDimension.Texture2D,
            MiscFlag = IsCubeMap ? DdsHeaderDxt10MiscFlags.TextureCube : 0,
            ArraySize = ( IsCubeMap ? 6 : 1 ) * arraySize,
            MiscFlags2 = miscFlags2,
        };
    }

    /// <summary>
    /// Write this DDS file to the given BinaryWriter.
    /// 
    /// Zeroes will be added or extra data will be discarded in Body to fit BodySize.
    /// </summary>
    /// <param name="stream">A <see cref="Stream"/> to write to.</param>
    /// <param name="leaveOpen">Whether to keep the stream open.</param>
    public void WriteTo( Stream stream, bool leaveOpen = false )
    {
        using var writer = new LuminaBinaryWriter( stream, Encoding.UTF8, leaveOpen );
        writer.Write( DdsHeaderWithMagic.MagicValue );
        Header.WriteTo( writer );
        if( UseDxt10Header )
            HeaderDxt10.WriteTo( writer );

        var bodySize = BodySize;
        if( Body.Length < bodySize )
        {
            writer.Write( Body );
            Span< byte > zeroes = stackalloc byte[Math.Min( 4096, bodySize - Body.Length )];
            for( var remaining = bodySize - Body.Length; remaining > 0; remaining -= zeroes.Length )
                writer.Write( zeroes[ ..Math.Min( zeroes.Length, remaining ) ] );
        }
        else if( Body.Length > bodySize )
            writer.Write( Body.AsSpan( 0, bodySize ) );
        else
            writer.Write( Body );

        writer.Write( Tail );
    }

    /// <summary>
    /// Write this DDS file to the specified path.
    /// </summary>
    public void WriteToFile( string path ) => WriteTo( File.Create( path ) );

    /// <summary>
    /// Enumerate all slices' indices.
    /// </summary>
    public IEnumerable< SliceInfo > EnumerateSlices(
        Range? images = default,
        Range? faces = default,
        Range? mipmaps = default,
        Range? slices = default )
    {
        var imageStart = ( images ?? Range.All ).Start.GetOffset( NumImages );
        var imageEnd = ( images ?? Range.All ).End.GetOffset( NumImages );
        var faceStart = ( faces ?? Range.All ).Start.GetOffset( NumFaces );
        var faceEnd = ( faces ?? Range.All ).End.GetOffset( NumFaces );
        var mipmapStart = ( mipmaps ?? Range.All ).Start.GetOffset( NumMipmaps );
        var mipmapEnd = ( mipmaps ?? Range.All ).End.GetOffset( NumMipmaps );
        var si = new SliceInfo();
        for( si.Image = imageStart; si.Image < imageEnd; si.Image++ )
        {
            for( si.Face = faceStart; si.Face < faceEnd; si.Face++ )
            {
                for( si.Mipmap = mipmapStart; si.Mipmap < mipmapEnd; si.Mipmap++ )
                {
                    si.Depth = Depth( si.Mipmap );
                    si.Width = Width( si.Mipmap );
                    si.Height = Height( si.Mipmap );
                    var sliceStart = ( slices ?? Range.All ).Start.GetOffset( si.Depth );
                    var sliceEnd = ( slices ?? Range.All ).End.GetOffset( si.Depth );
                    for( si.Slice = sliceStart; si.Slice < sliceEnd; si.Slice++ )
                        yield return si;
                }
            }
        }
    }

    /// <summary>
    /// Collection of slice index information.
    /// </summary>
    public struct SliceInfo
    {
        /// <summary>
        /// Index of image.
        /// </summary>
        public int Image;

        /// <summary>
        /// Index of face.
        /// </summary>
        public int Face;

        /// <summary>
        /// Index of mipmap.
        /// </summary>
        public int Mipmap;

        /// <summary>
        /// Index of slice, in depth axis.
        /// </summary>
        public int Slice;

        /// <summary>
        /// Depth of mipmap (number of slices).
        /// </summary>
        public int Depth;

        /// <summary>
        /// Width of mipmap.
        /// </summary>
        public int Width;

        /// <summary>
        /// Height of mipmap.
        /// </summary>
        public int Height;
    }
}