using System;
using System.Diagnostics;

namespace Lumina.Data.Parsing.Tex.SquishInternal.Bc7;

internal enum Bc7RotationMode : byte
{
    NoChange = 0,
    SwapAlphaRed = 1,
    SwapAlphaGreen = 2,
    SwapAlphaBlue = 3,
}

internal unsafe ref struct Bc7ParsedBlock
{
    public const int MaxNumEndpoints = 6;
    public readonly Span< Vector4< byte > > EndpointsFull;
    public Span< Vector4< byte > > Endpoints;

    public Bc7Mode Mode;
#pragma warning disable CS0649
    public byte PartitionIndex;
    public Bc7RotationMode Rotation;
    public byte IndexMode;
    public fixed byte PBit[6];
    public ulong Index1;
    public ulong Index2;
#pragma warning restore CS0649

    public Bc7ParsedBlock( Span< Vector4< byte > > endpoints )
    {
        Debug.Assert( endpoints.Length >= MaxNumEndpoints );
        EndpointsFull = Endpoints = endpoints;
    }

    public bool ReadBlock( ReadOnlySpan< byte > block )
    {
        var bsr = new ByteSpanBitReader( block );

        Mode = Bc7Mode.GetFromFirstByte( block[ 0 ] );
        if( Mode.Subsets == 0 )
            return false;
        bsr.Offset = Mode.Mode + 1;

        var pbits = Mode.SharedPBits + Mode.EndpointPBits;
        var colorBitsWithPBit = Mode.ColorBits + pbits;
        var alphaBitsWithPBit = Mode.AlphaBits + pbits;

        PartitionIndex = bsr.ReadAsByte( Mode.PartitionBits );
        Rotation = (Bc7RotationMode) bsr.ReadAsByte( Mode.RotationBits );
        IndexMode = bsr.ReadAsByte( Mode.IndexSelectionBits );

        Endpoints = EndpointsFull[ ..( Mode.Subsets * 2 ) ];
        for( var i = 0; i < Endpoints.Length; i++ )
            Endpoints[ i ].X = bsr.ReadAsByte( Mode.ColorBits );
        for( var i = 0; i < Endpoints.Length; i++ )
            Endpoints[ i ].Y = bsr.ReadAsByte( Mode.ColorBits );
        for( var i = 0; i < Endpoints.Length; i++ )
            Endpoints[ i ].Z = bsr.ReadAsByte( Mode.ColorBits );
        for( var i = 0; i < Endpoints.Length; i++ )
            Endpoints[ i ].W = bsr.ReadAsByte( Mode.AlphaBits );

        if( Mode.SharedPBits > 0 )
            for( var i = 0; i < Endpoints.Length; i += 2 )
                PBit[ i ] = PBit[ i + 1 ] = bsr.ReadAsByte( 1 );
        else if( Mode.EndpointPBits > 0 )
            for( var i = 0; i < Endpoints.Length; i++ )
                PBit[ i ] = bsr.ReadAsByte( 1 );
        else
            for( var i = 0; i < Endpoints.Length; i++ )
                PBit[ i ] = 0;

        for( var i = 0; i < Endpoints.Length; i++ )
        {
            var (x, y, z, w) = Endpoints[ i ];

            x = (byte) ( ( x << pbits ) | PBit[ i ] );
            y = (byte) ( ( y << pbits ) | PBit[ i ] );
            z = (byte) ( ( z << pbits ) | PBit[ i ] );
            w = (byte) ( ( w << pbits ) | PBit[ i ] );

            // left shift endpoint components so that their MSB lies in bit 7
            x <<= 8 - colorBitsWithPBit;
            y <<= 8 - colorBitsWithPBit;
            z <<= 8 - colorBitsWithPBit;
            w <<= 8 - alphaBitsWithPBit;

            // Replicate each component's MSB into the LSBs revealed by the left-shift operation above
            x |= (byte) ( x >> colorBitsWithPBit );
            y |= (byte) ( y >> colorBitsWithPBit );
            z |= (byte) ( z >> colorBitsWithPBit );
            w |= (byte) ( w >> alphaBitsWithPBit );

            Endpoints[ i ] = new( x, y, z, w );
        }

        if( Mode.AlphaBits == 0 )
        {
            for( var i = 0; i < Endpoints.Length; i++ )
                Endpoints[ i ].W = 255;
        }

        Index1 = bsr.ReadAsULong( Mode.IndexBitsTotal );
        Index2 = bsr.ReadAsULong( Mode.IndexBits2Total );

        Debug.Assert( bsr.Offset == 128 );
        return true;
    }

    public void WriteBlock( Span< byte > block )
    {
        Debug.Assert( Endpoints.Length == Mode.Subsets * 2 );
        Debug.Assert( Mode.Mode < 8 );

        var pbits = Mode.SharedPBits + Mode.EndpointPBits;

        var bsw = new ByteSpanBitWriter( block );
        bsw.Write( Mode.Mode + 1, (byte) ( 1 << Mode.Mode ) );
        bsw.Write( Mode.PartitionBits, PartitionIndex );
        bsw.Write( Mode.RotationBits, (byte) Rotation );
        bsw.Write( Mode.IndexSelectionBits, IndexMode );
        for( var i = 0; i < Endpoints.Length; i++ )
            bsw.Write( Mode.ColorBits, Endpoints[ i ].X >> pbits );
        for( var i = 0; i < Endpoints.Length; i++ )
            bsw.Write( Mode.ColorBits, Endpoints[ i ].Y >> pbits );
        for( var i = 0; i < Endpoints.Length; i++ )
            bsw.Write( Mode.ColorBits, Endpoints[ i ].Z >> pbits );
        for( var i = 0; i < Endpoints.Length; i++ )
            bsw.Write( Mode.AlphaBits, Endpoints[ i ].W >> pbits );

        if( Mode.SharedPBits > 0 )
            for( var i = 0; i < Mode.Subsets; i += 2 )
                bsw.Write( 1, PBit[ i ] );
        if( Mode.EndpointPBits > 0 )
            for( var i = 0; i < Mode.Subsets; i++ )
                bsw.Write( 1, PBit[ i ] );

        bsw.Write( Mode.IndexBitsTotal, Index1 );
        bsw.Write( Mode.IndexBits2Total, Index2 );

        Debug.Assert( bsw.Offset == 128 );
    }

    public int ColorIndexBitCount => Mode.Mode switch
    {
        0 => 3,
        1 => 3,
        2 => 2,
        3 => 2,
        4 when IndexMode == 0 => 2,
        4 when IndexMode == 1 => 3,
        5 => 2,
        6 => 4,
        7 => 2,
        _ => 0
    };

    public int AlphaIndexBitCount => Mode.Mode switch
    {
        4 when IndexMode == 0 => 3,
        4 when IndexMode == 1 => 2,
        5 => 2,
        6 => 4,
        7 => 2,
        _ => 0
    };

    public int GetPartitionIndex( int itemIndex ) =>
        Bc7Constants.PartitionTables[ Mode.Subsets ][ PartitionIndex ][ itemIndex ];

    public int GetIndexOffset( int bitCount, int index )
    {
        switch( Mode.Subsets )
        {
            case var _ when index is 0:
                return 0;
            case 1:
                return bitCount * index - 1;
            case 2:
            {
                var anchorIndex = Bc7Constants.Subsets2AnchorIndices2[ PartitionIndex ];
                if( index <= anchorIndex )
                    return bitCount * index - 1;
                return bitCount * index - 2;
            }
            case 3:
            {
                var anchor2Index = Bc7Constants.Subsets3AnchorIndices2[ PartitionIndex ];
                var anchor3Index = Bc7Constants.Subsets3AnchorIndices3[ PartitionIndex ];

                if( index <= anchor2Index && index <= anchor3Index )
                    return bitCount * index - 1;
                if( index > anchor2Index && index > anchor3Index )
                    return bitCount * index - 3;
                return bitCount * index - 2;
            }
            default:
                return 0;
        }
    }

    /// <summary>
    /// Decrements bitCount by one if index is one of the anchor indices.
    /// </summary>
    public int GetIndexBitCount( int bitCount, int index )
    {
        if( index == 0 )
            return bitCount - 1;

        switch( Mode.Subsets )
        {
            case 2:
                var anchorIndex = Bc7Constants.Subsets2AnchorIndices2[ PartitionIndex ];
                if( index == anchorIndex )
                    return bitCount - 1;
                break;
            case 3:
                var anchor2Index = Bc7Constants.Subsets3AnchorIndices2[ PartitionIndex ];
                var anchor3Index = Bc7Constants.Subsets3AnchorIndices3[ PartitionIndex ];
                if( index == anchor2Index || index == anchor3Index )
                    return bitCount - 1;
                break;
        }

        return bitCount;
    }

    public int GetAlphaIndex( int bitCount, int index )
    {
        if( bitCount == 0 )
            return 0;
        var indexOffset = GetIndexOffset( bitCount, index );
        var indexBitCount = GetIndexBitCount( bitCount, index );
        var indexValue = Mode.Mode switch
        {
            4 => bitCount == 2 ? Index1 : Index2,
            5 => Index2,
            _ => Index1,
        };
        return (int) ( ( indexValue >> indexOffset ) & ( ( 1ul << indexBitCount ) - 1 ) );
    }

    public int GetColorIndex( int bitCount, int index )
    {
        if( bitCount == 0 )
            return 0;
        var indexOffset = GetIndexOffset( bitCount, index );
        var indexBitCount = GetIndexBitCount( bitCount, index );
        var indexValue = Mode.Mode switch
        {
            4 => bitCount == 2 ? Index1 : Index2,
            _ => Index1,
        };
        return (int) ( ( indexValue >> indexOffset ) & ( ( 1ul << indexBitCount ) - 1 ) );
    }
}