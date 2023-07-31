using System;

namespace Lumina.Data.Parsing.Tex.SquishInternal.Bc7;

internal ref struct ByteSpanBitReader
{
    private readonly ReadOnlySpan< byte > _data;

    public int Offset;

    public ByteSpanBitReader( ReadOnlySpan< byte > data ) => _data = data;

    public byte ReadAsByte( int nb )
    {
        var res = (byte) 0;
        var bpos = 0;
        while( nb > 0 )
        {
            var shift = Offset % 8;
            var avail = Math.Min( nb, 8 - shift );
            if( avail == 8 )
                res |= (byte) ( ( _data[ Offset / 8 ] >> shift ) << bpos );
            else
                res |= (byte) ( ( ( _data[ Offset / 8 ] >> shift ) & ( ( 1 << avail ) - 1 ) ) << bpos );
            nb -= avail;
            bpos += avail;
            Offset += avail;
        }

        return res;
    }

    public ulong ReadAsULong( int nb )
    {
        var res = 0ul;
        var bpos = 0;
        while( nb > 0 )
        {
            var shift = Offset % 8;
            var avail = Math.Min( nb, 8 - shift );
            if( avail == 8 )
                res |= ( (ulong) _data[ Offset / 8 ] >> shift ) << bpos;
            else
                res |= ( ( (ulong) _data[ Offset / 8 ] >> shift ) & ( ( (ulong) 1 << avail ) - 1 ) ) << bpos;
            nb -= avail;
            bpos += avail;
            Offset += avail;
        }

        return res;
    }
}