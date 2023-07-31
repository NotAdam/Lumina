using System;
using System.Numerics;
using System.Threading;

namespace Lumina.Data.Parsing.Tex;

/// <summary>
/// Options for use with Squish.
/// </summary>
public class SquishOptions2 : ICloneable
{
    /// <summary>
    /// Perceptual weight when compressing using Cluster Fit methods.
    /// </summary>
    public static readonly Vector3 PerceptualWeight = new( 0.2126f, 0.7152f, 0.0722f );

    /// <summary>
    /// Uniform weight when compressing using Cluster Fit methods.
    /// </summary>
    public static readonly Vector3 UniformWeight = Vector3.One;

    /// <summary>
    /// Channel offsets for red, green, blue, and alpha channels, in RGBA pixel format.
    /// </summary>
    public static readonly Tuple< byte, byte, byte, byte > OffsetRgba = new( 0, 1, 2, 3 );

    /// <summary>
    /// Channel offsets for red, green, blue, and alpha channels, in BGRA pixel format.
    /// </summary>
    public static readonly Tuple< byte, byte, byte, byte > OffsetBgra = new( 2, 1, 0, 3 );

    /// <summary>
    /// Channel offsets for red, green, blue, and alpha channels, in ARGB pixel format.
    /// </summary>
    public static readonly Tuple< byte, byte, byte, byte > OffsetArgb = new( 1, 2, 3, 0 );

    /// <summary>
    /// Channel offsets for red, green, blue, and alpha channels, in ABGR pixel format.
    /// </summary>
    public static readonly Tuple< byte, byte, byte, byte > OffsetAbgr = new( 3, 2, 1, 0 );

    /// <summary>
    /// The weights for cluster fit compression.
    /// </summary>
    public Vector3 Weights = UniformWeight;

    /// <summary>
    /// The compression method.
    /// </summary>
    public SquishMethod Method;

    /// <summary>
    /// Essentially the compression level.
    /// </summary>
    public SquishFit Fit = SquishFit.ColorClusterFit;

    /// <summary>
    /// Weight the color by alpha during cluster fit.
    /// </summary>
    public bool WeightColorByAlpha = false;

    /// <summary>
    /// Offset of the blue channel byte in a pixel.
    ///
    /// If not less than <see cref="NumBytesPerPixel"/>, 0 is assumed.
    /// </summary>
    public byte OffsetB = 0;

    /// <summary>
    /// Offset of the green channel byte in a pixel.
    ///
    /// If not less than <see cref="NumBytesPerPixel"/>, 0 is assumed.
    /// </summary>
    public byte OffsetG = 1;

    /// <summary>
    /// Offset of the red channel byte in a pixel.
    ///
    /// If not less than <see cref="NumBytesPerPixel"/>, 0 is assumed.
    /// </summary>
    public byte OffsetR = 2;

    /// <summary>
    /// Offset of the alpha channel byte in a pixel.
    ///
    /// If not less than <see cref="NumBytesPerPixel"/>, 255 is assumed.
    /// </summary>
    public byte OffsetA = 3;

    /// <summary>
    /// Number of bytes per pixel.
    /// </summary>
    public byte NumBytesPerPixel = 4;

    /// <summary>
    /// The cancellation token, in case of asynchronous compression.
    /// </summary>
    public CancellationToken CancellationToken;

    /// <summary>
    /// Number of threads to use during asynchronous compression.
    ///
    /// Any value less than 1 will be equivalent to using <see cref="Environment.ProcessorCount" />.
    /// </summary>
    public int Threads = 0;

    /// <summary>
    /// Construct a new SquishOptions2, with the specified compression method.
    /// </summary>
    /// <param name="method">Compression method.</param>
    public SquishOptions2( SquishMethod method )
    {
        Method = method;
    }

    /// <summary>
    /// Construct a new SquishOptions2, from a <see cref="SquishOptions" />.
    /// </summary>
    /// <param name="flags">Configuration flags.</param>
    public SquishOptions2( SquishOptions flags )
    {
        Method = flags.GetMethod() switch
        {
            SquishOptions.DXT1 => SquishMethod.Dxt1,
            SquishOptions.DXT3 => SquishMethod.Dxt3,
            SquishOptions.DXT5 => SquishMethod.Dxt5,
            _ => throw new ArgumentOutOfRangeException( nameof( flags ), flags, "Invalid method set (specify 1)" ),
        };
        Fit = flags.GetFit() switch
        {
            SquishOptions.None => SquishFit.ColorClusterFit,
            SquishOptions.ColourIterativeClusterFit => SquishFit.ColorIterativeClusterFit,
            SquishOptions.ColourClusterFit => SquishFit.ColorClusterFit,
            SquishOptions.ColourRangeFit => SquishFit.ColorRangeFit,
            _ => throw new ArgumentOutOfRangeException( nameof( flags ), flags, "Invalid fit set (specify 0 or 1)" ),
        };
        Weights = flags.GetMethod() switch
        {
            SquishOptions.None => Vector3.One,
            SquishOptions.ColourMetricUniform => Vector3.One,
            SquishOptions.ColourMetricPerceptual => PerceptualWeight,
            _ => throw new ArgumentOutOfRangeException( nameof( flags ), flags, "Invalid metric set (specify 0 or 1)" ),
        };
        WeightColorByAlpha = flags.HasFlag( SquishOptions.WeightColourByAlpha );
    }

    /// <summary>
    /// Get or set the offsets of a channel, in R, G, B, and A order.
    /// </summary>
    public Tuple< byte, byte, byte, byte > ChannelOffsets {
        get => new( OffsetR, OffsetG, OffsetB, OffsetA );
        set => ( OffsetR, OffsetG, OffsetB, OffsetA ) = value;
    }

    /// <summary>
    /// Number of bytes per block, according to the compression method.
    /// </summary>
    public int BytesPerBlock => Method is SquishMethod.Bc1 or SquishMethod.Bc4S or SquishMethod.Bc4U ? 8 : 16;

    /// <inheritdoc/>
    public object Clone() => MemberwiseClone();
}