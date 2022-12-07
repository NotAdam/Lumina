using System.Buffers.Binary;

#pragma warning disable CS0169
#pragma warning disable CS1591

namespace Lumina.Data.Parsing.Scd
{
    public struct BinaryHeader
    {
        public byte[] Type;
        public byte[] SubType;
        public uint Version;
        public byte EndianType;
        public byte AlignmentBits;
        public ushort Offset;
        public ulong Size;
        public ulong DateTime;
        private uint _reserved1;
        private uint _reserved2;
        private uint _reserved3;
        private uint _reserved4;

        public BinaryHeader( LuminaBinaryReader binaryReader )
        {
            Type = binaryReader.ReadBytes( 4 );
            SubType = binaryReader.ReadBytes( 4 );
            Version = binaryReader.ReadUInt32();
            EndianType = binaryReader.ReadByte();

            if( binaryReader.IsLittleEndian != ( EndianType == 0 ) )
            {
                Version = BinaryPrimitives.ReverseEndianness( Version );
                binaryReader.IsLittleEndian = EndianType == 0;
            }

            AlignmentBits = binaryReader.ReadByte();
            Offset = binaryReader.ReadUInt16();
            Size = binaryReader.ReadUInt64();
            DateTime = binaryReader.ReadUInt64();
            _reserved1 = binaryReader.ReadUInt32();
            _reserved2 = binaryReader.ReadUInt32();
            _reserved3 = binaryReader.ReadUInt32();
            _reserved4 = binaryReader.ReadUInt32();
        }
    }

    public struct ScdHeader
    {
        public ushort SoundCount;
        public ushort TrackCount;
        public ushort AudioCount;
        public ushort Number;
        public uint TrackOffset;
        public uint AudioOffset;
        public uint LayoutOffset;
        public uint RoutingOffset;
        public uint AttributeOffset;
        public ushort EOFPaddingSize;
        private ushort _reserve16;
    }
}
