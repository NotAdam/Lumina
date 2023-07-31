namespace Lumina.Data.Parsing.Tex.DirectDrawSurface;

/// <summary>
/// Identifies the type of resource being used.
/// </summary>
public enum DdsHeaderDxt10ResourceDimension
{
    /// <summary>
    /// Resource is of unknown type.
    /// </summary>
    Unknown = 0,

    /// <summary>
    /// Resource is a buffer.
    /// </summary>
    Buffer = 1,

    /// <summary>
    /// Resource is a 1D texture.
    /// </summary>
    Texture1D = 2,

    /// <summary>
    /// Resource is a 2D texture.
    /// </summary>
    Texture2D = 3,

    /// <summary>
    /// Resource is a 3D texture.
    /// </summary>
    Texture3D = 4
}