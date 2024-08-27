using System;
using System.Diagnostics.CodeAnalysis;
using Lumina.Misc;

namespace Lumina.Text.Parse;

/// <summary>Exception thrown when macro string parsing has failed.</summary>
public sealed class MacroStringParseException : InvalidOperationException
{
    /// <summary>Initializes a new instance of the <see cref="MacroStringParseException"/> class.</summary>
    /// <param name="message">Error message.</param>
    /// <param name="byteOffset">Byte offset in <paramref name="data"/> that caused parse failure.</param>
    /// <param name="data">Data failed to parse.</param>
    /// <param name="parseOptions">Options used to parse.</param>
    public MacroStringParseException( string message, int byteOffset, ReadOnlySpan< byte > data, scoped in MacroStringParseOptions parseOptions )
        : this(
            $"{message} at {FormatOffset( byteOffset, data, parseOptions, out var codepointIndex, out var beforeError, out var afterError )}",
            byteOffset,
            codepointIndex,
            beforeError,
            afterError )
    { }

    private MacroStringParseException( string message, int byteOffset, int codepointIndex, string beforeError, string afterError )
        : base( message )
    {
        ByteOffset = byteOffset;
        CodepointIndex = codepointIndex;
        BeforeError = beforeError;
        AfterError = afterError;
    }

    /// <summary>Gets the byte offset in the input string that failed to parse.</summary>
    public int ByteOffset { get; }

    /// <summary>Gets the codepoint index in the input string that failed to parse.</summary>
    [SuppressMessage( "ReSharper", "UnusedAutoPropertyAccessor.Global", Justification = "Consumers outside the library" )]
    public int CodepointIndex { get; }

    /// <summary>Gets the text fragment before the error.</summary>
    [SuppressMessage( "ReSharper", "UnusedAutoPropertyAccessor.Global", Justification = "Consumers outside the library" )]
    public string BeforeError { get; }

    /// <summary>Gets the text fragment after the error.</summary>
    [SuppressMessage( "ReSharper", "UnusedAutoPropertyAccessor.Global", Justification = "Consumers outside the library" )]
    public string AfterError { get; }

    private static string FormatOffset(
        int byteOffset,
        ReadOnlySpan< byte > data,
        scoped in MacroStringParseOptions parseOptions,
        out int charIndex,
        out string beforeError,
        out string afterError )
    {
        var storage = MemoryChunkStorage.AsSpanUninitialized< char >( out _ );
        var prevLen = 0;
        var nextLen = 0;

        var prevOverflow = false;
        var nextOverflow = false;
        charIndex = 0;
        foreach( var c in new UtfEnumerator( data, parseOptions.CharEnumerationFlags & ~UtfEnumeratorFlags.ErrorHandlingMask ) )
        {
            var rune = c.EffectiveRune;

            if( c.ByteOffset >= byteOffset )
            {
                var overflow = prevLen + nextLen + rune.Utf16SequenceLength - storage.Length;
                if( overflow > 0 )
                {
                    if( nextLen > storage.Length / 2 )
                    {
                        nextOverflow = true;
                        break;
                    }

                    storage[ overflow.. ].CopyTo( storage );
                    prevLen -= overflow;
                    prevOverflow = true;
                }

                nextLen += rune.EncodeToUtf16( storage[ ( prevLen + nextLen ).. ] );
            }
            else
            {
                var overflow = prevLen + rune.Utf16SequenceLength - storage.Length;
                if( overflow > 0 )
                {
                    storage[ overflow.. ].CopyTo( storage );
                    prevLen -= overflow;
                    prevOverflow = true;
                }

                prevLen += rune.EncodeToUtf16( storage[ prevLen.. ] );
                charIndex++;
            }
        }

        beforeError = ( prevOverflow ? "..." : "" ) + storage[ ..prevLen ].ToString();
        afterError = storage.Slice( prevLen, nextLen ).ToString() + ( nextOverflow ? "..." : "" );
        return $"{charIndex} (byte offset at {byteOffset}); \"{beforeError}\" ^^^^^ \"{afterError}\"";
    }
}