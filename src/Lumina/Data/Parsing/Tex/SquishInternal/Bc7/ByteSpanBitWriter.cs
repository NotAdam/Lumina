using System;

namespace Lumina.Data.Parsing.Tex.SquishInternal.Bc7;

internal ref struct ByteSpanBitWriter
{
    private readonly Span< byte > _data;

    public int Offset;

    public ByteSpanBitWriter( Span< byte > data )
    {
        _data = data;
        data.Clear();
    }

    public void Write( int nb, byte value )
    {
        while( nb > 0 )
        {
            var shift = Offset % 8;
            var avail = 8 - shift;
            if( avail == 8 )
                _data[ Offset / 8 ] = value;
            else
                _data[ Offset / 8 ] |= (byte) ( value << shift );
            nb -= avail;
            Offset += avail;
        }
    }

    public void Write( int nb, ulong value )
    {
        while( nb > 0 )
        {
            var shift = Offset % 8;
            var avail = 8 - shift;
            if( avail == 8 )
                _data[ Offset / 8 ] = (byte) value;
            else
                _data[ Offset / 8 ] |= (byte) ( value << shift );
            nb -= avail;
            Offset += avail;
        }
    }

    public void Write( int nb, long value ) => Write( nb, (ulong) value );
}