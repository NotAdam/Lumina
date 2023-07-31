using System;

namespace Lumina.Data.Parsing.Tex.DirectDrawSurface;

/// <summary>
/// Additional detail about the surfaces stored in a <see cref="DdsHeader"/>.
/// </summary>
[Flags]
public enum DdsCaps2
{
    /// <summary>Required for a cube map.</summary>
    Cubemap = 0x200,

    /// <summary>Required when these surfaces are stored in a cube map.</summary>
    CubemapPositiveX = 0x400,

    /// <summary>Required when these surfaces are stored in a cube map.</summary>
    CubemapNegativeX = 0x800,

    /// <summary>Required when these surfaces are stored in a cube map.</summary>
    CubemapPositiveY = 0x1000,

    /// <summary>Required when these surfaces are stored in a cube map.</summary>
    CubemapNegativeY = 0x2000,

    /// <summary>Required when these surfaces are stored in a cube map.</summary>
    CubemapPositiveZ = 0x4000,

    /// <summary>Required when these surfaces are stored in a cube map.</summary>
    CubemapNegativeZ = 0x8000,

    /// <summary>Required for a volume texture.</summary>
    Volume = 0x200000,

    /// <summary>
    /// Although Direct3D 9 supports partial cube-maps, Direct3D 10, 10.1, and 11 require that you define all six
    /// cube-map faces.
    /// </summary>
    AllFaces =
        Cubemap |
        CubemapPositiveX | CubemapNegativeX |
        CubemapPositiveY | CubemapNegativeY |
        CubemapPositiveZ | CubemapNegativeZ,
}