using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Lumina.Text.Expressions;
using Lumina.Text.Payloads;
using Lumina.Text.ReadOnly;

namespace Lumina.Text.Parse;

internal readonly ref struct MacroStringParser
{
    /// <summary>Map from ascii code to supposed number. See the static constructor for initialization.</summary>
    /// <value><ul>
    /// <li>-1: invalid</li>
    /// <li>-2: ignore</li>
    /// </ul></value>
    private static readonly sbyte[] Digits;

    private readonly ReadOnlySpan< byte > _macroString;
    private readonly MacroStringParseOptions _parseOptions;
    private readonly SeStringBuilder _builder;

    static MacroStringParser()
    {
        Digits = new sbyte[0x80];
        Digits.AsSpan().Fill( -1 );
        // Programming languages such as C# will ignore underscores(_) between digits, to let users write 0x0123_4567_89AB_CDEF for ease of reading.
        // C++ will use single quotes(') instead of underscores.
        Digits[ '_' ] = Digits[ '\'' ] = -2;
        for( var i = '0'; i <= '9'; i++ )
            Digits[ i ] = (sbyte) ( i - '0' );
        for( var i = 'A'; i <= 'F'; i++ )
            Digits[ i ] = (sbyte) ( 10 + ( i - 'A' ) );
        for( var i = 'a'; i <= 'f'; i++ )
            Digits[ i ] = (sbyte) ( 10 + ( i - 'a' ) );
    }

    internal MacroStringParser( ReadOnlySpan< byte > macroString, SeStringBuilder builder, MacroStringParseOptions parseOptions )
    {
        _macroString = macroString;
        _builder = builder;
        _parseOptions = parseOptions;
    }

    /// <summary>Parses the macro string.</summary>
    /// <param name="offset">Offset in <see cref="_macroString"/> to parse from.</param>
    /// <param name="stopOnCharRequiringEscape">Whether to stop parsing if a character requires escaping to have itself skipped from being processed as a part
    /// of string representation of SeString payloads. Used to allow using special characters used to form string representation of SeString payloads, such as
    /// <c>(</c> or <c>,</c>, when the string being parsed is at the topmost level (not a part of string SeString expression.)</param>
    /// <param name="extraTerminators">If any of the bytes in this span is encountered while parsing, it will be treated as the end of the current string being
    /// parsed. Used to terminate parsing string SeString expressions, so that it can exclude <c>)</c> from the expression and stop when parsing
    /// <c>&lt;string(asdf)&gt;</c>, instead of producing <c>asdf)</c> as the parsed string SeString expression and fail with invalid syntax.</param>
    /// <returns>One past the final offset in <see cref="_macroString"/> that got parsed.</returns>
    public int ParseMacroStringAndAppend( int offset, bool stopOnCharRequiringEscape, ReadOnlySpan< byte > extraTerminators )
    {
        var beginOffset = offset;
        while( new UtfEnumerator( _macroString[ offset.. ], _parseOptions.CharEnumerationFlags ).TryPeekNext( out var c, out _ ) )
        {
            Debug.Assert(
                ( _parseOptions.CharEnumerationFlags & UtfEnumeratorFlags.IgnoreErrors ) != 0 || c.ByteOffset == 0,
                $"Offset of the first item retrieved UtfEnumerator should have been 0, unless {nameof( UtfEnumeratorFlags.IgnoreErrors )} is set." );

            offset += c.ByteOffset;

            if( c.IsSeStringPayload )
            {
                Debug.Assert( ( _parseOptions.CharEnumerationFlags & UtfEnumeratorFlags.Utf8SeString ) != 0,
                    $"SeString Payload should have not been yielded unless {nameof( UtfEnumeratorFlags.Utf8SeString )} is set." );

                _builder.Append( new ReadOnlySeStringSpan( _macroString.Slice( offset, c.ByteLength ) ) );
                offset += c.ByteLength;
                continue;
            }

            switch( c.Value.UIntValue )
            {
                case '\\':
                    // Backslashes will *always* produce the following character as-is.
                    // No special escape sequences such as \n and \t are defined for SeStrings.
                    offset += ParseMacroStringTextAndAppend( offset, extraTerminators );
                    break;

                case <= byte.MaxValue when extraTerminators.Contains( (byte) c.Value.UIntValue ):
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
                        var byteLength = Math.Max( c.ByteLength, e.ByteOffset - offset );
                        var sliceUntilError = _macroString.Slice( offset, byteLength );
                        _builder.Append( new UtfEnumerator( sliceUntilError, _parseOptions.CharEnumerationFlags ) );
                        if( _parseOptions.ExceptionMode == MacroStringParseExceptionMode.EmbedError )
                            _builder.Append( "<ERROR: " ).Append( e.Message ).Append( ">" );
                        offset += byteLength;
                    }

                    break;

                case <= byte.MaxValue when CharRequiresEscapeInSeString( c.Value.UIntValue ):
                    if( stopOnCharRequiringEscape )
                        return offset - beginOffset;

                    var v = unchecked( (byte) c.Value.UIntValue );
                    _builder.Append( MemoryMarshal.CreateReadOnlySpan( ref v, 1 ) );
                    offset += c.ByteLength;
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
            if( c.IsSeStringPayload )
                return c.ByteOffset;

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
                        throw new MacroStringParseException( "Unexpected EOF", offset, _macroString, _parseOptions );

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
                            $"Unsupported binary expression: {( op1 == -1 ? "" : "" + (char) op1 )}{( op2 == -1 ? "" : "" + (char) op2 )}",
                            offset,
                            _macroString,
                            _parseOptions );
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

            // If the number string begins with 0 followed by non-decimal digits, try parsing it as non-decimal.
            if( data.Length > 2
               && data[ 0 ] == '0'
               && data[ 1 ] is not ((byte) '_' or (byte) '\'')
               && data[ 1 ] is not (>= (byte) '0' and <= (byte) '9') )
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
        throw new MacroStringParseException( $"Expected {expectedRepresentationForException}", offset, _macroString, _parseOptions );
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
                        : throw new MacroStringParseException(
                            $"Unsupported {nameof( MacroCode )}: \"{macroCodeName[ ..macroCodeNameLength ]}...\"",
                            offset,
                            _macroString,
                            _parseOptions );
                    break;
            }

            if( stop )
                break;
        }

        macroCodeName = macroCodeName[ ..macroCodeNameLength ];

        foreach( var n in MacroCodeExtensions.GetDefinedMacroCodes() )
        {
            if( macroCodeName.SequenceEqual( n.GetEncodeName() ) )
            {
                offset += numConsumedBytes;
                return n;
            }
        }

        throw new MacroStringParseException( $"Unsupported {nameof( MacroCode )}: \"{macroCodeName}\"", offset, _macroString, _parseOptions );
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