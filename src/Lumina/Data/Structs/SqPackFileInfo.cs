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

    public enum LodLevel
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

    /// <summary>
    /// The type of block in the sqpack, indicates compression or not
    /// </summary>
    public enum DatBlockType : uint
    {
        Compressed = 16000,
        Uncompressed = 32000,
    }

    [StructLayout( LayoutKind.Sequential )]
    struct DatBlockHeader
    {
        public UInt32 Size;
        public UInt32 unknown1;
        public DatBlockType DatBlockType;
        public UInt32 BlockDataSize;
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
    };
}