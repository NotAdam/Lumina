using Lumina.Data.Structs.SqPack;
using Lumina.Misc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Lumina.Data;

public sealed class SqPackModelStream : SqPackStream
{
    public new SqPackFileModelHeader Header { get; }


    private byte[] StreamHeader { get; }
    private long[] BlockOffsets { get; }
    private long[] BlockStartPositions { get; }
    private ushort? UniformBlockUncompressedSize { get; set; }

    public SqPackModelStream( MappedFile datFile, long offset ) : base( datFile, offset )
    {
        Header = DatFile.GetAt<SqPackFileModelHeader>( offset );

        var counts = Header.BlockCounts;
        var count = counts.Stack + counts.Runtime;
        foreach (var v in counts.VertexBuffer)
            count += v;
        foreach( var v in counts.EdgeGeometryVertexBuffer )
            count += v;
        foreach( var v in counts.IndexBuffer )
            count += v;

        var compressedBlockSizes = DatFile.GetSpanAt<ushort>( Offset + Unsafe.SizeOf<SqPackFileModelHeader>(), count );

        var (blockGroups, sizes, offsets) = ReadData( compressedBlockSizes );

        {
            List<long> blockOffsets = [];
            List<long> startPositions = [];
            long startPos = 0;
            foreach( var group in blockGroups )
            {
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

        const int HEADER_SIZE = 0x44;
        using var header = new MemoryStream( HEADER_SIZE );
        using var writer = new BinaryWriter( header );
        writer.Write( Header.Version );
        writer.Write( sizes.Stack );
        writer.Write( sizes.Runtime );
        writer.Write( Header.VertexDeclarationCount );
        writer.Write( Header.MaterialCount );
        foreach( var s in offsets.VertexBuffer )
            writer.Write( HEADER_SIZE + s );
        foreach( var s in offsets.IndexBuffer )
            writer.Write( HEADER_SIZE + s );
        foreach( var s in sizes.VertexBuffer )
            writer.Write( s );
        foreach( var s in sizes.IndexBuffer )
            writer.Write( s );
        writer.Write( Header.LodCount );
        writer.Write( Header.IndexBufferStreamingEnabled );
        writer.Write( Header.EdgeGeometryEnabled );
        writer.Write( (byte)0 );
        StreamHeader = header.ToArray();
        Debug.Assert( StreamHeader.Length == HEADER_SIZE );
    }

    private (List<(ushort DecompressedSize, long Offset)[]>, SqPackFileModelHeader.Section<int> Sizes, SqPackFileModelHeader.Section<int> Offsets) ReadData( ReadOnlySpan<ushort> compressedBlockSizes )
    {
        var sizes = new SqPackFileModelHeader.Section<int>();
        var offsets = new SqPackFileModelHeader.Section<int>();
        var blocks = new List<(ushort DecompressedSize, long Offset)[]>( 2+3*3 );

        blocks.Add( ReadBlocks( Header.Offsets.Stack, Header.BlockIndices.Stack, Header.BlockCounts.Stack, compressedBlockSizes, out sizes.Stack, true ) );
        offsets.Stack = 0;

        blocks.Add( ReadBlocks( Header.Offsets.Runtime, Header.BlockIndices.Runtime, Header.BlockCounts.Runtime, compressedBlockSizes, out sizes.Runtime ) );
        offsets.Runtime = sizes.Stack;

        for (var i = 0; i < SqPackFileModelHeader.LOD_COUNT; ++i )
        {
            blocks.Add(ReadBlocks( Header.Offsets.VertexBuffer[i], Header.BlockIndices.VertexBuffer[i], Header.BlockCounts.VertexBuffer[i], compressedBlockSizes, out sizes.VertexBuffer[i] ));
            offsets.VertexBuffer[i] =
                i == 0 ?
                    ( offsets.Runtime + sizes.Runtime ) :
                    ( offsets.IndexBuffer[i - 1] + sizes.IndexBuffer[i - 1] );

            blocks.Add(ReadBlocks( Header.Offsets.EdgeGeometryVertexBuffer[i], Header.BlockIndices.EdgeGeometryVertexBuffer[i], Header.BlockCounts.EdgeGeometryVertexBuffer[i], compressedBlockSizes, out sizes.EdgeGeometryVertexBuffer[i] ));
            offsets.EdgeGeometryVertexBuffer[i] = offsets.VertexBuffer[i] + sizes.VertexBuffer[i];

            blocks.Add(ReadBlocks( Header.Offsets.IndexBuffer[i], Header.BlockIndices.IndexBuffer[i], Header.BlockCounts.IndexBuffer[i], compressedBlockSizes, out sizes.IndexBuffer[i] ));
            offsets.IndexBuffer[i] = offsets.EdgeGeometryVertexBuffer[i] + sizes.EdgeGeometryVertexBuffer[i];
        }
        return (blocks, sizes, offsets);
    }

    private (ushort DecompressedSize, long Offset)[] ReadBlocks(uint offset, ushort blockStartIdx, ushort blockCount, ReadOnlySpan<ushort> compressedBlockSizes, out int totalSize, bool isFirstBlockSet = false )
    {
        var blocks = new (ushort, long)[blockCount];
        for (ushort i = 0; i < blockCount; ++i )
        {
            var blockIdx = blockStartIdx + i;
            var( data, decompSize) = GetBlockInfo( offset );
            Debug.Assert( data.Length <= compressedBlockSizes[blockIdx] );

            var uncompSize = checked((ushort)( decompSize ?? data.Length ));
            blocks[i] = ( uncompSize , offset);
            offset += compressedBlockSizes[blockIdx];

            if( isFirstBlockSet && i == 0 )
                UniformBlockUncompressedSize = uncompSize;
            else if( UniformBlockUncompressedSize != null && UniformBlockUncompressedSize != uncompSize )
                UniformBlockUncompressedSize = null;
        }

        totalSize = blocks.Sum( b => b.Item1 );
        
        return blocks;
    }

    private protected override BlockData? GetCurrentBlock()
    {
        if( !BlockInfo.HasValue )
        {
            if( BlockIndex == 0 )
                BlockInfo = new( StreamHeader, StreamHeader.Length );
            else
            {
                if( BlockOffsets.Length <= BlockIndex - 1 )
                    return null;
                BlockInfo = GetBlock( BlockOffsets[BlockIndex - 1] );
            }
        }
        return BlockInfo.Value;
    }

    private protected override (int BlockIndex, int BlockOffset) ResolveBlockPosition( long offset )
    {
        if( offset < StreamHeader.Length )
            return (0, (int)offset);
        offset -= StreamHeader.Length;

        if( UniformBlockUncompressedSize.HasValue )
        {
            (long a, long b) = long.DivRem( offset, UniformBlockUncompressedSize.Value );
            return checked(((int)a + 1, (int)b));
        }

        if( BlockStartPositions.Length == 0 )
            throw new InvalidOperationException( "No blocks" );

        // Binary search for the block index
        int idx = BlockStartPositions.AsSpan().BinarySearch( offset );
        if( idx < 0 )
            idx = ~idx - 1;

        return checked((idx + 1, (int)( offset - BlockStartPositions[idx] )));
    }
}
