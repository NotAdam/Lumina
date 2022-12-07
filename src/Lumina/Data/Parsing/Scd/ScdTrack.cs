using System;

#pragma warning disable CS0169
#pragma warning disable CS1591

namespace Lumina.Data.Parsing.Scd
{
    public enum TrackCmd : ushort
    {
        End,
        Volume,
        Pitch,
        Interval,
        Modulation,
        ReleaseRate,
        Panning,
        KeyOn,
        RandomVolume,
        RandomPitch,
        RandomPan,

        KeyOff = 0xC,
        LoopStart,
        LoopEnd,
        ExternalAudio,
        EndForLoop,
        AddInterval,
        Expression,
        Velocity,
        MidiVolume,
        MidiAddVolume,
        MidiPan,
        MidiAddPan,
        ModulationType,
        ModulationDepth,
        ModulationAddDepth,
        ModulationSpeed,
        ModulationAddSpeed,
        ModulationOff,
        PitchBend,
        Transpose,
        AddTranspose,
        FrPanning,
        RandomWait,
        Adsr,
        CutOff,
        Jump,
        PlayContinueLoop,
        Sweep,
        MidiKeyOnOld,
        SlurOn,
        SlurOff,
        AutoAdsrEnvelope,
        MidiExternalAudio,
        Marker,
        InitParams,
        Version,
        ReverbOn,
        ReverbOff,
        MidiKeyOn,
        PortamentoOn,
        PortamentoOff,
        MidiEnd,
        ClearKeyInfo,
        ModulationDepthFade,
        ModulationSpeedFade,
        AnalysisFlag,
        Config,
        Filter,
        PlayInnerSound,
        VolumeZeroOne,
        ZeroOneJump,
        ChannelVolumeZeroOne,
        Unknown64
    }

    public enum TrackCmdJump : byte
    {
        LZE = 0x1,
        LNZ,
    }

    public enum TrackCmdConfigType : ushort
    {
        NOP,
        IntervalType,
        IntervalTypeFloat = 1
    }

    public enum OscillatorCarrier : byte
    {
        None,
        Volume,
        Pitch,
        Pan,
        FrPan
    }

    public enum OscillatorMode : byte
    {
        None,
        Sine,
        Rectangle,
        Triangle,
        Saw,
        Random,
        ReverseSine,
        ReverseRectangle,
        ReverseTriangle,
        ReverseSaw
    }

    public enum VolumeCurveType : byte
    {
        Auto,
        Square,
        White,
        Old,
        OldWiiEmu,
        WhiteOnlyMusic,
        Caelum
    }

    public struct TrackCmdParam
    {
        public float Value;
        public uint Time;
    }

    public struct ModulationCmdParam
    {
        public OscillatorCarrier Carrier;
        public OscillatorMode Modulator;
        public VolumeCurveType Curve;
        private byte _reserve;
        public float Depth;
        public uint Rate;
    }

    public struct RandomCmdParam
    {
        public float Upper;
        public float Lower;
    }

    public struct ExternalAudioInfo
    {
        public ushort BankNumber;
        public short Index;
        public short[] RandomIndices;

        public ExternalAudioInfo( LuminaBinaryReader binaryReader )
        {
            BankNumber = binaryReader.ReadUInt16();
            Index = binaryReader.ReadInt16();
            RandomIndices = Index < 0 ? binaryReader.ReadInt16Array( -Index ) : Array.Empty< short >();
        }
    }

    public struct TrackChannelZeroOneParamHeader
    {
        public sbyte Version;
        public sbyte Reserved;
        public short HeaderSize;
        public short NumChannels;
    }

    public struct TrackZeroOneParamHeader
    {
        public sbyte Version;
        public sbyte Reserved;
        public short HeaderSize;
        public short NumPoints;
    }

    public struct TrackZeroOnePoint
    {
        public ushort ZeroOne;
        public ushort Value;
    }

    #region Track helper structs

    public struct ModulationDepth
    {
        public uint Carrier;
        public float Depth;
        public int FadeTime;
    }

    public struct ModulationSpeed
    {
        public uint Carrier;
        public uint Speed;
        public int FadeTime;
    }

    public struct AutoAdsrEnvelope
    {
        public uint AttackTime;
        public uint DecayTime;
        public float SustainLevel;
        public uint ReleaseTime;
    }

    public struct TrackFilter
    {
        public FilterType Type;
        public float Frequency;
        public float InvQ;
        public float Gain;
    }

    public struct TrackConfig
    {
        public TrackCmdConfigType Type;
        public ushort Count;
        public object Data;
    }

    public struct TrackUnknown64Header
    {
        public sbyte Version;
        public sbyte Count;
        public ushort Unknown;
    }

    public unsafe struct TrackUnknown64
    {
        public ushort BankNumber;
        public ushort Index;
        public fixed byte Unknown[4];
        public float UnknownFloat;
    }

    #endregion
}
