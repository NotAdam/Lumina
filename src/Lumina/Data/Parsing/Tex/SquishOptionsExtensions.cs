namespace Lumina.Data.Parsing.Tex;

/// <summary>
/// Convenient methods for accessing <see cref="SquishOptions" />.
/// </summary>
public static class SquishOptionsExtensions
{
    /// <summary>
    /// Get the method embedded in the flags.
    /// </summary>
    /// <param name="self">The flags.</param>
    /// <returns>The method embedded in flags.</returns>
    public static SquishOptions GetMethod( this SquishOptions self ) =>
        self & ( SquishOptions.DXT1 | SquishOptions.DXT3 | SquishOptions.DXT5 );

    /// <summary>
    /// Get the fit embedded in the flags.
    /// </summary>
    /// <param name="self">The flags.</param>
    /// <returns>The fit embedded in flags.</returns>
    public static SquishOptions GetFit( this SquishOptions self ) =>
        self & ( SquishOptions.ColourIterativeClusterFit | SquishOptions.ColourClusterFit |
            SquishOptions.ColourRangeFit );

    /// <summary>
    /// Get the metric embedded in the flags.
    /// </summary>
    /// <param name="self">The flags.</param>
    /// <returns>The metric embedded in flags.</returns>
    public static SquishOptions GetMetric( this SquishOptions self ) =>
        self & ( SquishOptions.ColourMetricPerceptual | SquishOptions.ColourMetricUniform );

    /// <summary>
    /// Get the miscellaneous options embedded in the flags.
    /// </summary>
    /// <param name="self">The flags.</param>
    /// <returns>The miscellaneous options embedded in flags.</returns>
    public static SquishOptions GetExtra( this SquishOptions self ) =>
        self & SquishOptions.WeightColourByAlpha;
}