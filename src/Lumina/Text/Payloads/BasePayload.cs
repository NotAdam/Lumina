using Lumina.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lumina.Text.Payloads
{
    public class BasePayload
    {
        public BasePayload()
        {
            
        }
        
        public BasePayload( byte[] data )
        {
            _data = data;
            _rawString = Encoding.UTF8.GetString( data );
        }

        public BasePayload( LuminaBinaryReader br )
        {
            var data = GetPayloadData( br );

            if( data.Any() )
            {
                _data = data;
                _rawString = Encoding.UTF8.GetString( data );
            }
        }

        public byte[] GetPayloadData( LuminaBinaryReader br )
        {
            var data = new List< byte >();
            
            while( br.BaseStream.Position < br.BaseStream.Length )
            {
                var d = br.ReadByte();
                data.Add( d );
                if( d == SeString.EndByte )
                {
                    // data.Add( d );
                    // br.BaseStream.Position++;
                    break;
                }
            }

            return data.ToArray();
        }
        
        #if DEBUG
        public string PayloadType => GetType().FullName;
        #endif
        
        protected byte[] _data;
        protected string _rawString;

        public ReadOnlySpan< byte > Data => _data.AsSpan();
        public string RawString => _rawString;

    }
}