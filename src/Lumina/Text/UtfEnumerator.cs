using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Lumina.Text.Payloads;
using Lumina.Text.ReadOnly;

namespace Lumina.Text;

/// <summary>Enumerates a UTF-N byte sequence by codepoint.</summary>
[DebuggerDisplay("{Current}/{_data.Length} ({_flags}, BE={_isBigEndian})")]
public ref struct UtfEnumerator
{
    private readonly ReadOnlySpan<byte> _data;
    private readonly UtfEnumeratorFlags _flags;
    private readonly byte _numBytesPerUnit;
    private bool _isBigEndian;

    /// <summary>Initializes a new instance of the <see cref="UtfEnumerator"/> struct.</summary>
    /// <param name="data">UTF-N byte sequence.</param>
    /// <param name="flags">Enumeration flags.</param>
    public UtfEnumerator(ReadOnlySpan<byte> data, UtfEnumeratorFlags flags)
    {
        _data = data;
        _flags = flags;
        _numBytesPerUnit = (_flags & UtfEnumeratorFlags.UtfMask) switch
        {
            UtfEnumeratorFlags.Utf8 or UtfEnumeratorFlags.Utf8SeString => 1,
            UtfEnumeratorFlags.Utf16 => 2,
            UtfEnumeratorFlags.Utf32 => 4,
            _ => throw new ArgumentOutOfRangeException(nameof(flags), flags, "Multiple UTF flag specified."),
        };
        _isBigEndian = (flags & UtfEnumeratorFlags.EndiannessMask) switch
        {
            UtfEnumeratorFlags.NativeEndian => !BitConverter.IsLittleEndian,
            UtfEnumeratorFlags.LittleEndian => false,
            UtfEnumeratorFlags.BigEndian => true,
            _ => throw new ArgumentOutOfRangeException(nameof(flags), flags, "Multiple endianness flag specified."),
        };
    }

    /// <inheritdoc cref="IEnumerator.Current"/>
    public Subsequence Current { get; private set; } = default;

    /// <summary>Creates a new instance of the <see cref="UtfEnumerator"/> struct.</summary>
    /// <param name="data">UTF-N byte sequence.</param>
    /// <param name="flags">Enumeration flags.</param>
    /// <returns>A new enumerator.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static UtfEnumerator From(ReadOnlySpan<byte> data, UtfEnumeratorFlags flags) => new(data, flags);

    /// <summary>Creates a new instance of the <see cref="UtfEnumerator"/> struct.</summary>
    /// <param name="data">UTF-N byte sequence.</param>
    /// <param name="flags">Enumeration flags.</param>
    /// <returns>A new enumerator.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static UtfEnumerator From(ReadOnlySpan<char> data, UtfEnumeratorFlags flags) =>
        new(MemoryMarshal.Cast<char, byte>(data), flags);

    /// <summary>Gets the representative <c>char</c> for a given SeString macro code.</summary>
    /// <param name="macroCode">The macro code.</param>
    /// <returns>Representative <c>char</c>, or <see cref="char.MaxValue"/> if none.</returns>
    public static char RepresentativeCharFor(MacroCode macroCode) => macroCode switch
    {
        MacroCode.NewLine => '\u0085',
        MacroCode.SoftHyphen => '\u00AD',
        MacroCode.NonBreakingSpace => '\u00A0',
        MacroCode.Hyphen => '-',
        MacroCode.Icon or MacroCode.Icon2 => '\uFFFC',
        _ => char.MaxValue,
    };

    /// <summary>Attempts to peek the next item.</summary>
    /// <param name="nextSubsequence">Retrieved next item.</param>
    /// <param name="isStillBigEndian">Whether it still should be parsed in big endian.</param>
    /// <returns><c>true</c> if anything is retrieved.</returns>
    /// <exception cref="EncoderFallbackException">The sequence is not a fully valid Unicode sequence, and
    /// <see cref="UtfEnumeratorFlags.ThrowOnFirstError"/> is set.</exception>
    public readonly bool TryPeekNext(out Subsequence nextSubsequence, out bool isStillBigEndian)
    {
        var offset = Current.ByteOffset + Current.ByteLength;
        isStillBigEndian = _isBigEndian;
        while (true)
        {
            var subspan = _data[offset..];

            if (subspan.IsEmpty)
            {
                nextSubsequence = default;
                return false;
            }

            UtfValue value;
            int length;
            var isBroken =
                _numBytesPerUnit switch
                {
                    1 => !UtfValue.TryDecode8(subspan, out value, out length),
                    2 => !UtfValue.TryDecode16(subspan, isStillBigEndian, out value, out length),
                    4 => !UtfValue.TryDecode32(subspan, isStillBigEndian, out value, out length),
                    _ => throw new InvalidOperationException(),
                };
            if (!isBroken && value.IntValue == 0xFFFE)
            {
                if ((_flags & UtfEnumeratorFlags.DisrespectByteOrderMask) == 0)
                {
                    isStillBigEndian = !isStillBigEndian;
                    value = 0xFEFF;
                }

                if ((_flags & UtfEnumeratorFlags.YieldByteOrderMask) == 0)
                {
                    offset += length;
                    continue;
                }
            }

            if (isBroken || !Rune.IsValid(value))
            {
                switch (_flags & UtfEnumeratorFlags.ErrorHandlingMask)
                {
                    case UtfEnumeratorFlags.ReplaceErrors:
                        break;

                    case UtfEnumeratorFlags.IgnoreErrors:
                        offset = Math.Min(offset + _numBytesPerUnit, _data.Length);
                        continue;

                    case UtfEnumeratorFlags.ThrowOnFirstError:
                        if (isBroken)
                            throw new EncoderFallbackException($"0x{subspan[0]:X02} is not a valid sequence.");
                        throw new EncoderFallbackException(
                            $"U+{value.UIntValue:X08} is not a valid Unicode codepoint.");

                    case UtfEnumeratorFlags.TerminateOnFirstError:
                    default:
                        nextSubsequence = default;
                        return false;
                }
            }

            if (isBroken)
                value = subspan[0];

            if (value == SeString.StartByte && (_flags & UtfEnumeratorFlags.Utf8SeString) != 0)
            {
                var e = new ReadOnlySeStringSpan(subspan).GetEnumerator();
                e.MoveNext();
                switch (_flags & UtfEnumeratorFlags.ErrorHandlingMask)
                {
                    case var _ when e.Current.Type is ReadOnlySePayloadType.Macro:
                        nextSubsequence = Subsequence.FromPayload(
                            e.Current.MacroCode,
                            offset,
                            e.Current.EnvelopeByteLength);
                        return true;

                    case UtfEnumeratorFlags.ReplaceErrors:
                        value = '\uFFFE';
                        length = e.Current.EnvelopeByteLength;
                        isBroken = true;
                        break;

                    case UtfEnumeratorFlags.IgnoreErrors:
                        offset = Math.Min(offset + e.Current.EnvelopeByteLength, _data.Length);
                        continue;

                    case UtfEnumeratorFlags.ThrowOnFirstError:
                        throw new EncoderFallbackException("Invalid SeString payload.");

                    case UtfEnumeratorFlags.TerminateOnFirstError:
                    default:
                        nextSubsequence = default;
                        return false;
                }
            }

            nextSubsequence = Subsequence.FromUnicode(value, offset, length, isBroken);
            return true;
        }
    }

    /// <inheritdoc cref="IEnumerator.MoveNext"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool MoveNext()
    {
        if (!TryPeekNext(out var next, out var isStillBigEndian))
            return false;

        Current = next;
        _isBigEndian = isStillBigEndian;
        return true;
    }

    /// <inheritdoc cref="IEnumerable.GetEnumerator"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UtfEnumerator GetEnumerator() => new(_data, _flags);

    /// <summary>A part of a UTF-N sequence containing one codepoint.</summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    [DebuggerDisplay("[{ByteOffset}, {ByteLength}] {Value}")]
    public readonly struct Subsequence : IEquatable<Subsequence>
    {
        /// <summary>The codepoint. Valid if <see cref="IsSeStringPayload"/> is <c>false</c>.</summary>
        [FieldOffset(0)]
        public readonly UtfValue Value;

        /// <summary>The macro code. Valid if <see cref="IsSeStringPayload"/> is <c>true</c>.</summary>
        [FieldOffset(0)]
        public readonly MacroCode MacroCode;

        /// <summary>The offset of this part of a UTF-8 sequence.</summary>
        [FieldOffset(4)]
        public readonly int ByteOffset;

        /// <summary>The length of this part of a UTF-8 sequence.</summary>
        /// <remarks>This may not match <see cref="UtfValue.Length8"/>, if <see cref="BrokenSequence"/> is <c>true</c>.
        /// </remarks>
        [FieldOffset(8)]
        public readonly int ByteLength;

        /// <summary>Whether this part of the UTF-8 sequence is broken.</summary>
        [FieldOffset(12)]
        public readonly bool BrokenSequence;

        /// <summary>Whether this part of the SeString sequence is a payload.</summary>
        [FieldOffset(13)]
        public readonly bool IsSeStringPayload;

        /// <summary>Storage at byte offset 0, for fast <see cref="Equals(Subsequence)"/> implementation.</summary>
        [FieldOffset(0)]
        private readonly ulong storage0;

        /// <summary>Storage at byte offset 8, for fast <see cref="Equals(Subsequence)"/> implementation.</summary>
        [FieldOffset(8)]
        private readonly ulong storage1;

        /// <summary>Initializes a new instance of the <see cref="Subsequence"/> struct.</summary>
        /// <param name="value">The value.</param>
        /// <param name="byteOffset">The byte offset of this part of a UTF-N sequence.</param>
        /// <param name="byteLength">The byte length of this part of a UTF-N sequence.</param>
        /// <param name="brokenSequence">Whether this part of the UTF-N sequence is broken.</param>
        /// <param name="isSeStringPayload">Whether this part of the SeString sequence is a payload.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private Subsequence(uint value, int byteOffset, int byteLength, bool brokenSequence, bool isSeStringPayload)
        {
            Value = new(value);
            ByteOffset = byteOffset;
            ByteLength = byteLength;
            BrokenSequence = brokenSequence;
            IsSeStringPayload = isSeStringPayload;
        }

        /// <summary>Gets the effective <c>char</c> value, with invalid or non-representable codepoints replaced.
        /// </summary>
        /// <value><see cref="char.MaxValue"/> if the character should not be displayed at all.</value>
        public char EffectiveChar
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => EffectiveInt is var i and >= 0 and < char.MaxValue ? (char)i : char.MaxValue;
        }

        /// <summary>Gets the effective <c>int</c> value, with invalid codepoints replaced.</summary>
        /// <value><see cref="char.MaxValue"/> if the character should not be displayed at all.</value>
        public int EffectiveInt =>
            IsSeStringPayload
                ? RepresentativeCharFor(MacroCode)
                : BrokenSequence || !Value.TryGetRune(out var rune)
                    ? 0xFFFD
                    : rune.Value;

        /// <summary>Gets the effective <see cref="Rune"/> value, with invalid codepoints replaced.</summary>
        /// <value><see cref="char.MaxValue"/> if the character should not be displayed at all.</value>
        public Rune EffectiveRune
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new(EffectiveInt);
        }

        /// <summary>Compares two values to determine equality.</summary>
        /// <param name="left">The value to compare with <paramref name="right" />.</param>
        /// <param name="right">The value to compare with <paramref name="left" />.</param>
        /// <returns>
        /// <see langword="true" /> if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Subsequence left, Subsequence right) => left.Equals(right);

        /// <summary>Compares two values to determine inequality.</summary>
        /// <param name="left">The value to compare with <paramref name="right" />.</param>
        /// <param name="right">The value to compare with <paramref name="left" />.</param>
        /// <returns>
        /// <see langword="true" /> if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Subsequence left, Subsequence right) => !left.Equals(right);

        /// <summary>Creates a new instance of the <see cref="Subsequence"/> struct from a Unicode value.</summary>
        /// <param name="codepoint">The codepoint.</param>
        /// <param name="byteOffset">The byte offset of this part of a UTF-N sequence.</param>
        /// <param name="byteLength">The byte length of this part of a UTF-N sequence.</param>
        /// <param name="brokenSequence">Whether this part of the UTF-N sequence is broken.</param>
        /// <returns>A new instance.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Subsequence FromUnicode(uint codepoint, int byteOffset, int byteLength, bool brokenSequence) =>
            new(codepoint, byteOffset, byteLength, brokenSequence, false);

        /// <summary>Creates a new instance of the <see cref="Subsequence"/> struct from a SeString payload.</summary>
        /// <param name="macroCode">The macro code.</param>
        /// <param name="byteOffset">The byte offset of this part of a UTF-N sequence.</param>
        /// <param name="byteLength">The byte length of this part of a UTF-N sequence.</param>
        /// <returns>A new instance.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Subsequence FromPayload(MacroCode macroCode, int byteOffset, int byteLength) =>
            new((uint)macroCode, byteOffset, byteLength, false, true);

        /// <summary>Tests whether this subsequence contains a valid Unicode codepoint.</summary>
        /// <returns><c>true</c> if this subsequence contains a valid Unicode codepoint.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsValid() => !BrokenSequence && Rune.IsValid(Value);

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Subsequence other) => storage0 == other.storage0 && storage1 == other.storage1;

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object? obj) => obj is Subsequence other && Equals(other);

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(storage0, storage1);
    }
}
