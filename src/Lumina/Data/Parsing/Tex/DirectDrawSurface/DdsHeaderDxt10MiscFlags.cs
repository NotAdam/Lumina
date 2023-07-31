using System;

namespace Lumina.Data.Parsing.Tex.DirectDrawSurface;

/// <summary>
/// Identifies other, less common options for resources.
/// </summary>
[Flags]
public enum DdsHeaderDxt10MiscFlags
{
    /// <summary>Indicates a 2D texture is a cube-map texture.</summary>
    TextureCube = 4,
}