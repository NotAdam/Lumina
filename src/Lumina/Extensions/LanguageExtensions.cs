using Lumina.Data;
using System;

namespace Lumina.Extensions;

public static class LanguageExtensions
{
    public static string GetName( this Language language )
    {
        return language switch
        {
            Language.None => "",
            Language.Japanese => "ja",
            Language.English => "en",
            Language.German => "de",
            Language.French => "fr",
            Language.ChineseSimplified => "chs",
            Language.ChineseTraditional => "cht",
            Language.Korean => "ko",
            _ => throw new ArgumentOutOfRangeException( nameof( language ), language, null )
        };
    }
}
