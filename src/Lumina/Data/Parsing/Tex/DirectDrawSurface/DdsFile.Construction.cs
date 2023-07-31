using System;
using System.IO;
using System.Text;
using Lumina.Data.Structs;

namespace Lumina.Data.Parsing.Tex.DirectDrawSurface;

public partial class DdsFile
{
    /// <summary>
    /// Construct a new and empty instance of the class.
    ///
    /// All values are set to zero; correct values in the header must be set.
    /// </summary>
    public DdsFile()
    {
        Body = Array.Empty< byte >();
        Tail = Array.Empty< byte >();
    }

    /// <summary>
    /// Construct a new instance of the class from the given values, and allocate the buffers.
    /// </summary>
    public DdsFile( in DdsHeader header )
    {
        Header = header;
        Body = new byte[BodySize];
        Tail = Array.Empty< byte >();
    }

    /// <summary>
    /// Construct a new instance of the class from the given values, and allocate the buffers.
    /// </summary>
    public DdsFile( in DdsHeader header, in DdsHeaderDxt10 headerDxt10 )
    {
        Header = header;
        HeaderDxt10 = headerDxt10;
        Body = new byte[BodySize];
        Tail = Array.Empty< byte >();
    }

    /// <summary>
    /// Construct a new instance of the class from the given values.
    /// </summary>
    /// <param name="header"></param>
    /// <param name="data">The pixel buffer.</param>
    /// <param name="tail">Extra data after the pixel buffer.</param>
    public DdsFile( in DdsHeader header, byte[] data, byte[] tail )
    {
        Header = header;
        Body = data;
        Tail = tail;
    }

    /// <summary>
    /// Construct a new instance of the class from the given values.
    /// </summary>
    /// <param name="header"></param>
    /// <param name="headerDxt10"></param>
    /// <param name="data">The pixel buffer.</param>
    /// <param name="tail">Extra data after the pixel buffer.</param>
    public DdsFile( in DdsHeader header, in DdsHeaderDxt10 headerDxt10, byte[] data, byte[] tail )
    {
        Header = header;
        HeaderDxt10 = headerDxt10;
        Body = data;
        Tail = tail;
    }

    /// <summary>
    /// Construct a new instance of the class from a stream.
    ///
    /// If the file is shorter than the calculated <see cref="BodySize"/>, the unfilled data will be kept as zeroes.
    /// If the file is longer than the calculated <see cref="BodySize"/>, the rest will be used as <see cref="Tail"/>
    /// </summary>
    public static DdsFile FromStream( Stream stream, bool leaveOpen = false )
    {
        using var br = new LuminaBinaryReader( stream, Encoding.UTF8, leaveOpen, PlatformId.Win32 );
        if( br.ReadUInt32() != DdsHeaderWithMagic.MagicValue )
            throw new InvalidDataException( "Invalid header value." );
        var header = new DdsHeader();
        header.ReadFrom( br );
        var headerDxt10 = new DdsHeaderDxt10();
        if( header.PixelFormat.Flags.HasFlag( DdsPixelFormatFlags.FourCc ) && header.PixelFormat.FourCc == DdsFourCc.Dx10 )
            headerDxt10.ReadFrom( br );

        var res = new DdsFile( header, headerDxt10 );
        _ = br.Read( res.Body );

        res.Tail = new byte[br.BaseStream.Length - br.BaseStream.Position];
        if( br.Read( res.Tail ) != res.Tail.Length )
            throw new IOException( "Failed to completely read the stream." );
        return res;
    }

    /// <summary>
    /// Construct a new instance of the class from a file.
    /// </summary>
    public static DdsFile FromFile( string path ) => FromStream( File.OpenRead( path ) );
}