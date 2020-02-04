using System;
using Lumina.Data.Structs;

namespace Lumina.Data
{
    public class LuminaFileInfo
    {
        public UInt32 HeaderSize;
        public FileType Type;
        public UInt32 RawFileSize;
        public UInt32 BlockCount;

        public long Offset { get; internal set; }

        public ModelBlock ModelBlock { get; internal set; }
    }
}