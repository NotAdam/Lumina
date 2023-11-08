using Lumina.Data;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text;
using Lumina.Text.Expressions;

namespace Lumina.Text.Payloads
{
    /// <summary>
    /// Represent a payload that is either a complicated payload or a simple text payload.
    /// </summary>
    public class BasePayload
    {
        private readonly IntegerExpression _expressionTotalSize;
        private readonly Lazy< ImmutableList< BaseExpression > > _expressions;
        private readonly byte[] _data;
        private readonly Lazy< string > _rawString;

        /// <summary>
        /// Gets the type marker of this payload.
        /// </summary>
        public readonly PayloadType PayloadType;

        /// <summary>
        /// Construct an empty text payload.
        /// </summary>
        public BasePayload()
        {
            _expressionTotalSize = new IntegerExpression( 0 );
            _expressions = new Lazy< ImmutableList< BaseExpression > >( ImmutableList< BaseExpression >.Empty );
            _data = Array.Empty< byte >();
            _rawString = new Lazy< string >( string.Empty );
            PayloadType = PayloadType.Text;
        }

        /// <summary>
        /// Construct a payload, copying data from the given parameter.
        /// </summary>
        public BasePayload( BasePayload from )
        {
            _expressionTotalSize = from._expressionTotalSize;
            _expressions = from._expressions;
            _data = from._data;
            _rawString = from._rawString;
            PayloadType = from.PayloadType;
        }

        /// <summary>
        /// Construct a payload from given type and component expressions.
        /// </summary>
        public BasePayload( PayloadType payloadType, IEnumerable< BaseExpression > expressions )
        {
            if( payloadType == PayloadType.Text )
                throw new ArgumentException( "Text payload cannot be constructed with this constructor.", nameof( payloadType ) );
            
            _expressions = new Lazy< ImmutableList< BaseExpression > >( expressions.ToImmutableList() );
            _expressionTotalSize = new IntegerExpression( (uint)_expressions.Value.Select( x => x.Size ).Sum() );
            
            _data = new byte[1 + 1 + _expressionTotalSize.Size + _expressionTotalSize.Value + 1];
            PayloadType = payloadType;
            
            var dataStream = new MemoryStream( _data, true );
            dataStream.WriteByte( SeString.StartByte );
            dataStream.WriteByte( (byte)PayloadType );
            _expressionTotalSize.Encode( dataStream );
            foreach( var expr in _expressions.Value )
                expr.Encode( dataStream );
            dataStream.WriteByte( SeString.EndByte );

            if( PayloadType == PayloadType.NewLine )
            {
                _rawString = new Lazy< string >( "\n" );
            }
            else
            {
                _rawString = new Lazy< string >( () => string.Join( "",
                    _expressions.Value.Select( x => x is StringExpression sx ? sx.Value.RawString : "" )
                ) );
            }
        }

        /// <summary>
        /// Construct a payload from the given byte array.
        /// </summary>
        public BasePayload( byte[] data ) : this( new MemoryStream( data ) )
        {
        }

        /// <summary>
        /// Construct a payload from the given BinaryReader.
        /// </summary>
        public BasePayload( BinaryReader br ) : this( br.BaseStream )
        {
        }

        /// <summary>
        /// Construct a payload from the given stream.
        /// </summary>
        public BasePayload( Stream stream )
        {
            if( !stream.CanSeek )
                throw new ArgumentException( "Underlying stream must be seekable", nameof( stream ) );

            var firstByte = checked( (byte)stream.ReadByte() );
            if( firstByte != SeString.StartByte )
            {
                // This is a simple text payload.

                _expressionTotalSize = new IntegerExpression( 0 );
                _expressions = new Lazy< ImmutableList< BaseExpression > >( ImmutableList< BaseExpression >.Empty );

                var outStream = new MemoryStream();
                var buffer = ArrayPool< byte >.Shared.Rent( 4096 );

                outStream.WriteByte( firstByte );

                while( true )
                {
                    var read = stream.Read( buffer );
                    var valid = read;

                    var nullChar = Array.IndexOf( buffer, (byte)0, 0, valid );
                    if( nullChar != -1 )
                        valid = nullChar;

                    var endByte = Array.IndexOf( buffer, SeString.StartByte, 0, valid );
                    if( endByte != -1 )
                        valid = endByte;

                    outStream.Write( buffer, 0, valid );

                    if( valid != buffer.Length )
                    {
                        stream.Position += valid - read;
                        break;
                    }
                }

                ArrayPool< byte >.Shared.Return( buffer );

                _data = outStream.ToArray();
                _rawString = new Lazy< string >( () => Encoding.UTF8.GetString( _data ) );
            }
            else
            {
                // This is a complicated payload.

                PayloadType = (PayloadType)checked( (byte)stream.ReadByte() );
                if( PayloadType == 0 )
                    throw new ArgumentException( "Encountered premature end of input (unexpected null character).", nameof( stream ) );

                _expressionTotalSize = IntegerExpression.Parse( checked( (byte)stream.ReadByte() ), stream );

                _data = new byte[1 + 1 + _expressionTotalSize.Size + _expressionTotalSize.Value + 1];
                _data[ 0 ] = SeString.StartByte;
                _data[ 1 ] = (byte)PayloadType;
                _expressionTotalSize.Encode( new MemoryStream( _data, 2, _expressionTotalSize.Size, true ) );

                if( stream.Read( _data, 2 + _expressionTotalSize.Size, (int)_expressionTotalSize.Value ) != _expressionTotalSize.Value )
                    throw new ArgumentException( "Encountered premature end of input (unexpected EOF).", nameof( stream ) );

                _data[ ^1 ] = checked( (byte)stream.ReadByte() );

                if( _data.Any( x => x == 0 ) )
                    throw new ArgumentException( "Encountered premature end of input (unexpected null character).", nameof( stream ) );

                if( _data[ ^1 ] != SeString.EndByte )
                    throw new ArgumentException( "The expression has terminated without an end marker.", nameof( stream ) );

                _expressions = new Lazy< ImmutableList< BaseExpression > >( () =>
                {
                    var exprs = new List< BaseExpression >();
                    var ms = new MemoryStream( _data, 2 + _expressionTotalSize.Size, (int)_expressionTotalSize.Value );
                    while( ms.Position < ms.Length )
                        exprs.Add( BaseExpression.Parse( ms ) );

                    return exprs.ToImmutableList();
                } );

                if( PayloadType == PayloadType.NewLine )
                {
                    _rawString = new Lazy< string >( "\n" );
                }
                else
                {
                    _rawString = new Lazy< string >( () => string.Join( "",
                        _expressions.Value.Select( x => x switch
                        {
                            StringExpression sx => sx.Value.RawString,
                            // IntegerExpression ix => ix.Value.ToString(),
                            _ => ""
                        } )
                    ) );
                }
            }
        }

        /// <summary>
        /// Create a shallow copy of this payload, as the typed specified from payload type member. 
        /// </summary>
        /// <returns></returns>
        public BasePayload ToTypedPayload()
        {
            switch( PayloadType )
            {
                case PayloadType.Text:
                    return this is TextPayload ? this : new TextPayload( this );
                case PayloadType.NewLine:
                    return this is NewlinePayload ? this : new NewlinePayload( this );
                default:
                    return this;
            }
        }

        public T ToTypedPayload< T >() where T : BasePayload => (T)ToTypedPayload();

        [Obsolete( $"Use {nameof( BasePayload )} itself instead." )]
        public byte[] GetPayloadData( LuminaBinaryReader br ) => new BasePayload( br )._data;

        /// <summary>
        /// Gets whether this payload is a text payload.
        /// </summary>
        public bool IsTextPayload => PayloadType == PayloadType.Text;

        /// <summary>
        /// Gets the list of component expressions.
        /// </summary>
        public IReadOnlyList< BaseExpression > Expressions => _expressions.Value;

        /// <summary>
        /// Gets the raw bytes of this payload including its wrapper.
        /// </summary>
        public ReadOnlySpan< byte > Data => _data.AsSpan();

        /// <summary>
        /// Extracts and concatenates the text payloads and integer constants.
        /// </summary>
        public string RawString => _rawString.Value;

        /// <inheritdoc />
        public override string ToString()
        {
            if( PayloadType == PayloadType.Text )
                return RawString;

            var code = (MacroCodes)PayloadType;
            switch( code )
            {
                case MacroCodes.NewLine:
                    return "<br>";
                case MacroCodes.NonBreakingSpace:
                    return "<nbsp>";
                case MacroCodes.SoftHyphen:
                    return "-";
                case MacroCodes.Hyphen:
                    return "--";
                default:
                {
                    if( Expressions.Count == 0 )
                        return $"<{code.ToString().ToLower()}>";

                    return $"<{code.ToString().ToLower()}({string.Join( ',', Expressions )})>";
                }
            }
        }
    }
}