using System;
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

    public enum LodLevel : int
    {
        All = -1,
        Highest,
        High,
        Low,
        Max = 3
    }

    [StructLayout( LayoutKind.Sequential )]
    public unsafe struct SqPackFileInfo
    {
        public UInt32 Size;
        public FileType Type;
        public UInt32 RawFileSize;
        public fixed UInt32 __unknown[2];
        public UInt32 NumberOfBlocks;
    }

    [StructLayout( LayoutKind.Sequential )]
    public struct DatStdFileBlockInfos
    {
        public UInt32 Offset;
        public UInt16 CompressedSize;
        public UInt16 UncompressedSize;
    };

    [StructLayout( LayoutKind.Sequential )]
    struct DatBlockHeader
    {
        public UInt32 Size;
        public UInt32 unknown1;
        public UInt32 CompressedSize;
        public UInt32 UncompressedSize;
    };

    [StructLayout( LayoutKind.Sequential )]
    struct LodBlock
    {
        public UInt32 CompressedOffset;
        public UInt32 CompressedSize;
        public UInt32 DecompressedSize;
        public UInt32 BlockOffset;
        public UInt32 BlockCount;
    }

    [StructLayout( LayoutKind.Sequential )]
    public unsafe struct ModelBlock
    {
        public UInt32 Size;
        public FileType Type;
        public UInt32 RawFileSize;
        public UInt32 NumberOfBlocks;
        public UInt32 UsedNumberOfBlocks;
        public UInt32 Version;
        public UInt32 StackMemorySize;
        public UInt32 RuntimeMemorySize;
        public fixed UInt32 m_uVertexBufferSize[LodLevel.Max];
        public fixed UInt32 m_uEdgeGeometryVertexBufferSize[LodLevel.Max];
        public fixed UInt32 m_uIndexBufferSize[LodLevel.Max];
        public UInt32 m_uCompressedStackMemorySize;
        public UInt32 m_uCompressedRuntimeMemorySize;
        public fixed UInt32 m_uCompressedVertexBufferSize[LodLevel.Max];
        public fixed UInt32 m_uCompressedEdgeGeometryVertexBufferSize[LodLevel.Max];
        public fixed UInt32 m_uCompressedIndexBufferSize[LodLevel.Max];
        public UInt32 m_uStackMemoryOffset;
        public UInt32 m_uRuntimeMemoryOffset;
        public fixed UInt32 m_uVertexBufferOffset[LodLevel.Max];
        public fixed UInt32 m_uEdgeGeometryVertexBufferOffset[LodLevel.Max];
        public fixed UInt32 m_uIndexBufferOffset[LodLevel.Max];
        public UInt16 m_uStackDataBlockIndex;
        public UInt16 m_uRuntimeDataBlockIndex;
        public fixed UInt16 m_uVertexBufferDataBlockIndex[LodLevel.Max];
        public fixed UInt16 m_uEdgeGeometryVertexBufferDataBlockIndex[LodLevel.Max];
        public fixed UInt16 m_uIndexBufferDataBlockIndex[LodLevel.Max];
        public UInt16 m_uStackDataBlockNum;
        public UInt16 m_uRuntimeDataBlockNum;
        public fixed UInt16 m_uVertexBufferDataBlockNum[LodLevel.Max];
        public fixed UInt16 m_uEdgeGeometryVertexBufferDataBlockNum[LodLevel.Max];
        public fixed UInt16 m_uIndexBufferDataBlockNum[LodLevel.Max];
        public UInt16 m_uVertexDeclarationNum;
        public UInt16 m_uMaterialNum;
        public byte m_uLODNum;
        public bool m_bEnableIndexBufferStreaming;
        public bool m_bEnableEdgeGeometry;
        public byte m_uPadding;
    };
}