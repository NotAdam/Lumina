using System;
using System.Text;

namespace Lumina.Text
{
    public class SeString
    {
        public SeString( byte[] data )
        {
            _rawData = data;
            _rawReadable = Encoding.UTF8.GetString( data );
        }

        private byte[] _rawData;

        private readonly string _rawReadable;

        public ReadOnlySpan< byte > RawData => _rawData.AsSpan();
        public string RawString => _rawReadable;

        public static implicit operator string( SeString str ) => str._rawReadable;

        public override string ToString()
        {
            return _rawReadable;
        }
    }
}