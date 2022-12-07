using System;

#pragma warning disable CS1591

namespace Lumina.Data.Parsing.Scd
{
    [Flags]
    public enum AudioFlag
    {
        MarkerChunk = 0x01,
        MonoSplit = 0x02,
        VersionShiftBit = 0x01000000
    }

    public enum AudioFormat
    {
        Empty = -1,
        OggVorbis = 6,  // PC music
        Mp3 = 7,        // PS3
        MsAdpcm = 12,   // PC sound
        Atrac9 = 22     // PS4
    }

    public struct AudioBasicDesc
    {
        public uint Size;
        public uint Channel;
        public uint Rate;
        public AudioFormat Format;
        public uint LoopStart;
        public uint LoopEnd;
        public uint SubInfoSize;
        public AudioFlag Flg;
    }

    public struct SubInfoChunkHeader
    {
        public uint Id;
        public uint Size;
    }

    public struct SubInfoMarkerChunk
    {
        public SubInfoChunkHeader Header;
        public int SampleLoopStartPos;
        public int SampleLoopEndPos;
        public int NumMarkers;
    }

    public unsafe struct OggVorbisSeekTableHeader
    {
        public byte Version;
        public byte StructSize;
        public byte XorByte;
        public fixed byte Unknown[9];
        public float Step;
        public uint SeekTableSize;
        public uint OggHeaderSize;
        private fixed uint _padding[2];
    }

    public unsafe struct PS3MP3SeekTableHeader
    {
        public fixed byte Id[4];
        public byte Version;
        public fixed byte reserved[3];
        public float Step;
        public int NumElement;
    }

    public unsafe struct AdpcmWaveFormat
    {
        public ushort FormatTag;
        public short Channels;
        public int SamplesPerSec;
        public int AvgBytesPerSec;
        public short BlockAlign;
        public ushort BitsPerSample;
        public short Size;
        public ushort SamplesPerBlock;
        public ushort NumCoef;
        public fixed short Coef[14];
    }

    // structured with information from vgmstream
    public unsafe struct ATRAC9Header
    {
        public ushort Version;
        public ushort StructSize;
        public ushort SuperframeBytes;
        public ushort SuperframeSamples;
        public uint Unknown;
        public uint ConfigData;
        public uint SampleCount;
        public uint Unknown0;
        public uint SampleDelay;
        public uint SampleRate;
        public uint SampleLoopStart;
        public uint SampleLoopEnd;
        private fixed uint _padding[2];
    }
}
