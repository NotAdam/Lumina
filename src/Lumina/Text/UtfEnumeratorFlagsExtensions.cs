using System;

namespace Lumina.Text;

/// <summary>Utilities for <see cref="UtfEnumeratorFlags"/>.</summary>
public static class UtfEnumeratorFlagsExtensions
{
    /// <summary>Gets the minimum number of bytes taken for a single codepoint.</summary>
    /// <param name="flags">Flags.</param>
    /// <returns>Minimum number of bytes per codepoint.</returns>
    public static byte GetMinimumCodepointByteCount( this UtfEnumeratorFlags flags ) => ( flags & UtfEnumeratorFlags.UtfMask ) switch
    {
        UtfEnumeratorFlags.Utf8 or UtfEnumeratorFlags.Utf8SeString => 1,
        UtfEnumeratorFlags.Utf16 => 2,
        UtfEnumeratorFlags.Utf32 => 4,
        _ => throw new ArgumentOutOfRangeException( nameof( flags ), flags, "Multiple UTF flag specified." ),
    };

    /// <summary>Gets a value indicating whether to begin parsing in big endian mode.</summary>
    /// <param name="flags">Flags.</param>
    /// <returns><c>true</c> if bytes should be interpreted in big endian.</returns>
    public static bool IsEffectivelyBigEndian( this UtfEnumeratorFlags flags ) => ( flags & UtfEnumeratorFlags.EndiannessMask ) switch
    {
        UtfEnumeratorFlags.NativeEndian => !BitConverter.IsLittleEndian,
        UtfEnumeratorFlags.LittleEndian => false,
        UtfEnumeratorFlags.BigEndian => true,
        _ => throw new ArgumentOutOfRangeException( nameof( flags ), flags, "Multiple endianness flag specified." ),
    };
}