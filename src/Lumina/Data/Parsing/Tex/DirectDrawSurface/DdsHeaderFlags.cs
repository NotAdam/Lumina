using System;

namespace Lumina.Data.Parsing.Tex.DirectDrawSurface;

/// <summary>
/// Flags to indicate which members of <see cref="DdsHeader"/> contain valid data.
/// </summary>
[Flags]
public enum DdsHeaderFlags
{
    /// <summary>Required in every .dds file.</summary>
    Caps = 0x1,

    /// <summary>Required in every .dds file.</summary> 
    Height = 0x2,

    /// <summary>Required in every .dds file.</summary>
    Width = 0x4,

    /// <summary>Required when pitch is provided for an uncompressed texture.</summary> 
    Pitch = 0x8,

    /// <summary>Required in every .dds file.</summary> 
    PixelFormat = 0x1000,

    /// <summary>Required in a mipmapped texture.</summary> 
    MipmapCount = 0x20000,

    /// <summary>Required when pitch is provided for a compressed texture.</summary>
    LinearSize = 0x80000,

    /// <summary>Required in a depth texture</summary> 
    Depth = 0x800000,

    /// <summary>
    /// Alias for setting this up for 1D.
    /// </summary>
    Dimension1 = Width,

    /// <summary>
    /// Alias for setting this up for 2D.
    /// </summary>
    Dimension2 = Width | Height,

    /// <summary>
    /// Alias for setting this up for 3D.
    /// </summary>
    Dimension3 = Width | Height | Depth,

    /// <summary>
    /// Alias for all the bits for configuring dimensions.
    /// </summary>
    DimensionMask = Dimension3,
}