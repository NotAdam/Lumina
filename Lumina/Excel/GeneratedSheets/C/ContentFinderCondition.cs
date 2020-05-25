using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentFinderCondition", columnHash: 0xcf653092 )]
    public class ContentFinderCondition : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 35 offset: 0000
        public string Name;

        // col: 43 offset: 0004
        public bool LevelingRoulette;

        // col: 44 offset: 0005
        public bool Level5060Roulette;

        // col: 45 offset: 0006
        public bool MSQRoulette;

        // col: 46 offset: 0007
        public bool GuildHestRoulette;

        // col: 47 offset: 0008
        public bool ExpertRoulette;

        // col: 48 offset: 0009
        public bool TrialRoulette;

        // col: 49 offset: 000a
        public bool DailyFrontlineChallenge;

        // col: 50 offset: 000b
        public bool Level70Roulette;

        // col: 51 offset: 000c
        public bool MentorRoulette;

        // col: 52 offset: 000d
        public bool unknownd;

        // col: 53 offset: 000e
        public bool unknowne;

        // col: 54 offset: 000f
        public bool unknownf;

        // col: 55 offset: 0010
        public bool unknown10;

        // col: 56 offset: 0011
        public bool unknown11;

        // col: 57 offset: 0012
        public bool AllianceRoulette;

        // col: 58 offset: 0013
        public bool unknown13;

        // col: 59 offset: 0014
        public bool NormalRaidRoulette;

        // col: 60 offset: 0015
        public bool unknown15;

        // col: 61 offset: 0016
        public bool unknown16;

        // col: 62 offset: 0017
        public bool unknown17;

        // col: 63 offset: 0018
        public bool unknown18;

        // col: 64 offset: 0019
        public bool unknown19;

        // col: 65 offset: 001a
        public bool unknown1a;

        // col: 66 offset: 001b
        public bool unknown1b;

        // col: 67 offset: 001c
        public bool unknown1c;

        // col: 68 offset: 001d
        public bool unknown1d;

        // col: 69 offset: 001e
        public bool unknown1e;

        // col: 70 offset: 001f
        public bool unknown1f;

        // col: 71 offset: 0020
        public bool unknown20;

        // col: 72 offset: 0021
        public bool unknown21;

        // col: 73 offset: 0022
        public bool unknown22;

        // col: 74 offset: 0023
        public bool unknown23;

        // col: 75 offset: 0024
        public bool unknown24;

        // col: 76 offset: 0025
        public bool unknown25;

        // col: 77 offset: 0026
        public bool unknown26;

        // col: 78 offset: 0027
        public bool unknown27;

        // col: 79 offset: 0028
        public bool unknown28;

        // col: 80 offset: 0029
        public bool unknown29;

        // col: 81 offset: 002a
        public bool unknown2a;

        // col: 00 offset: 002c
        public string ShortCode;

        // col: 06 offset: 0030
        public uint unknown30;

        // col: 07 offset: 0034
        public uint unknown34;

        // col: 13 offset: 0038
        public uint UnlockQuest;

        // col: 38 offset: 003c
        public uint Transient;

        // col: 40 offset: 0040
        public uint Image;

        // col: 41 offset: 0044
        public uint Icon;

        // col: 01 offset: 0048
        public ushort TerritoryType;

        // col: 03 offset: 004a
        public ushort Content;

        // col: 14 offset: 004c
        public ushort unknown4c;

        // col: 17 offset: 004e
        public ushort ItemLevelRequired;

        // col: 18 offset: 0050
        public ushort ItemLevelSync;

        // col: 39 offset: 0052
        public ushort SortKey;

        // col: 02 offset: 0054
        public byte ContentLinkType;

        // col: 05 offset: 0055
        public byte unknown55;

        // col: 08 offset: 0056
        public byte AcceptClassJobCategory;

        // col: 09 offset: 0057
        public byte ContentMemberType;

        // col: 10 offset: 0058
        public byte unknown58;

        // col: 11 offset: 0059
        public byte unknown59;

        // col: 12 offset: 005a
        public byte unknown5a;

        // col: 15 offset: 005b
        public byte ClassJobLevelRequired;

        // col: 16 offset: 005c
        public byte ClassJobLevelSync;

        // col: 24 offset: 005d
        public byte unknown5d;

        // col: 36 offset: 005e
        public byte ContentType;

        // col: 37 offset: 005f
        public byte TransientKey;

        // col: 42 offset: 0060
        public sbyte unknown60;

        // col: 04 offset: 0061
        public bool PvP;
        public byte packed61;
        public bool AllowUndersized;
        public bool AllowReplacement;
        public bool packed61_8;
        public bool packed61_10;
        public bool packed61_20;
        public bool packed61_40;
        public bool HighEndDuty;

        // col: 27 offset: 0062
        public bool packed62_1;
        public byte packed62;
        public bool packed62_2;
        public bool packed62_4;
        public bool DutyRecorderAllowed;
        public bool packed62_10;
        public bool packed62_20;
        public bool packed62_40;
        public bool packed62_80;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 35 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 43 offset: 0004
            LevelingRoulette = parser.ReadOffset< bool >( 0x4 );

            // col: 44 offset: 0005
            Level5060Roulette = parser.ReadOffset< bool >( 0x5 );

            // col: 45 offset: 0006
            MSQRoulette = parser.ReadOffset< bool >( 0x6 );

            // col: 46 offset: 0007
            GuildHestRoulette = parser.ReadOffset< bool >( 0x7 );

            // col: 47 offset: 0008
            ExpertRoulette = parser.ReadOffset< bool >( 0x8 );

            // col: 48 offset: 0009
            TrialRoulette = parser.ReadOffset< bool >( 0x9 );

            // col: 49 offset: 000a
            DailyFrontlineChallenge = parser.ReadOffset< bool >( 0xa );

            // col: 50 offset: 000b
            Level70Roulette = parser.ReadOffset< bool >( 0xb );

            // col: 51 offset: 000c
            MentorRoulette = parser.ReadOffset< bool >( 0xc );

            // col: 52 offset: 000d
            unknownd = parser.ReadOffset< bool >( 0xd );

            // col: 53 offset: 000e
            unknowne = parser.ReadOffset< bool >( 0xe );

            // col: 54 offset: 000f
            unknownf = parser.ReadOffset< bool >( 0xf );

            // col: 55 offset: 0010
            unknown10 = parser.ReadOffset< bool >( 0x10 );

            // col: 56 offset: 0011
            unknown11 = parser.ReadOffset< bool >( 0x11 );

            // col: 57 offset: 0012
            AllianceRoulette = parser.ReadOffset< bool >( 0x12 );

            // col: 58 offset: 0013
            unknown13 = parser.ReadOffset< bool >( 0x13 );

            // col: 59 offset: 0014
            NormalRaidRoulette = parser.ReadOffset< bool >( 0x14 );

            // col: 60 offset: 0015
            unknown15 = parser.ReadOffset< bool >( 0x15 );

            // col: 61 offset: 0016
            unknown16 = parser.ReadOffset< bool >( 0x16 );

            // col: 62 offset: 0017
            unknown17 = parser.ReadOffset< bool >( 0x17 );

            // col: 63 offset: 0018
            unknown18 = parser.ReadOffset< bool >( 0x18 );

            // col: 64 offset: 0019
            unknown19 = parser.ReadOffset< bool >( 0x19 );

            // col: 65 offset: 001a
            unknown1a = parser.ReadOffset< bool >( 0x1a );

            // col: 66 offset: 001b
            unknown1b = parser.ReadOffset< bool >( 0x1b );

            // col: 67 offset: 001c
            unknown1c = parser.ReadOffset< bool >( 0x1c );

            // col: 68 offset: 001d
            unknown1d = parser.ReadOffset< bool >( 0x1d );

            // col: 69 offset: 001e
            unknown1e = parser.ReadOffset< bool >( 0x1e );

            // col: 70 offset: 001f
            unknown1f = parser.ReadOffset< bool >( 0x1f );

            // col: 71 offset: 0020
            unknown20 = parser.ReadOffset< bool >( 0x20 );

            // col: 72 offset: 0021
            unknown21 = parser.ReadOffset< bool >( 0x21 );

            // col: 73 offset: 0022
            unknown22 = parser.ReadOffset< bool >( 0x22 );

            // col: 74 offset: 0023
            unknown23 = parser.ReadOffset< bool >( 0x23 );

            // col: 75 offset: 0024
            unknown24 = parser.ReadOffset< bool >( 0x24 );

            // col: 76 offset: 0025
            unknown25 = parser.ReadOffset< bool >( 0x25 );

            // col: 77 offset: 0026
            unknown26 = parser.ReadOffset< bool >( 0x26 );

            // col: 78 offset: 0027
            unknown27 = parser.ReadOffset< bool >( 0x27 );

            // col: 79 offset: 0028
            unknown28 = parser.ReadOffset< bool >( 0x28 );

            // col: 80 offset: 0029
            unknown29 = parser.ReadOffset< bool >( 0x29 );

            // col: 81 offset: 002a
            unknown2a = parser.ReadOffset< bool >( 0x2a );

            // col: 0 offset: 002c
            ShortCode = parser.ReadOffset< string >( 0x2c );

            // col: 6 offset: 0030
            unknown30 = parser.ReadOffset< uint >( 0x30 );

            // col: 7 offset: 0034
            unknown34 = parser.ReadOffset< uint >( 0x34 );

            // col: 13 offset: 0038
            UnlockQuest = parser.ReadOffset< uint >( 0x38 );

            // col: 38 offset: 003c
            Transient = parser.ReadOffset< uint >( 0x3c );

            // col: 40 offset: 0040
            Image = parser.ReadOffset< uint >( 0x40 );

            // col: 41 offset: 0044
            Icon = parser.ReadOffset< uint >( 0x44 );

            // col: 1 offset: 0048
            TerritoryType = parser.ReadOffset< ushort >( 0x48 );

            // col: 3 offset: 004a
            Content = parser.ReadOffset< ushort >( 0x4a );

            // col: 14 offset: 004c
            unknown4c = parser.ReadOffset< ushort >( 0x4c );

            // col: 17 offset: 004e
            ItemLevelRequired = parser.ReadOffset< ushort >( 0x4e );

            // col: 18 offset: 0050
            ItemLevelSync = parser.ReadOffset< ushort >( 0x50 );

            // col: 39 offset: 0052
            SortKey = parser.ReadOffset< ushort >( 0x52 );

            // col: 2 offset: 0054
            ContentLinkType = parser.ReadOffset< byte >( 0x54 );

            // col: 5 offset: 0055
            unknown55 = parser.ReadOffset< byte >( 0x55 );

            // col: 8 offset: 0056
            AcceptClassJobCategory = parser.ReadOffset< byte >( 0x56 );

            // col: 9 offset: 0057
            ContentMemberType = parser.ReadOffset< byte >( 0x57 );

            // col: 10 offset: 0058
            unknown58 = parser.ReadOffset< byte >( 0x58 );

            // col: 11 offset: 0059
            unknown59 = parser.ReadOffset< byte >( 0x59 );

            // col: 12 offset: 005a
            unknown5a = parser.ReadOffset< byte >( 0x5a );

            // col: 15 offset: 005b
            ClassJobLevelRequired = parser.ReadOffset< byte >( 0x5b );

            // col: 16 offset: 005c
            ClassJobLevelSync = parser.ReadOffset< byte >( 0x5c );

            // col: 24 offset: 005d
            unknown5d = parser.ReadOffset< byte >( 0x5d );

            // col: 36 offset: 005e
            ContentType = parser.ReadOffset< byte >( 0x5e );

            // col: 37 offset: 005f
            TransientKey = parser.ReadOffset< byte >( 0x5f );

            // col: 42 offset: 0060
            unknown60 = parser.ReadOffset< sbyte >( 0x60 );

            // col: 4 offset: 0061
            packed61 = parser.ReadOffset< byte >( 0x61, ExcelColumnDataType.UInt8 );

            PvP = ( packed61 & 0x1 ) == 0x1;
            AllowUndersized = ( packed61 & 0x2 ) == 0x2;
            AllowReplacement = ( packed61 & 0x4 ) == 0x4;
            packed61_8 = ( packed61 & 0x8 ) == 0x8;
            packed61_10 = ( packed61 & 0x10 ) == 0x10;
            packed61_20 = ( packed61 & 0x20 ) == 0x20;
            packed61_40 = ( packed61 & 0x40 ) == 0x40;
            HighEndDuty = ( packed61 & 0x80 ) == 0x80;

            // col: 27 offset: 0062
            packed62 = parser.ReadOffset< byte >( 0x62, ExcelColumnDataType.UInt8 );

            packed62_1 = ( packed62 & 0x1 ) == 0x1;
            packed62_2 = ( packed62 & 0x2 ) == 0x2;
            packed62_4 = ( packed62 & 0x4 ) == 0x4;
            DutyRecorderAllowed = ( packed62 & 0x8 ) == 0x8;
            packed62_10 = ( packed62 & 0x10 ) == 0x10;
            packed62_20 = ( packed62 & 0x20 ) == 0x20;
            packed62_40 = ( packed62 & 0x40 ) == 0x40;
            packed62_80 = ( packed62 & 0x80 ) == 0x80;


        }
    }
}