using System;
using System.Buffers.Binary;
using System.Runtime.InteropServices;

// ReSharper disable MemberCanBePrivate.Global

namespace Lumina.Data.Structs
{
    public enum FileType : uint
    {
        Empty = 1,
        Standard = 2,
        Model = 3,
        Texture = 4,
    }

    public enum LodLevel
    {
        All = -1,
        Highest,
        High,
        Low,
        Max = 3
    }

    [StructLayout( LayoutKind.Sequential )]
    public unsafe struct SqPackFileInfo : IConvertEndianness
    {
        public UInt32 Size;
        public FileType Type;
        public UInt32 RawFileSize;
        public fixed UInt32 __unknown[2];
        public UInt32 NumberOfBlocks;

        public void ConvertEndianness()
        {
            Size = BinaryPrimitives.ReverseEndianness( Size );
            Type = (FileType)BinaryPrimitives.ReverseEndianness( (uint)Type );
            RawFileSize = BinaryPrimitives.ReverseEndianness( RawFileSize );

            for( int i = 0; i < 2; i++ )
            {
                __unknown[ i ] = BinaryPrimitives.ReverseEndianness( __unknown[i] );
            }

            NumberOfBlocks = BinaryPrimitives.ReverseEndianness( NumberOfBlocks );
        }
    }

    [StructLayout( LayoutKind.Sequential )]
    public struct DatStdFileBlockInfos : IConvertEndianness
    {
        public UInt32 Offset;
        public UInt16 CompressedSize;
        public UInt16 UncompressedSize;

        public void ConvertEndianness()
        {
            Offset = BinaryPrimitives.ReverseEndianness( Offset );
            CompressedSize = BinaryPrimitives.ReverseEndianness( CompressedSize );
            UncompressedSize = BinaryPrimitives.ReverseEndianness( UncompressedSize );
        }
    };

    /// <summary>
    /// The type of block in the sqpack, indicates compression or not
    /// </summary>
    public enum DatBlockType : uint
    {
        Compressed = 16000,
        Uncompressed = 32000,
    }

    [StructLayout( LayoutKind.Sequential )]
    struct DatBlockHeader : IConvertEndianness
    {
        public UInt32 Size;
        // always 0?
        public UInt32 unknown1;
        public DatBlockType DatBlockType;
        public UInt32 BlockDataSize;

        public void ConvertEndianness()
        {
            Size = BinaryPrimitives.ReverseEndianness( Size );
            unknown1 = BinaryPrimitives.ReverseEndianness( unknown1 );
            DatBlockType = (DatBlockType)BinaryPrimitives.ReverseEndianness( (uint)DatBlockType );
            BlockDataSize = BinaryPrimitives.ReverseEndianness( BlockDataSize );
        }
    };

    [StructLayout( LayoutKind.Sequential )]
    struct LodBlock : IConvertEndianness
    {
        public UInt32 CompressedOffset;
        public UInt32 CompressedSize;
        public UInt32 DecompressedSize;
        public UInt32 BlockOffset;
        public UInt32 BlockCount;

        public void ConvertEndianness()
        {
            CompressedOffset = BinaryPrimitives.ReverseEndianness( CompressedOffset );
            CompressedSize = BinaryPrimitives.ReverseEndianness( CompressedSize );
            DecompressedSize = BinaryPrimitives.ReverseEndianness( DecompressedSize );
            BlockOffset = BinaryPrimitives.ReverseEndianness( BlockOffset );
            BlockCount = BinaryPrimitives.ReverseEndianness( BlockCount );
        }
    }

    [StructLayout( LayoutKind.Sequential )]
    public unsafe struct ModelBlock : IConvertEndianness
    {
        public UInt32 Size;
        public FileType Type;
        public UInt32 RawFileSize;
        public UInt32 NumberOfBlocks;
        public UInt32 UsedNumberOfBlocks;
        public UInt32 Version;
        public UInt32 StackSize;
        public UInt32 RuntimeSize;
        public fixed UInt32 VertexBufferSize[(int)LodLevel.Max];
        public fixed UInt32 EdgeGeometryVertexBufferSize[(int)LodLevel.Max];
        public fixed UInt32 IndexBufferSize[(int)LodLevel.Max];
        public UInt32 CompressedStackMemorySize;
        public UInt32 CompressedRuntimeMemorySize;
        public fixed UInt32 CompressedVertexBufferSize[(int)LodLevel.Max];
        public fixed UInt32 CompressedEdgeGeometryVertexBufferSize[(int)LodLevel.Max];
        public fixed UInt32 CompressedIndexBufferSize[(int)LodLevel.Max];
        public UInt32 StackOffset;
        public UInt32 RuntimeOffset;
        public fixed UInt32 VertexBufferOffset[(int)LodLevel.Max];
        public fixed UInt32 EdgeGeometryVertexBufferOffset[(int)LodLevel.Max];
        public fixed UInt32 IndexBufferOffset[(int)LodLevel.Max];
        public UInt16 StackBlockIndex;
        public UInt16 RuntimeBlockIndex;
        public fixed UInt16 VertexBufferBlockIndex[(int)LodLevel.Max];
        public fixed UInt16 EdgeGeometryVertexBufferBlockIndex[(int)LodLevel.Max];
        public fixed UInt16 IndexBufferBlockIndex[(int)LodLevel.Max];
        public UInt16 StackBlockNum;
        public UInt16 RuntimeBlockNum;
        public fixed UInt16 VertexBufferBlockNum[(int)LodLevel.Max];
        public fixed UInt16 EdgeGeometryVertexBufferBlockNum[(int)LodLevel.Max];
        public fixed UInt16 IndexBufferBlockNum[(int)LodLevel.Max];
        public UInt16 VertexDeclarationNum;
        public UInt16 MaterialNum;
        public byte NumLods;
        public bool IndexBufferStreamingEnabled;
        public bool EdgeGeometryEnabled;
        public byte Padding;

        public void ConvertEndianness()
        {
            Size = BinaryPrimitives.ReverseEndianness( Size );
            Type = (FileType)BinaryPrimitives.ReverseEndianness( (uint)Type );
            RawFileSize = BinaryPrimitives.ReverseEndianness( RawFileSize );
            NumberOfBlocks = BinaryPrimitives.ReverseEndianness( NumberOfBlocks );
            UsedNumberOfBlocks = BinaryPrimitives.ReverseEndianness( UsedNumberOfBlocks );
            Version = BinaryPrimitives.ReverseEndianness( Version );
            StackSize = BinaryPrimitives.ReverseEndianness( StackSize );
            RuntimeSize = BinaryPrimitives.ReverseEndianness( RuntimeSize );
            CompressedStackMemorySize = BinaryPrimitives.ReverseEndianness( CompressedStackMemorySize );
            CompressedRuntimeMemorySize = BinaryPrimitives.ReverseEndianness( CompressedRuntimeMemorySize );
            StackOffset = BinaryPrimitives.ReverseEndianness( StackOffset );
            RuntimeOffset = BinaryPrimitives.ReverseEndianness( RuntimeOffset );
            StackBlockIndex = BinaryPrimitives.ReverseEndianness( StackBlockIndex );
            RuntimeBlockIndex = BinaryPrimitives.ReverseEndianness( RuntimeBlockIndex );
            StackBlockNum = BinaryPrimitives.ReverseEndianness( StackBlockNum );
            RuntimeBlockNum = BinaryPrimitives.ReverseEndianness( RuntimeBlockNum );
            VertexDeclarationNum = BinaryPrimitives.ReverseEndianness( VertexDeclarationNum );
            MaterialNum = BinaryPrimitives.ReverseEndianness( MaterialNum );

            for( int i = 0; i < (int)LodLevel.Max; i++ )
            {
                VertexBufferSize[ i ] = BinaryPrimitives.ReverseEndianness( VertexBufferSize[ i ] );
                EdgeGeometryVertexBufferSize[ i ] = BinaryPrimitives.ReverseEndianness( EdgeGeometryVertexBufferSize[ i ] );
                IndexBufferSize[ i ] = BinaryPrimitives.ReverseEndianness( IndexBufferSize[ i ] );
                CompressedVertexBufferSize[ i ] = BinaryPrimitives.ReverseEndianness( CompressedVertexBufferSize[ i ] );
                CompressedEdgeGeometryVertexBufferSize[ i ] = BinaryPrimitives.ReverseEndianness( CompressedEdgeGeometryVertexBufferSize[ i ] );
                CompressedIndexBufferSize[ i ] = BinaryPrimitives.ReverseEndianness( CompressedIndexBufferSize[ i ] );
                VertexBufferOffset[ i ] = BinaryPrimitives.ReverseEndianness( VertexBufferOffset[ i ] );
                EdgeGeometryVertexBufferOffset[ i ] = BinaryPrimitives.ReverseEndianness( EdgeGeometryVertexBufferOffset[ i ] );
                IndexBufferOffset[ i ] = BinaryPrimitives.ReverseEndianness( IndexBufferOffset[ i ] );
                VertexBufferBlockIndex[ i ] = BinaryPrimitives.ReverseEndianness( VertexBufferBlockIndex[ i ] );
                EdgeGeometryVertexBufferBlockIndex[ i ] = BinaryPrimitives.ReverseEndianness( EdgeGeometryVertexBufferBlockIndex[ i ] );
                IndexBufferBlockIndex[ i ] = BinaryPrimitives.ReverseEndianness( IndexBufferBlockIndex[ i ] );
                VertexBufferBlockNum[ i ] = BinaryPrimitives.ReverseEndianness( VertexBufferBlockNum[ i ] );
                EdgeGeometryVertexBufferBlockNum[ i ] = BinaryPrimitives.ReverseEndianness( EdgeGeometryVertexBufferBlockNum[ i ] );
                IndexBufferBlockNum[ i ] = BinaryPrimitives.ReverseEndianness( IndexBufferBlockNum[ i ] );
            }
        }
    };
}