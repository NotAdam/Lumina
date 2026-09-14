using Lumina.Data.Structs.SqPack;
using Lumina.Misc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Lumina.Data;

public sealed class SqPackTextureStream : SqPackStream
{
    public new SqPackFileTextureHeader Header { get; }


    private MappedFile.Segment< byte > StreamHeader { get; }
    private long[] BlockOffsets { get; }
    private long[] BlockStartPositions { get; }
    private ushort? UniformBlockUncompressedSize { get; set; }

    public SqPackTextureStream( MappedFile datFile, long offset ) : base( datFile, offset )
    {
        Header = datFile.GetAt< SqPackFileTextureHeader >( Offset );
        var texBlocks = DatFile.GetSpanAt< SqPackTextureBlock >( Offset + Unsafe.SizeOf< SqPackFileTextureHeader >(),
            checked( (int)Header.BlockCount ) );

        var blockCount = 0;
        foreach( var block in texBlocks.Span )
            blockCount += checked( (ushort)block.BlockCount );

        var compressedBlockSizes =
            DatFile.GetSpanAt< ushort >( texBlocks.ByteOffset + texBlocks.ByteLength, blockCount );

        StreamHeader = DatFile.GetSpanAt< byte >( Offset + Header.Base.HeaderSize,
            checked( (int)texBlocks.Span[ 0 ].Offset ) );

        List< long > blockOffsets = [];
        List< long > startPositions = [];

        var isFirst = true;
        long startPos = 0;
        foreach( var texBlock in texBlocks.Span )
        {
            var group = ReadBlocks( texBlock.Offset, checked( (ushort)texBlock.BlockOffset ),
                checked( (ushort)texBlock.BlockCount ), compressedBlockSizes, isFirst );
            if( isFirst )
                isFirst = false;

            foreach( var block in group )
            {
                blockOffsets.Add( block.Offset );
                startPositions.Add( startPos );
                startPos += block.DecompressedSize;
            }
        }

        if( !UniformBlockUncompressedSize.HasValue )
            BlockStartPositions = [.. startPositions];
        BlockOffsets = [.. blockOffsets];
    }

    private (ushort DecompressedSize, long Offset)[] ReadBlocks( uint offset, ushort blockStartIdx, ushort blockCount,
        ReadOnlySpan< ushort > compressedBlockSizes, bool isFirstBlockSet = false )
    {
        var blocks = new (ushort, long)[blockCount];
        for( ushort i = 0; i < blockCount; ++i )
        {
            var blockIdx = blockStartIdx + i;
            var (data, decompSize) = GetBlockInfo( offset );
            Debug.Assert( data.Length <= compressedBlockSizes[ blockIdx ] );

            var uncompSize = checked( (ushort)( decompSize ?? data.Length ) );
            blocks[ i ] = ( uncompSize, offset );
            offset += compressedBlockSizes[ blockIdx ];

            if( isFirstBlockSet && i == 0 )
                UniformBlockUncompressedSize = uncompSize;
            else if( UniformBlockUncompressedSize != null && UniformBlockUncompressedSize != uncompSize )
                UniformBlockUncompressedSize = null;
        }

        // totalSize = blocks.Sum( b => b.Item1 );

        return blocks;
    }

    private protected override BlockData? GetCurrentBlock()
    {
        if( !BlockInfo.HasValue )
        {
            if( BlockIndex == 0 )
                BlockInfo = new( StreamHeader );
            else
            {
                if( BlockOffsets.Length <= BlockIndex - 1 )
                    return null;
                BlockInfo = GetBlock( BlockOffsets[ BlockIndex - 1 ] );
            }
        }

        return BlockInfo.Value;
    }

    private protected override (int BlockIndex, int BlockOffset) ResolveBlockPosition( long offset )
    {
        if( offset < StreamHeader.Length )
            return ( 0, (int)offset );
        offset -= StreamHeader.Length;

        if( UniformBlockUncompressedSize.HasValue )
        {
            var (a, b) = long.DivRem( offset, UniformBlockUncompressedSize.Value );
            return checked( ( (int)a + 1, (int)b ) );
        }

        if( BlockStartPositions.Length == 0 )
            throw new InvalidOperationException( "No blocks" );

        // Binary search for the block index
        int idx = BlockStartPositions.AsSpan().BinarySearch( offset );
        if( idx < 0 )
            idx = ~idx - 1;

        return checked( ( idx + 1, (int)( offset - BlockStartPositions[ idx ] ) ) );
    }
}
