using System;
using System.Runtime.InteropServices;

// ReSharper disable MemberCanBePrivate.Global

namespace Lumina.Data.Structs
{
    public enum FileType : UInt32
    {
        Empty = 1, 
        Standard = 2, 
        Model = 3, 
        Texture = 4,
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SqPackFileInfo
    {
        public UInt32 Size;
        public FileType Type;
        public UInt32 RawFileSize;
        public fixed UInt32 __unknown[2];
        public UInt32 number_of_blocks;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct DatStdFileBlockInfos
    {
        public UInt32 offset;
        public UInt16 size;
        public UInt16 uncompressed_size;
    };
    
    [StructLayout(LayoutKind.Sequential)]
    struct DatBlockHeader
    {
        public UInt32 size;
        public UInt32 unknown1;
        public UInt32 compressed_size;
        public UInt32 uncompressed_size;
    };

    [StructLayout(LayoutKind.Sequential)]
    struct LodBlock
    {
        public UInt32 comp_offset;
        public UInt32 comp_size;
        public UInt32 decomp_size;
        public UInt32 block_offset;
        public UInt32 block_count;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ModelBlock
    {
        public UInt32 Size;
        public FileType Type;
        public UInt32 RawFileSize;
        public UInt32 number_of_block;
        public UInt32 used_number_of_block;
        public UInt32 m_uVersion;
        public UInt32 m_uStackMemorySize;
        public UInt32 m_uRuntimeMemorySize;
        public fixed UInt32 m_uVertexBufferSize[3];
        public fixed UInt32 m_uEdgeGeometryVertexBufferSize[3];
        public fixed UInt32 m_uIndexBufferSize[3];
        public UInt32 m_uCompressedStackMemorySize;
        public UInt32 m_uCompressedRuntimeMemorySize;
        public fixed UInt32 m_uCompressedVertexBufferSize[3];
        public fixed UInt32 m_uCompressedEdgeGeometryVertexBufferSize[3];
        public fixed UInt32 m_uCompressedIndexBufferSize[3];
        public UInt32 m_uStackMemoryOffset;
        public UInt32 m_uRuntimeMemoryOffset;
        public fixed UInt32 m_uVertexBufferOffset[3];
        public fixed UInt32 m_uEdgeGeometryVertexBufferOffset[3];
        public fixed UInt32 m_uIndexBufferOffset[3];
        public UInt16 m_uStackDataBlockIndex;
        public UInt16 m_uRuntimeDataBlockIndex;
        public fixed UInt16 m_uVertexBufferDataBlockIndex[3];
        public fixed UInt16 m_uEdgeGeometryVertexBufferDataBlockIndex[3];
        public fixed UInt16 m_uIndexBufferDataBlockIndex[3];
        public UInt16 m_uStackDataBlockNum;
        public UInt16 m_uRuntimeDataBlockNum;
        public fixed UInt16 m_uVertexBufferDataBlockNum[3];
        public fixed UInt16 m_uEdgeGeometryVertexBufferDataBlockNum[3];
        public fixed UInt16 m_uIndexBufferDataBlockNum[3];
        public UInt16 m_uVertexDeclarationNum;
        public UInt16 m_uMaterialNum;
        public byte m_uLODNum;
        public bool m_bEnableIndexBufferStreaming;
        public bool m_bEnableEdgeGeometry;
        public byte m_uPadding;
        public fixed UInt16 m_uCompressedBlockSize[1];
    };
    

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DatMdlFileBlockInfo
    {
        public UInt32 unknown1;
        public fixed UInt32 uncompressed_sizes[0xB];
        public fixed UInt32 compressed_sizes[0xB];
        public fixed UInt32 offsets[0xB];
        public fixed UInt16 block_ids[0xB];
        public fixed UInt16 block_counts[0xB];
        public fixed UInt32 unknown2[0x2];
    }
}