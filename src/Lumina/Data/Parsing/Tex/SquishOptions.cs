using System;
using System.Diagnostics.CodeAnalysis;

namespace Lumina.Data.Parsing.Tex;

/// <summary>
/// Options for Squish in Flags form.
/// </summary>
[Flags]
[SuppressMessage( "ReSharper", "InconsistentNaming" )]
public enum SquishOptions
{
    /// <summary>
    /// No option.
    /// </summary>
    None = 0,

    /// <summary>
    /// Use DXT1 compression.
    /// </summary>
    DXT1 = 1 << 0,

    /// <summary>
    /// Use DXT3 compression.
    /// </summary>
    DXT3 = 1 << 1,

    /// <summary>
    /// Use DXT5 compression.
    /// </summary>
    DXT5 = 1 << 2,

    /// <summary>
    /// Use a very slow but very high quality colour compressor.
    /// </summary>
    ColourIterativeClusterFit = 1 << 3,

    /// <summary>
    /// Use a slow but high quality colour compressor (default).
    /// </summary>
    ColourClusterFit = 1 << 4,

    /// <summary>
    /// Use a fast but low quality colour compressor.
    /// </summary>
    ColourRangeFit = 1 << 5,

    /// <summary>
    /// Use a perceptual metric for colour error (default).
    /// </summary>
    ColourMetricPerceptual = 1 << 6,

    /// <summary>
    /// Use a uniform metric for colour error.
    /// </summary>
    ColourMetricUniform = 1 << 7,

    /// <summary>
    /// Weight the colour by alpha during cluster fit (off by default).
    /// </summary>
    WeightColourByAlpha = 1 << 8,
}