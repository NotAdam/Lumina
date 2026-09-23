using Lumina.Data.Structs.SqPack;
using Lumina.Misc;
using System;
using System.Runtime.CompilerServices;

namespace Lumina.Data;

public sealed class SqPackStandardStream : SqPackStream
{
    public new SqPackFileStandardHeader Header { get; }


    private MappedFile.Segment< SqPackStandardBlockDescriptor > StandardBlockDescriptors { get; }

    /// Endian-swapped copies of the descriptors, only for big-endian streams.
    private readonly SqPackStandardBlockDescriptor[]? swappedDescriptors;

    private long[]? BlockStartPositions { get; }
    private ushort? UniformBlockUncompressedSize { get; }

    public SqPackStandardStream( MappedFile datFile, long offset, bool bigEndian = false )
        : base( datFile, offset, bigEndian )
    {
        Header = datFile.GetAt< SqPackFileStandardHeader >( offset );
        if( bigEndian )
            Header = Header.ReverseEndianness();
        StandardBlockDescriptors = DatFile.GetSpanAt< SqPackStandardBlockDescriptor >(
            Offset + Unsafe.SizeOf< SqPackFileStandardHeader >(), checked( (int)Header.BlockCount ) );

        if( bigEndian )
        {
            swappedDescriptors = new SqPackStandardBlockDescriptor[StandardBlockDescriptors.Length];
            for( var i = 0; i < swappedDescriptors.Length; i++ )
                swappedDescriptors[ i ] = StandardBlockDescriptors.Span[ i ].ReverseEndianness();
        }

        BlockStartPositions = new long[StandardBlockDescriptors.Length];
        long pos = 0;
        for( int i = 0; i < StandardBlockDescriptors.Length; ++i )
        {
            BlockStartPositions[ i ] = pos;
            ushort uncompSize = Descriptors[ i ].UncompressedSize;
            pos += uncompSize;
            if( i == 0 )
                UniformBlockUncompressedSize = uncompSize;
            else if( UniformBlockUncompressedSize != null && UniformBlockUncompressedSize != uncompSize &&
                     i != StandardBlockDescriptors.Length - 1 )
                UniformBlockUncompressedSize = null;
        }

        if( UniformBlockUncompressedSize.HasValue )
            BlockStartPositions = null;
    }

    private ReadOnlySpan< SqPackStandardBlockDescriptor > Descriptors =>
        swappedDescriptors ?? StandardBlockDescriptors.Span;

    private protected override BlockData? GetCurrentBlock()
    {
        if( !BlockInfo.HasValue )
        {
            if( StandardBlockDescriptors.Length <= BlockIndex )
                return null;
            BlockInfo = GetBlock( Descriptors[ BlockIndex ].Offset );
        }

        return BlockInfo.Value;
    }

    private protected override (int BlockIndex, int BlockOffset) ResolveBlockPosition( long offset )
    {
        if( UniformBlockUncompressedSize.HasValue )
        {
            var (a, b) = long.DivRem( offset, UniformBlockUncompressedSize.Value );
            return checked( ( (int)a, (int)b ) );
        }

        if( BlockStartPositions == null || BlockStartPositions.Length == 0 )
            throw new InvalidOperationException( "No blocks" );

        // Binary search for the block index
        int idx = BlockStartPositions.AsSpan().BinarySearch( offset );
        if( idx < 0 )
            idx = ~idx - 1;

        return checked( ( idx, (int)( offset - BlockStartPositions[ idx ] ) ) );
    }
}
