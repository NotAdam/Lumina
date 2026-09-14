using Lumina.Data;
using System;

namespace Lumina.Extensions;

public static class CategoryExtensions
{
    public static string GetName( this CategoryType category ) =>
        category switch
        {
            CategoryType.Common => "common",
            CategoryType.BgCommon => "bgcommon",
            CategoryType.Bg => "bg",
            CategoryType.Cut => "cut",
            CategoryType.Chara => "chara",
            CategoryType.Shader => "shader",
            CategoryType.Ui => "ui",
            CategoryType.Sound => "sound",
            CategoryType.Vfx => "vfx",
            CategoryType.UiScript => "ui_script",
            CategoryType.Exd => "exd",
            CategoryType.GameScript => "game_script",
            CategoryType.Music => "music",
            CategoryType.SqpackTest => "sqpack_test",
            CategoryType.Debug => "debug",
            _ => throw new ArgumentOutOfRangeException( nameof( category ), category, null ),
        };

    public static CategoryType GetCategoryType( string name ) =>
        GetCategoryType( name.AsSpan() );

    /// <summary>
    /// Returns the <see cref="CategoryType"/> corresponding to the given category name.
    /// </summary>
    /// <param name="name">The category name to convert to a <see cref="CategoryType"/>.</param>
    /// <returns>The <see cref="CategoryType"/> corresponding to the given category name.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the given category name does not correspond to a valid <see cref="CategoryType"/>.</exception>
    public static CategoryType GetCategoryType( ReadOnlySpan< char > name ) =>
        name switch
        {
            "common" => CategoryType.Common,
            "bgcommon" => CategoryType.BgCommon,
            "bg" => CategoryType.Bg,
            "cut" => CategoryType.Cut,
            "chara" => CategoryType.Chara,
            "shader" => CategoryType.Shader,
            "ui" => CategoryType.Ui,
            "sound" => CategoryType.Sound,
            "vfx" => CategoryType.Vfx,
            "ui_script" => CategoryType.UiScript,
            "exd" => CategoryType.Exd,
            "game_script" => CategoryType.GameScript,
            "music" => CategoryType.Music,
            "sqpack_test" => CategoryType.SqpackTest,
            "debug" => CategoryType.Debug,
            _ => throw new ArgumentOutOfRangeException( nameof( name ), name.ToString(), null ),
        };
}
