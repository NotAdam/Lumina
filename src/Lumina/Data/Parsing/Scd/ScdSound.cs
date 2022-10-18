using System;

#pragma warning disable CS0169
#pragma warning disable CS1591

namespace Lumina.Data.Parsing.Scd
{
    public static class ScdSound
    {
        public enum SoundType : byte
        {
            Normal = 1,
            Random,
            Stereo,
            Cycle,
            Order,
            FourChannelSurround,
            Engine,
            Dialog,

            FixedPosition = 10,
            DynamixStream,
            GroupRandom,
            GroupOrder,
            Atomosgear,
            ConditionalJump,
            Empty,

            MidiMusic = 128
        }

        [Flags]
        public enum SoundAttribute
        {
            Loop = 0x0001,
            Reverb = 0x0002,
            FixedVolume = 0x0004,
            FixedPosition = 0x0008,

            Music = 0x0020,
            BypassPLIIz = 0x0040,
            UseExternalAttr = 0x0080,
            ExistRoutingSetting = 0x0100,
            MusicSurround = 0x0200,
            BusDucking = 0x0400,
            Acceleration = 0x0800,
            DynamixEnd = 0x1000,
            ExtraDesc = 0x2000,
            DynamixPlus = 0x4000,
            Atomosgear = 0x8000,
        }

        public enum FilterType
        {
            Bypass,
            LowPass,
            HighPass,
            BandPass,
            BandEliminate,
            LowShelving,
            HighShelving,
            Peaking
        }

        public enum InsertEffectName : byte
        {
            NoEffect,
            LowPassFilter,
            HighPassFilter,
            BandPassFilter,
            BandEliminateFilter,
            LowShelvingFilter,
            HighShelvingFilter,
            PeakingFilter,
            Equalizer,
            Compressor,
            Reverb,
            GranularSynthesizer,
            Delay,
            SimpleMeter
        }

        public struct SoundBasicDesc
        {
            public byte TrackCount;
            public byte BusNumber;
            public byte Priority;
            public SoundType Type;
            public SoundAttribute Attribute;
            public float Volume;
            public ushort LocalNumber;
            public byte UserId;
            public sbyte PlayHistory;
        }

        public unsafe struct RoutingInfo
        {
            public uint DataSize;
            public byte SendCount;
            private fixed byte _reserves[11];
        }

        public unsafe struct SendInfo
        {
            public byte Target;
            private fixed byte _reserves[3];
            public float Volume;
            private fixed uint _reserves2[2];
        }

        public struct EqualizerFilterParam
        {
            public float Freq;
            public float Invq;
            public float Gain;
            public FilterType Type;
        }

        public struct SoundEqualizerEffect
        {
            public EqualizerFilterParam[] Filters;
            public int NumFilters;
            private int[] _reserves;

            public SoundEqualizerEffect( LuminaBinaryReader binaryReader )
            {
                Filters = binaryReader.ReadStructuresAsArray< EqualizerFilterParam >( 8 );
                NumFilters = binaryReader.ReadInt32();
                _reserves = binaryReader.ReadInt32Array( 2 );
            }
        }

        public struct SoundEffectParam
        {
            public InsertEffectName Type;
            public byte[] reserves;
            public SoundEqualizerEffect Param;

            public SoundEffectParam( LuminaBinaryReader binaryReader )
            {
                Type = (InsertEffectName)binaryReader.ReadByte();
                reserves = binaryReader.ReadBytes( 3 );
                Param = new SoundEqualizerEffect( binaryReader );
            }
        }

        public unsafe struct BusDuckingInfo
        {
            public byte Size;
            public byte Number;
            private fixed byte _reserves[2];
            public uint FadeTime;
            public float Volume;
            private uint _reserve2;
        }

        public unsafe struct AccelerationData
        {
            public byte Version;
            public byte StructSize;
            private fixed byte _reserved[2];
            public float Volume;
            public int UpTime;
            public int DownTime;
        }

        public struct AccelerationInfo
        {
            public byte Version;
            public byte StructSize;
            public byte NumAcceleration;
            private byte _reserve;
            private uint[] _reserve2;
            public AccelerationData[] Acceleration;

            public AccelerationInfo( LuminaBinaryReader binaryReader )
            {
                Version = binaryReader.ReadByte();
                StructSize = binaryReader.ReadByte();
                NumAcceleration = binaryReader.ReadByte();
                _reserve = binaryReader.ReadByte();
                _reserve2 = binaryReader.ReadUInt32Array( 3 );
                Acceleration = binaryReader.ReadStructuresAsArray< AccelerationData >( 4 );
            }
        }

        public unsafe struct SoundExtraDesc
        {
            public byte Version;
            private byte _reserved;
            public ushort Size;
            public uint PlayTimeLength;
            private fixed uint _reserved2[2];
        }

        public unsafe struct AtomosgearInfo
        {
            public byte Version;
            private byte _reserved;
            public ushort Size;
            public ushort MinNumPeoples;
            public ushort MaxNumPeoples;
            private fixed uint _reserved2[2];
        }

        public struct TrackInfo
        {
            public ushort TrackDataIndex;
            public ushort AudioDataIndex;
        }

        public struct RandomTrackInfo
        {
            public TrackInfo BaseInfo;
            public uint UpperLimit;
        }

        public struct CycleInfo
        {
            public uint Interval;
            public ushort NumPlayTrack;
            public ushort Range;
        }
    }
}
