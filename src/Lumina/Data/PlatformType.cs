using System.Diagnostics.CodeAnalysis;

namespace Lumina.Data;

[SuppressMessage( "ReSharper", "InconsistentNaming" )]
public enum PlatformType : byte
{
    Win32,
    PS3,
    PS4,
    PS5,
    Lys // Xbox
}
