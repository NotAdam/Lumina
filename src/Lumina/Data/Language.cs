using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lumina.Data
{
    public enum Language : ushort
    {
        /// <summary>
        /// No language
        /// </summary>
        [Display( Name = "" )]
        None,
        [Display( Name = "ja" )]
        Japanese,
        [Display( Name = "en" )]
        English,
        [Display( Name = "de" )]
        German,
        [Display( Name = "fr" )]
        French,
        [Display( Name = "chs" )]
        ChineseSimplified,
        [Display( Name = "cht" )]
        ChineseTraditional,
        [Display( Name = "ko" )]
        Korean
    }

    public class LanguageUtil
    {
        public static readonly Dictionary< Language, string > LanguageMap = new Dictionary< Language, string >()
        {
            { Language.None, "" },
            { Language.Japanese, "ja" },
            { Language.English, "en" },
            { Language.German, "de" },
            { Language.French, "fr" },
            { Language.ChineseSimplified, "chs" },
            { Language.ChineseTraditional, "cht" },
            { Language.Korean, "ko" },
        };

        public static string GetLanguageStr( Language lang )
        {
            return LanguageMap[ lang ];
        }
    }
}