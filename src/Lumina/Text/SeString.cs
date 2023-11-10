using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text;
using Lumina.Data;
using Lumina.Extensions;
using Lumina.Text.Payloads;

namespace Lumina.Text
{
    /// <summary>
    /// Represent a SeString.
    /// </summary>
    public class SeString
    {
        /// <summary>
        /// Mark the beginning of a payload wrapper inside SeString. 
        /// </summary>
        public const byte StartByte = 0x02;

        /// <summary>
        /// Mark the end of a payload wrapper inside SeString. 
        /// </summary>
        public const byte EndByte = 0x03;

        private readonly Lazy<byte[]> _rawData;
        private readonly Lazy<string> _rawString;
        private readonly Lazy<ImmutableList< BasePayload >> _payloads;

        /// <summary>
        /// Construct an empty SeString.
        /// </summary>
        public SeString()
        {
            _rawData = new Lazy< byte[] >( Array.Empty< byte >() );
            _payloads = new Lazy< ImmutableList< BasePayload > >( ImmutableList< BasePayload >.Empty );
            _rawString = new Lazy< string >( string.Empty );
        }

        /// <summary>
        /// Construct a SeString from the given byte array.
        /// </summary>
        /// <param name="data"></param>
        public SeString( byte[] data )
        {
            _rawData = new Lazy< byte[] >( data );
            _payloads = new Lazy< ImmutableList< BasePayload > >( BuildPayloads );
            _rawString = new Lazy< string >( () => string.Concat( Payloads.Select( x => x.RawString ) ) );
        }

        /// <summary>
        /// Construct a SeString from the given string. No payload can be embedded using this constructor.
        /// </summary>
        public SeString( string data )
        {
            if( data.IndexOf( (char)StartByte ) != -1 )
                throw new ArgumentException( "A string cannot embed a STX as a part of the text." );

            // Is the below check necessary?
            // if( data.IndexOf( (char)EndByte ) != -1 )
            //     throw new ArgumentException( "A string cannot embed a ETX as a part of the text." );

            _payloads = new Lazy< ImmutableList< BasePayload > >( ImmutableList< BasePayload >.Empty );
            _rawString = new Lazy< string >( data );
            _rawData = new Lazy< byte[] >( Encoding.UTF8.GetBytes( _rawString.Value ) );
        }

        /// <summary>
        /// Construct a SeString from the given payloads and objects.
        /// 
        /// Anything not inherited from BasePayload will be represented as strings, using ToString.
        /// </summary>
        public SeString( IEnumerable< object? > payloads )
        {
            _payloads = new Lazy< ImmutableList< BasePayload > >( payloads.Select( x => x as BasePayload ?? new TextPayload(Encoding.UTF8.GetBytes(x?.ToString() ?? "(null)")) ).ToImmutableList() );
            _rawString = new Lazy< string >( () => string.Concat( Payloads.Select( x => x.RawString ) ) );
            _rawData = new Lazy< byte[] >( () =>
            {
                var buf = new byte[Payloads.Sum( payload => payload.Data.Length )];
                var ptr = 0;
                foreach( var payload in Payloads )
                {
                    var targetSpan = new Span< byte >( buf, ptr, payload.Data.Length );
                    payload.Data.CopyTo( targetSpan );
                    ptr += targetSpan.Length;
                }

                return buf;
            } );
        }

        /// <summary>
        /// Construct a SeString from the given payloads.
        /// </summary>
        public SeString( List< BasePayload > payloads ) : this( (IEnumerable< object? >)payloads )
        {
        }

        /// <summary>
        /// Construct a SeString from the given payloads and objects.
        /// 
        /// Anything not inherited from BasePayload will be represented as strings, using ToString.
        /// </summary>
        public SeString( params object[] payloads ) : this( (IEnumerable< object? >)payloads )
        {
        }

        /// <summary>
        /// Gets the view of byte array representation of this SeString.
        /// </summary>
        public ReadOnlySpan< byte > RawData => _rawData.Value.AsSpan();
        
        /// <summary>
        /// Extracts and concatenates the text payloads and integer constants.
        /// </summary>
        public string RawString => _rawString.Value;
        
        /// <summary>
        /// Gets the read only list of the payloads contained.
        /// </summary>
        public IReadOnlyList< BasePayload > Payloads => _payloads.Value;

        private ImmutableList< BasePayload > BuildPayloads()
        {
            var payloads = new List< BasePayload >();

            using var stream = new MemoryStream( _rawData.Value );
            while( stream.Position < _rawData.Value.Length )
                payloads.Add( new BasePayload( stream ).ToTypedPayload() );

            return payloads.ToImmutableList();
        }

        public static implicit operator string( SeString str ) => str.RawString;

        // public static SeString operator +( SeString lhs, SeString rhs )
        // {
        //     return null;
        // }
        //
        // public static bool operator ==( SeString lhs, SeString rhs )
        // {
        //     return false;
        // }
        //
        // public static bool operator !=( SeString lhs, SeString rhs )
        // {
        //     return !( lhs == rhs );
        // }

        // protected bool Equals( SeString other )
        // {
        //     throw new NotImplementedException();
        // }
        //
        // public override bool Equals( object obj )
        // {
        //     if( ReferenceEquals( null, obj ) ) return false;
        //     if( ReferenceEquals( this, obj ) ) return true;
        //     if( obj.GetType() != this.GetType() ) return false;
        //     return Equals( (SeString)obj );
        // }
        //
        // public override int GetHashCode()
        // {
        //     throw new NotImplementedException();
        // }

        public override string ToString()
        {
            return string.Concat( Payloads );
        }
    }
}