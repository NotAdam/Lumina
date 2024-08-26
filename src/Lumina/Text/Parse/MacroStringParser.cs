using System;
using System.Runtime.InteropServices;
using System.Text;
using Lumina.Text.Expressions;
using Lumina.Text.Payloads;
using Lumina.Text.ReadOnly;

namespace Lumina.Text.Parse;

internal readonly ref struct MacroStringParser
{
    // Map from ascii code to supposed number.
    // -1 = invalid, -2 = ignore.
    private static readonly sbyte[] Digits =
    [
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
        -1, -1, -1, -1, -1, -1, -1, -2, -1, -1, -1, -1, -1, -1, -1, -1, // _
        +0, +1, +2, +3, +4, +5, +6, +7, +8, +9, -1, -1, -1, -1, -1, -1, // 0-9
        10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, // A-F
        -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -2, // '
        10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, // a-f
    ];

    private readonly ReadOnlySpan< byte > _macroString;
    private readonly MacroStringParseOptions _parseOptions;
    private readonly SeStringBuilder _builder;

    internal MacroStringParser( ReadOnlySpan< byte > macroString, SeStringBuilder builder, MacroStringParseOptions parseOptions )
    {
        _macroString = macroString;
        _builder = builder;
        _parseOptions = parseOptions;
    }

    /// <summary>Parses the macro string.</summary>
    /// <returns>The builder.</returns>
    public int ParseMacroStringAndAppend( int offset, bool stopOnCharRequiringEscape, ReadOnlySpan< byte > extraTerminators )
    {
        var beginOffset = offset;
        while( new UtfEnumerator( _macroString[ offset.. ], _parseOptions.CharEnumerationFlags ).TryPeekNext( out var s, out _ ) )
        {
            if( s.IsSeStringPayload )
            {
                _builder.Append( new ReadOnlySeStringSpan( _macroString.Slice( offset + s.ByteOffset, s.ByteLength ) ) );
                continue;
            }

            switch( s.Value.UIntValue )
            {
                case '\\':
                    offset += ParseMacroStringTextAndAppend( offset, extraTerminators );
                    break;

                case <= byte.MaxValue when extraTerminators.Contains( (byte) s.Value.UIntValue ):
                    return offset - beginOffset;

                case '<' when _parseOptions.ExceptionMode is MacroStringParseExceptionMode.Throw:
                    offset += ParseMacroStringPayloadAndAppend( offset, extraTerminators );
                    break;

                case '<':
                    try
                    {
                        offset += ParseMacroStringPayloadAndAppend( offset, extraTerminators );
                    }
                    catch( MacroStringParseException e )
                    {
                        var byteLength = Math.Max( s.ByteLength, e.Offset - offset );
                        var sliceUntilError = _macroString.Slice( offset, byteLength );
                        _builder.Append( new UtfEnumerator( sliceUntilError, _parseOptions.CharEnumerationFlags ) );
                        if( _parseOptions.ExceptionMode == MacroStringParseExceptionMode.EmbedError )
                            _builder.Append( "<ERROR: " ).Append( e.Message ).Append( ">" );
                        offset += byteLength;
                    }

                    break;

                case <= byte.MaxValue when CharRequiresEscapeInSeString( s.Value.UIntValue ):
                    if( stopOnCharRequiringEscape )
                        return offset - beginOffset;

                    var v = unchecked( (byte) s.Value.UIntValue );
                    _builder.Append( MemoryMarshal.CreateReadOnlySpan( ref v, 1 ) );
                    offset += s.ByteLength;
                    break;

                default:
                    offset += ParseMacroStringTextAndAppend( offset, extraTerminators );
                    break;
            }
        }

        return offset - beginOffset;
    }

    private int ParseMacroStringTextAndAppend( int offset, ReadOnlySpan< byte > extraTerminators )
    {
        var nextIsEscaped = false;
        foreach( var c in new UtfEnumerator( _macroString[ offset.. ], _parseOptions.CharEnumerationFlags ) )
        {
            switch( c.Value.UIntValue )
            {
                case var _ when nextIsEscaped:
                    nextIsEscaped = false;
                    goto default;
                case '\\':
                    nextIsEscaped = true;
                    break;
                case var _ when CharRequiresEscapeInSeString( c.Value ):
                case var b and <= byte.MaxValue when extraTerminators.Contains( (byte) b ):
                    return c.ByteOffset;
                default:
                    _builder.Append( c );
                    break;
            }
        }

        return _macroString.Length - offset;
    }

    private int ParseMacroStringPayloadAndAppend( int offset, ReadOnlySpan< byte > extraTerminators )
    {
        var beginOffset = offset;
        ConsumeStart( ref offset, "<"u8 );
        SkipWhitespaces( ref offset );
        var macroCode = ParseMacroCode( ref offset );
        SkipWhitespaces( ref offset );

        _builder.BeginMacro( macroCode );

        try
        {
            if( TryConsumeStart( ref offset, "("u8 ) )
            {
                var first = true;
                while( true )
                {
                    if( offset >= _macroString.Length )
                        throw new MacroStringParseException( "Unexpected EOF", offset );

                    if( TryConsumeStart( ref offset, ")"u8 ) )
                        break;

                    if( first )
                        first = false;
                    else
                        ConsumeStart( ref offset, ","u8, "\",\" or \")\"" );

                    offset += ParseMacroStringExpressionAndAppend( offset, extraTerminators );
                }

                SkipWhitespaces( ref offset );
            }

            ConsumeStart( ref offset, ">"u8 );
            _builder.EndMacro();
            return offset - beginOffset;
        }
        catch( Exception e1 )
        {
            try
            {
                _builder.AbortMacro();
            }
            catch( Exception e2 )
            {
                throw new AggregateException( e1, e2 );
            }

            throw;
        }
    }

    private int ParseMacroStringExpressionAndAppend( int offset, ReadOnlySpan< byte > extraTerminators )
    {
        var abortExpression = false;

        try
        {
            var beginOffset = offset;
            if( TryConsumeStart( ref offset, "["u8 ) )
            {
                _builder.BeginBinaryExpression( ExpressionType.Equal );

                abortExpression = true;
                offset += ParseMacroStringExpressionAndAppend( offset, "=!<>"u8 );

                var op1 = -1;
                var op2 = -1;
                var len1 = 0;
                var len2 = 0;
                foreach( var e in new UtfEnumerator( _macroString[ offset.. ], _parseOptions.CharEnumerationFlags ) )
                {
                    var c = e.Value.IntValue is '!' or '=' or '<' or '>' ? e.Value.IntValue : 0;
                    if( c == 0 )
                        break;

                    if( op1 == -1 )
                    {
                        op1 = (byte) c;
                        len1 = e.ByteLength;
                    }
                    else
                    {
                        op2 = (byte) c;
                        len2 = e.ByteLength;
                        break;
                    }
                }

                switch( op1 )
                {
                    case '=' when op2 == '=':
                        offset += len1 + len2;
                        _builder.ChangeBinaryExpression( ExpressionType.Equal );
                        break;
                    case '!' when op2 == '=':
                        offset += len1 + len2;
                        _builder.ChangeBinaryExpression( ExpressionType.NotEqual );
                        break;
                    case '<' when op2 == '=':
                        offset += len1 + len2;
                        _builder.ChangeBinaryExpression( ExpressionType.LessThanOrEqualTo );
                        break;
                    case '<':
                        offset += len1;
                        _builder.ChangeBinaryExpression( ExpressionType.LessThan );
                        break;
                    case '>' when op2 == '=':
                        offset += len1 + len2;
                        _builder.ChangeBinaryExpression( ExpressionType.GreaterThanOrEqualTo );
                        break;
                    case '>':
                        offset += len1;
                        _builder.ChangeBinaryExpression( ExpressionType.GreaterThan );
                        break;
                    default:
                        throw new MacroStringParseException(
                            $"Unsupported binary expression: {( op1 == -1 ? "" : "" + (char) op1 )}{( op2 == -1 ? "" : "" + (char) op2 )}", offset );
                }

                offset += ParseMacroStringExpressionAndAppend( offset, extraTerminators );
                ConsumeStart( ref offset, "]"u8 );

                _builder.EndExpression();
                return offset - beginOffset;
            }

            _builder.BeginStringExpression();

            abortExpression = true;
            var length = ParseMacroStringAndAppend( offset, true, extraTerminators );

            var text8 = _macroString.Slice( offset, length );
            if( ( _parseOptions.CharEnumerationFlags & UtfEnumeratorFlags.UtfMask ) is not UtfEnumeratorFlags.Utf8 and not UtfEnumeratorFlags.Utf8SeString )
            {
                var text8Length = 0;
                foreach( var e in new UtfEnumerator( text8, _parseOptions.CharEnumerationFlags ) )
                    text8Length += e.EffectiveRune.Utf8SequenceLength;

                var tmp = text8Length < 1024 ? stackalloc byte[text8Length] : new byte[text8Length];
                var tmpOffset = 0;
                foreach( var e in new UtfEnumerator( text8, _parseOptions.CharEnumerationFlags ) )
                    tmpOffset += e.EffectiveRune.EncodeToUtf8( tmp[ tmpOffset.. ] );

                TransformStringAndEndExpression( tmp );
            }
            else
            {
                TransformStringAndEndExpression( text8 );
            }

            return length;
        }
        catch( Exception e1 )
        {
            if( abortExpression )
            {
                try
                {
                    _builder.AbortExpression();
                }
                catch( Exception e2 )
                {
                    throw new AggregateException( e1, e2 );
                }
            }

            throw;
        }
    }

    private void TransformStringAndEndExpression( ReadOnlySpan< byte > text8 )
    {
        if( text8.StartsWith( "lnum"u8 ) && TryParseInt( text8[ 4.. ], out var parsedInt ) )
            _builder.AbortExpression().AppendLocalNumberExpression( parsedInt );
        else if( text8.StartsWith( "lstr"u8 ) && TryParseInt( text8[ 4.. ], out parsedInt ) )
            _builder.AbortExpression().AppendLocalStringExpression( parsedInt );
        else if( text8.StartsWith( "gnum"u8 ) && TryParseInt( text8[ 4.. ], out parsedInt ) )
            _builder.AbortExpression().AppendGlobalNumberExpression( parsedInt );
        else if( text8.StartsWith( "gstr"u8 ) && TryParseInt( text8[ 4.. ], out parsedInt ) )
            _builder.AbortExpression().AppendGlobalStringExpression( parsedInt );
        else if( text8.SequenceEqual( "t_msec"u8 ) )
            _builder.AbortExpression().AppendNullaryExpression( ExpressionType.Millisecond );
        else if( text8.SequenceEqual( "t_sec"u8 ) )
            _builder.AbortExpression().AppendNullaryExpression( ExpressionType.Second );
        else if( text8.SequenceEqual( "t_min"u8 ) )
            _builder.AbortExpression().AppendNullaryExpression( ExpressionType.Minute );
        else if( text8.SequenceEqual( "t_hour"u8 ) )
            _builder.AbortExpression().AppendNullaryExpression( ExpressionType.Hour );
        else if( text8.SequenceEqual( "t_day"u8 ) )
            _builder.AbortExpression().AppendNullaryExpression( ExpressionType.Day );
        else if( text8.SequenceEqual( "t_wday"u8 ) )
            _builder.AbortExpression().AppendNullaryExpression( ExpressionType.Weekday );
        else if( text8.SequenceEqual( "t_mon"u8 ) )
            _builder.AbortExpression().AppendNullaryExpression( ExpressionType.Month );
        else if( text8.SequenceEqual( "t_year"u8 ) )
            _builder.AbortExpression().AppendNullaryExpression( ExpressionType.Year );
        else if( text8.SequenceEqual( "stackcolor"u8 ) )
            _builder.AbortExpression().AppendNullaryExpression( ExpressionType.StackColor );
        else if( TryParseInt( text8, out parsedInt ) )
            _builder.AbortExpression().AppendIntExpression( parsedInt );
        else
            _builder.EndExpression();

        return;

        static bool TryParseInt( ReadOnlySpan< byte > data, out int result )
        {
            result = 0;
            if( data.IsEmpty )
                return false;

            var sign = 1;
            do
            {
                if( data[ 0 ] == '-' )
                    sign *= -1;
                else if( data[ 0 ] == '+' )
                    sign *= 1;
                else if( data[ 0 ] >= '0' && data[ 0 ] <= '9' )
                    break;
                else
                    return false;
                data = data[ 1.. ];
            } while( !data.IsEmpty );

            var maxPerDigit = 10u;
            if( data.Length > 2 && data[ 0 ] == '0' )
            {
                maxPerDigit = (char) data[ 1 ] switch
                {
                    'x' or 'X' => 16u,
                    'o' or 'O' => 8u,
                    'b' or 'B' => 2u,
                    'd' or 'D' => 10u,
                    _ => 0u
                };
                if( maxPerDigit == 0u )
                    return false;
                data = data[ 2.. ];
            }

            if( data.IsEmpty )
                return false;

            var num = 0u;
            foreach( var d in data )
            {
                var digit = d >= Digits.Length ? -1 : Digits[ d ];
                if( digit == -1 || digit >= maxPerDigit )
                    return false;
                if( digit == -2 )
                    continue;
                num = unchecked( num * maxPerDigit + (uint) digit );
            }

            result = unchecked( sign * (int) num );
            return true;
        }
    }

    private bool TryConsumeStart( ref int offset, ReadOnlySpan< byte > expected )
    {
        var en1 = new UtfEnumerator( _macroString[ offset.. ], _parseOptions.CharEnumerationFlags );
        var en2 = new UtfEnumerator( expected, UtfEnumeratorFlags.Utf8 );
        if( !en1.MoveNext() || !en2.MoveNext() )
            return false;

        int off1, off2;
        do
        {
            if( en1.Current.Value != en2.Current.Value )
                return false;
            off1 = en1.Current.ByteOffset + en1.Current.ByteLength;
            off2 = en2.Current.ByteOffset + en2.Current.ByteLength;
        } while( en1.MoveNext() && en2.MoveNext() );

        if( off2 != expected.Length )
            return false;

        offset += off1;
        return true;
    }

    private void ConsumeStart( ref int offset, ReadOnlySpan< byte > expected, string? expectedRepresentationForException = null )
    {
        if( TryConsumeStart( ref offset, expected ) )
            return;

        expectedRepresentationForException ??= $"\"{Encoding.UTF8.GetString( expected )}\"";
        throw new MacroStringParseException( $"Expected {expectedRepresentationForException}", offset );
    }

    private MacroCode ParseMacroCode( ref int offset )
    {
        Span< char > macroCodeName = stackalloc char[64];
        var macroCodeNameLength = 0;

        var numConsumedBytes = _macroString.Length - offset;
        var nextIsEscaped = false;
        foreach( var c in new UtfEnumerator( _macroString[ offset.. ], _parseOptions.CharEnumerationFlags ) )
        {
            var stop = false;
            switch( c.Value.IntValue )
            {
                case var _ when nextIsEscaped:
                    nextIsEscaped = false;
                    goto default;
                case '\\':
                    nextIsEscaped = true;
                    break;
                case var _ when CharRequiresEscapeInSeString( c.Value ) || Rune.IsWhiteSpace( c.EffectiveRune ):
                    numConsumedBytes = c.ByteOffset;
                    stop = true;
                    break;
                default:
                    macroCodeNameLength += c.EffectiveRune.TryEncodeToUtf16( macroCodeName[ macroCodeNameLength.. ], out var written )
                        ? written
                        : throw new MacroStringParseException( $"Unsupported {nameof( MacroCode )}: \"{macroCodeName[ ..macroCodeNameLength ]}...\"", offset );
                    break;
            }

            if( stop )
                break;
        }

        macroCodeName = macroCodeName[ ..macroCodeNameLength ];

        foreach( var n in MacroCodeExtensions.GetDefinedMacroCodes())
        {
            if( macroCodeName.SequenceEqual( n.GetEncodeName() ) )
            {
                offset += numConsumedBytes;
                return n;
            }
        }

        throw new MacroStringParseException( $"Unsupported {nameof( MacroCode )}: \"{macroCodeName}\"", offset );
    }

    private void SkipWhitespaces( ref int offset )
    {
        foreach( var c in new UtfEnumerator( _macroString[ offset.. ], _parseOptions.CharEnumerationFlags ) )
        {
            if( c.Value.TryGetRune( out var rune ) && Rune.IsWhiteSpace( rune ) )
                continue;

            offset += c.ByteOffset;
            return;
        }

        offset = _macroString.Length;
    }

    private static bool CharRequiresEscapeInSeString( uint c ) =>
        c is '\\' or ',' or '<' or '>' or '(' or ')' or '[' or ']';
}