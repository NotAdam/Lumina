namespace Lumina.Data.Parsing.Tex.SquishInternal.Bc7;

internal readonly struct Bc7Mode
{
    // See:
    // https://registry.khronos.org/DataFormat/specs/1.3/dataformat.1.3.html#bptc_bc7
    // https://learn.microsoft.com/en-us/windows/win32/direct3d11/bc7-format-mode-reference
    public readonly byte Mode;
    public readonly byte Subsets;
    public readonly byte PartitionBits;
    public readonly byte RotationBits;
    public readonly byte IndexSelectionBits;
    public readonly byte ColorBits;
    public readonly byte AlphaBits;
    public readonly byte EndpointPBits;
    public readonly byte SharedPBits;
    public readonly byte IndexBits;
    public readonly byte IndexBits2;
    public readonly byte IndexBitsTotal;
    public readonly byte IndexBits2Total;

    public Bc7Mode(
        byte mode,
        byte subsets,
        byte partitionBits,
        byte rotationBits,
        byte indexSelectionBits,
        byte colorBits,
        byte alphaBits,
        byte endpointPBits,
        byte sharedPBits,
        byte indexBits,
        byte indexBits2,
        byte indexBitsTotal,
        byte indexBits2Total )
    {
        Mode = mode;
        Subsets = subsets;
        PartitionBits = partitionBits;
        RotationBits = rotationBits;
        IndexSelectionBits = indexSelectionBits;
        ColorBits = colorBits;
        AlphaBits = alphaBits;
        EndpointPBits = endpointPBits;
        SharedPBits = sharedPBits;
        IndexBits = indexBits;
        IndexBits2 = indexBits2;
        IndexBitsTotal = indexBitsTotal;
        IndexBits2Total = indexBits2Total;
    }

    public static Bc7Mode GetFromModeIndex( int modeIndex ) => modeIndex switch
    {
        0 => new( 0, 3, 4, 0, 0, 4, 0, 1, 0, 3, 0, 45, 0 ),
        1 => new( 1, 2, 6, 0, 0, 6, 0, 0, 1, 3, 0, 46, 0 ),
        2 => new( 2, 3, 6, 0, 0, 5, 0, 0, 0, 2, 0, 29, 0 ),
        3 => new( 3, 2, 6, 0, 0, 7, 0, 1, 0, 2, 0, 30, 0 ),
        4 => new( 4, 1, 0, 2, 1, 5, 6, 0, 0, 2, 3, 31, 47 ),
        5 => new( 5, 1, 0, 2, 0, 7, 8, 0, 0, 2, 2, 31, 31 ),
        6 => new( 6, 1, 0, 0, 0, 7, 7, 1, 0, 4, 0, 63, 0 ),
        7 => new( 7, 2, 6, 0, 0, 5, 5, 1, 0, 2, 0, 30, 0 ),
        _ => default,
    };

    public static Bc7Mode GetFromFirstByte( byte firstByte )
    {
        if( firstByte == 0 )
            return default;

        var mode = 0;
        while( 0 == ( firstByte & ( 1 << mode ) ) )
            mode++;
        return GetFromModeIndex( mode );
    }
}