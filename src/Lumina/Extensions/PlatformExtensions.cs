using Lumina.Data;
using System;

namespace Lumina.Extensions;

public static class PlatformExtensions
{
    public static string GetName( this PlatformType platform )
    {
        return platform switch
        {
            PlatformType.Win32 => "win32",
            PlatformType.PS3 => "ps3",
            PlatformType.PS4 => "ps4",
            PlatformType.PS5 => "ps5",
            PlatformType.Lys => "lys",
            _ => throw new ArgumentOutOfRangeException( nameof( platform ), platform, null )
        };
    }
}
