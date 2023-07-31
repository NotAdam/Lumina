namespace Lumina.Data.Parsing.Tex;

/// <summary>
/// Compression method for Squish.
/// </summary>
public enum SquishMethod
{
    /// <summary>
    /// Use DXT1 (BC1) compression.
    ///
    /// Assumes <see cref="byte"/> as channel values.
    /// </summary>
    Bc1,

    /// <summary>
    /// Use DXT3 (BC2) compression.
    ///
    /// Assumes <see cref="byte"/> as channel values.
    /// </summary>
    Bc2,

    /// <summary>
    /// Use DXT5 (BC3) compression.
    ///
    /// Assumes <see cref="byte"/> as channel values.
    /// </summary>
    Bc3,

    /// <summary>
    /// Use BC4 (ATI1) compression.
    /// Uses one channel: R.
    /// 
    /// Assumes <see cref="byte"/> as channel values.
    /// </summary>
    Bc4,

    /// <summary>
    /// Use BC4 (ATI1) compression.
    /// Uses one channel: R.
    /// 
    /// Assumes <see cref="sbyte"/> as channel values.
    /// </summary>
    Bc4S,

    /// <summary>
    /// Use BC5 (ATI2) compression.
    /// Uses two channels: R and G.
    /// 
    /// Assumes <see cref="byte"/> as channel values.
    /// </summary>
    Bc5,

    /// <summary>
    /// Use BC5 (ATI2) compression.
    /// Uses two channels: R and G.
    /// 
    /// Assumes <see cref="sbyte"/> as channel values.
    /// </summary>
    Bc5S,

    /// <summary>
    /// Use BC7 (BPTC BC7) compression.
    ///
    /// Assumes <see cref="byte"/> as channel values.
    /// </summary>
    Bc7,

    /// <summary>
    /// Alias for BC1.
    /// </summary>
    Dxt1 = Bc1,

    /// <summary>
    /// Alias for BC2.
    /// </summary>
    Dxt3 = Bc2,

    /// <summary>
    /// Alias for BC3.
    /// </summary>
    Dxt5 = Bc3,

    /// <summary>
    /// Alias for BC4.
    /// </summary>
    Bc4U = Bc4,

    /// <summary>
    /// Alias for BC5.
    /// </summary>
    Bc5U = Bc5,
}