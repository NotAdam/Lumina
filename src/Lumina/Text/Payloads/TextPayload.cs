using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lumina.Data;
using Lumina.Extensions;

namespace Lumina.Text.Payloads
{
    public class TextPayload : BasePayload
    {
        public TextPayload( LuminaBinaryReader br )
        {
            var data = new List< byte >();
            
            while( br.BaseStream.Position < br.BaseStream.Length )
            {
                var d = br.PeekByte();
                if( d != SeString.StartByte )
                {
                    data.Add( d );
                    br.BaseStream.Position++;
                }
                else
                {
                    break;
                }
            }

            if( !data.Any() )
            {
                return;
            }
            
            var arr = data.ToArray();
            
            _rawString = Encoding.UTF8.GetString( arr );
            _data = arr;
        }
    }
}