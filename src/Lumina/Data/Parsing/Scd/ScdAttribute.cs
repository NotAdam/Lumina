using System;

#pragma warning disable CS1591

namespace Lumina.Data.Parsing.Scd
{
    public static class ScdAttribute
    {
        public struct AttributeData
        {
            [Flags]
            public enum ConditionType1st : byte
            {
                Attr = 0x01,
                Label = 0x02,
                Equal = 0x04,
                Bank = 0x08,
                ExternalId1st = 0x10
            }

            public enum ConditionType2nd : byte
            {
                None = 0x00,
                Frame = 0x01,
                Volume = 0x02,
                Pan = 0x03,
                Count = 0x04,
                Priority = 0x05,
                ExternalId = 0x06,
                TypeMask = 0x0F,
                GE = 0x00,
                GT = 0x10,
                LT = 0x20,
                LE = 0x30,
                EQ = 0x40,
                NE = 0x50,
                CondMask = 0xF0
            }

            public enum JoinType : byte
            {
                And,
                Or
            }

            public enum SelfCommand : byte
            {
                None,
                FadeIn,
                ChgPriority,
                FreezePan,
                Stay,
                ChgPan,
                BanRear,
                NoPlay,
                ChgDepth,
                MonoSpeaker,
                ChgVolume,
                ChgBusNo,
                ChgBusVolume
            }

            public enum TargetCommand : byte
            {
                None,
                Stop,
                ChgPriority,
                FadeOut,
                ChgPitch,
                PriorityStop,
                ChgPan,
                ChgVolume,
                OldStop,
                BanRear,
                ChgDepth,
                ChgBusNo,
                LowExternalIdOldStop,
                MinVolumeStop
            }

            public unsafe struct ResultCommand
            {
                public SelfCommand Self;
                public TargetCommand Target;
                private fixed byte _padding3[2];
                public uint SelfArgument;
                public uint TargetArgument;
            }

            public struct ExtendCondition
            {
                public ConditionType1st Condition1;
                public ConditionType2nd Condition2;
                public JoinType Join;
                public byte NumOfCond;
                public uint SelfArgument;
                public uint TargetArgument;
            }

            public struct ExtendData
            {
                public ExtendCondition Condition;
                public ResultCommand Result;
            }

            public byte Version;
            private byte _padding1;
            public ushort AttributeId;
            public ushort SearchAttributeId;
            public byte Condition1st;
            public byte ArgCount;
            public uint SoundLabelLo;
            public uint SoundLabelHi;
            public ResultCommand Result1st;
            public ExtendData[] Extend;

            public AttributeData( LuminaBinaryReader binaryReader )
            {
                Version = binaryReader.ReadByte();
                _padding1 = binaryReader.ReadByte();
                AttributeId = binaryReader.ReadUInt16();
                SearchAttributeId = binaryReader.ReadUInt16();
                Condition1st = binaryReader.ReadByte();
                ArgCount = binaryReader.ReadByte();
                SoundLabelLo = binaryReader.ReadUInt32();
                SoundLabelHi = binaryReader.ReadUInt32();
                Result1st = binaryReader.ReadStructure< ResultCommand >();
                Extend = binaryReader.ReadStructuresAsArray< ExtendData >( 4 );
            }
        }
    }
}
