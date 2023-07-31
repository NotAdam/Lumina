using System;

namespace Lumina.Data.Parsing.Tex.DirectDrawSurface;

/// <summary>
/// Specifies the complexity of the surfaces stored in a <see cref="DdsHeader"/>.
/// </summary>
[Flags]
public enum DdsCaps1
{
    /// <summary>
    /// Optional; must be used on any file that contains more than one surface (a mipmap, a cubic
    /// environment map, or mipmapped volume texture).
    /// </summary>
    Complex = 0x8,

    /// <summary>Optional; should be used for a mipmap.	</summary>
    Mipmap = 0x400000,

    /// <summary>Required</summary>
    Texture = 0x1000,
}