using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Lumina.Extensions;
using Lumina.Text.Payloads;

namespace Lumina.Text
{
    public class SeString
    {
        public const byte StartByte = 0x02;
        public const byte EndByte = 0x03;

        public SeString( byte[] data )
        {
            _rawData = data;
            _rawReadable = Encoding.UTF8.GetString( data );

            _payloads = BuildPayloads();
        }

        public SeString( string data )
        {
            _rawReadable = data;
            _rawData = Encoding.UTF8.GetBytes( data );

            _payloads = BuildPayloads();
        }

        public SeString( List< BasePayload > payloads )
        {
            _payloads = payloads;
        }

        private byte[] _rawData;
        private string _rawReadable;

        public ReadOnlySpan< byte > RawData => _rawData.AsSpan();

        public string RawString
        {
            get
            {
                if( _rawReadable == null )
                {
                    // build a readable string
                    _rawReadable = string.Concat( _payloads.Select( x => x.RawString ) );
                }

                return _rawReadable;
            }
        }

        private List< BasePayload > _payloads { get; set; }
        public IReadOnlyList< BasePayload > Payloads => _payloads;

        private List< BasePayload > BuildPayloads()
        {
            var payloads = new List< BasePayload >();

            using var ms = new MemoryStream( _rawData );
            using var br = new BinaryReader( ms );

            var start = ms.Position;

            while( ms.Position < _rawData.Length )
            {
                var marker = br.PeekByte();
                if( marker != StartByte )
                {
                    payloads.Add( new TextPayload( br ) );
                }
                else
                {
                    payloads.Add( new BasePayload( br ) );
                }
            }

            return payloads;
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
            return RawString;
        }
    }
}