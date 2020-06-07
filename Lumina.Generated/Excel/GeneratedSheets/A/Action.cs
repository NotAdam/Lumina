using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Action", columnHash: 0xb3773db1 )]
    public class Action : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 47 offset: 0004
        public uint UnlockLink;

        // col: 02 offset: 0008
        public ushort Icon;

        // col: 08 offset: 000a
        public ushort ActionTimelineHit;

        // col: 32 offset: 000c
        public ushort PrimaryCostValue;

        // col: 34 offset: 000e
        public ushort SecondaryCostValue;

        // col: 35 offset: 0010
        public ushort ActionCombo;

        // col: 37 offset: 0012
        public ushort Cast100ms;

        // col: 38 offset: 0014
        public ushort Recast100ms;

        // col: 46 offset: 0016
        public ushort StatusGainSelf;

        // col: 52 offset: 0018
        public ushort Omen;

        // col: 07 offset: 001a
        public short AnimationEnd;

        // col: 03 offset: 001c
        public byte ActionCategory;

        // col: 04 offset: 001d
        public byte unknown1d;

        // col: 05 offset: 001e
        public byte AnimationStart;

        // col: 06 offset: 001f
        public byte VFX;

        // col: 09 offset: 0020
        public byte unknown20;

        // col: 11 offset: 0021
        public byte BehaviourType;

        // col: 12 offset: 0022
        public byte ClassJobLevel;

        // col: 27 offset: 0023
        public byte CastType;

        // col: 28 offset: 0024
        public byte EffectRange;

        // col: 29 offset: 0025
        public byte XAxisModifier;

        // col: 31 offset: 0026
        public byte PrimaryCostType;

        // col: 33 offset: 0027
        public byte SecondaryCostType;

        // col: 39 offset: 0028
        public byte CooldownGroup;

        // col: 40 offset: 0029
        public byte unknown29;

        // col: 41 offset: 002a
        public byte MaxCharges;

        // col: 43 offset: 002b
        public byte Aspect;

        // col: 44 offset: 002c
        public byte ActionProcStatus;

        // col: 45 offset: 002d
        public byte unknown2d;

        // col: 48 offset: 002e
        public byte ClassJobCategory;

        // col: 49 offset: 002f
        public byte unknown2f;

        // col: 62 offset: 0030
        public byte unknown30;

        // col: 10 offset: 0031
        public sbyte ClassJob;

        // col: 14 offset: 0032
        public sbyte Range;

        // col: 24 offset: 0033
        public sbyte unknown33;

        // col: 42 offset: 0034
        public sbyte AttackType;

        // col: 01 offset: 0035
        public bool packed35_1;
        public byte packed35;
        public bool IsRoleAction;
        public bool CanTargetSelf;
        public bool CanTargetParty;
        public bool CanTargetFriendly;
        public bool CanTargetHostile;
        public bool packed35_40;
        public bool packed35_80;

        // col: 21 offset: 0036
        public bool TargetArea;
        public byte packed36;
        public bool packed36_2;
        public bool packed36_4;
        public bool CanTargetDead;
        public bool packed36_10;
        public bool packed36_20;
        public bool PreservesCombo;
        public bool packed36_80;

        // col: 51 offset: 0037
        public bool AffectsPosition;
        public byte packed37;
        public bool IsPvP;
        public bool packed37_4;
        public bool packed37_8;
        public bool packed37_10;
        public bool packed37_20;
        public bool packed37_40;
        public bool packed37_80;

        // col: 60 offset: 0038
        public bool packed38_1;
        public byte packed38;
        public bool packed38_2;
        public bool packed38_4;
        public bool packed38_8;
        public bool IsPlayerAction;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 47 offset: 0004
            UnlockLink = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            Icon = parser.ReadOffset< ushort >( 0x8 );

            // col: 8 offset: 000a
            ActionTimelineHit = parser.ReadOffset< ushort >( 0xa );

            // col: 32 offset: 000c
            PrimaryCostValue = parser.ReadOffset< ushort >( 0xc );

            // col: 34 offset: 000e
            SecondaryCostValue = parser.ReadOffset< ushort >( 0xe );

            // col: 35 offset: 0010
            ActionCombo = parser.ReadOffset< ushort >( 0x10 );

            // col: 37 offset: 0012
            Cast100ms = parser.ReadOffset< ushort >( 0x12 );

            // col: 38 offset: 0014
            Recast100ms = parser.ReadOffset< ushort >( 0x14 );

            // col: 46 offset: 0016
            StatusGainSelf = parser.ReadOffset< ushort >( 0x16 );

            // col: 52 offset: 0018
            Omen = parser.ReadOffset< ushort >( 0x18 );

            // col: 7 offset: 001a
            AnimationEnd = parser.ReadOffset< short >( 0x1a );

            // col: 3 offset: 001c
            ActionCategory = parser.ReadOffset< byte >( 0x1c );

            // col: 4 offset: 001d
            unknown1d = parser.ReadOffset< byte >( 0x1d );

            // col: 5 offset: 001e
            AnimationStart = parser.ReadOffset< byte >( 0x1e );

            // col: 6 offset: 001f
            VFX = parser.ReadOffset< byte >( 0x1f );

            // col: 9 offset: 0020
            unknown20 = parser.ReadOffset< byte >( 0x20 );

            // col: 11 offset: 0021
            BehaviourType = parser.ReadOffset< byte >( 0x21 );

            // col: 12 offset: 0022
            ClassJobLevel = parser.ReadOffset< byte >( 0x22 );

            // col: 27 offset: 0023
            CastType = parser.ReadOffset< byte >( 0x23 );

            // col: 28 offset: 0024
            EffectRange = parser.ReadOffset< byte >( 0x24 );

            // col: 29 offset: 0025
            XAxisModifier = parser.ReadOffset< byte >( 0x25 );

            // col: 31 offset: 0026
            PrimaryCostType = parser.ReadOffset< byte >( 0x26 );

            // col: 33 offset: 0027
            SecondaryCostType = parser.ReadOffset< byte >( 0x27 );

            // col: 39 offset: 0028
            CooldownGroup = parser.ReadOffset< byte >( 0x28 );

            // col: 40 offset: 0029
            unknown29 = parser.ReadOffset< byte >( 0x29 );

            // col: 41 offset: 002a
            MaxCharges = parser.ReadOffset< byte >( 0x2a );

            // col: 43 offset: 002b
            Aspect = parser.ReadOffset< byte >( 0x2b );

            // col: 44 offset: 002c
            ActionProcStatus = parser.ReadOffset< byte >( 0x2c );

            // col: 45 offset: 002d
            unknown2d = parser.ReadOffset< byte >( 0x2d );

            // col: 48 offset: 002e
            ClassJobCategory = parser.ReadOffset< byte >( 0x2e );

            // col: 49 offset: 002f
            unknown2f = parser.ReadOffset< byte >( 0x2f );

            // col: 62 offset: 0030
            unknown30 = parser.ReadOffset< byte >( 0x30 );

            // col: 10 offset: 0031
            ClassJob = parser.ReadOffset< sbyte >( 0x31 );

            // col: 14 offset: 0032
            Range = parser.ReadOffset< sbyte >( 0x32 );

            // col: 24 offset: 0033
            unknown33 = parser.ReadOffset< sbyte >( 0x33 );

            // col: 42 offset: 0034
            AttackType = parser.ReadOffset< sbyte >( 0x34 );

            // col: 1 offset: 0035
            packed35 = parser.ReadOffset< byte >( 0x35, ExcelColumnDataType.UInt8 );

            packed35_1 = ( packed35 & 0x1 ) == 0x1;
            IsRoleAction = ( packed35 & 0x2 ) == 0x2;
            CanTargetSelf = ( packed35 & 0x4 ) == 0x4;
            CanTargetParty = ( packed35 & 0x8 ) == 0x8;
            CanTargetFriendly = ( packed35 & 0x10 ) == 0x10;
            CanTargetHostile = ( packed35 & 0x20 ) == 0x20;
            packed35_40 = ( packed35 & 0x40 ) == 0x40;
            packed35_80 = ( packed35 & 0x80 ) == 0x80;

            // col: 21 offset: 0036
            packed36 = parser.ReadOffset< byte >( 0x36, ExcelColumnDataType.UInt8 );

            TargetArea = ( packed36 & 0x1 ) == 0x1;
            packed36_2 = ( packed36 & 0x2 ) == 0x2;
            packed36_4 = ( packed36 & 0x4 ) == 0x4;
            CanTargetDead = ( packed36 & 0x8 ) == 0x8;
            packed36_10 = ( packed36 & 0x10 ) == 0x10;
            packed36_20 = ( packed36 & 0x20 ) == 0x20;
            PreservesCombo = ( packed36 & 0x40 ) == 0x40;
            packed36_80 = ( packed36 & 0x80 ) == 0x80;

            // col: 51 offset: 0037
            packed37 = parser.ReadOffset< byte >( 0x37, ExcelColumnDataType.UInt8 );

            AffectsPosition = ( packed37 & 0x1 ) == 0x1;
            IsPvP = ( packed37 & 0x2 ) == 0x2;
            packed37_4 = ( packed37 & 0x4 ) == 0x4;
            packed37_8 = ( packed37 & 0x8 ) == 0x8;
            packed37_10 = ( packed37 & 0x10 ) == 0x10;
            packed37_20 = ( packed37 & 0x20 ) == 0x20;
            packed37_40 = ( packed37 & 0x40 ) == 0x40;
            packed37_80 = ( packed37 & 0x80 ) == 0x80;

            // col: 60 offset: 0038
            packed38 = parser.ReadOffset< byte >( 0x38, ExcelColumnDataType.UInt8 );

            packed38_1 = ( packed38 & 0x1 ) == 0x1;
            packed38_2 = ( packed38 & 0x2 ) == 0x2;
            packed38_4 = ( packed38 & 0x4 ) == 0x4;
            packed38_8 = ( packed38 & 0x8 ) == 0x8;
            IsPlayerAction = ( packed38 & 0x10 ) == 0x10;


        }
    }
}