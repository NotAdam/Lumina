namespace Lumina.Data.Parsing.Tex;

/// <summary>
/// Fit method for Squish.
/// </summary>
public enum SquishFit
{
    /// <summary>
    /// Use a very slow but very high quality Color compressor.
    /// </summary>
    ColorIterativeClusterFit,

    /// <summary>
    /// Use a slow but high quality Color compressor (default).
    /// </summary>
    ColorClusterFit,

    /// <summary>
    /// Use a fast but low quality Color compressor.
    /// </summary>
    ColorRangeFit,
}