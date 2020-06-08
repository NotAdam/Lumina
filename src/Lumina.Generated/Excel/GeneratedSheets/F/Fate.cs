using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Fate", columnHash: 0x22c39fbf )]
    public class Fate : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 29 offset: 0000
        public string Name;

        // col: 30 offset: 0004
        public string Description;

        // col: 31 offset: 0008
        public string Objective;

        // col: 32 offset: 000c
        public string[] StatusText;

        // col: 35 offset: 0018
        public uint ArrayIndex;

        // col: 36 offset: 001c
        public uint unknown1c;

        // col: 37 offset: 0020
        public uint ReqEventItem;

        // col: 38 offset: 0024
        public uint TurnInEventItem;

        // col: 39 offset: 0028
        public ushort[] ObjectiveIcon;

        // col: 03 offset: 0038
        public uint Location;

        // col: 06 offset: 003c
        public uint EventItem;

        // col: 10 offset: 0040
        public uint IconObjective;

        // col: 11 offset: 0044
        public uint IconMap;

        // col: 12 offset: 0048
        public uint IconInactiveMap;

        // col: 14 offset: 004c
        public uint LGBGuardNPCLocation;

        // col: 26 offset: 0050
        public uint FATEChain;

        // col: 13 offset: 0054
        public int Music;

        // col: 02 offset: 0058
        public ushort FateRuleEx;

        // col: 15 offset: 005a
        public ushort ScreenImageAccept;

        // col: 16 offset: 005c
        public ushort ScreenImageComplete;

        // col: 17 offset: 005e
        public ushort ScreenImageFailed;

        // col: 21 offset: 0060
        public ushort GivenStatus;

        // col: 22 offset: 0062
        public ushort unknown62;

        // col: 28 offset: 0064
        public ushort unknown64;

        // col: 00 offset: 0066
        public byte EurekaFate;

        // col: 01 offset: 0067
        public byte Rule;

        // col: 04 offset: 0068
        public byte ClassJobLevel;

        // col: 05 offset: 0069
        public byte ClassJobLevelMax;

        // col: 07 offset: 006a
        public byte[] TypeToDoValue;

        // col: 27 offset: 006d
        public byte unknown6d;

        // col: 18 offset: 006e
        public bool HasWorldMapIcon;
        public byte packed6e;
        public bool IsQuest;
        public bool SpecialFate;
        public bool AdventEvent;
        public bool MoonFaireEvent;
        public bool packed6e_20;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 29 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 30 offset: 0004
            Description = parser.ReadOffset< string >( 0x4 );

            // col: 31 offset: 0008
            Objective = parser.ReadOffset< string >( 0x8 );

            // col: 32 offset: 000c
            StatusText = new string[3];
            StatusText[0] = parser.ReadOffset< string >( 0xc );
            StatusText[1] = parser.ReadOffset< string >( 0x10 );
            StatusText[2] = parser.ReadOffset< string >( 0x14 );

            // col: 35 offset: 0018
            ArrayIndex = parser.ReadOffset< uint >( 0x18 );

            // col: 36 offset: 001c
            unknown1c = parser.ReadOffset< uint >( 0x1c );

            // col: 37 offset: 0020
            ReqEventItem = parser.ReadOffset< uint >( 0x20 );

            // col: 38 offset: 0024
            TurnInEventItem = parser.ReadOffset< uint >( 0x24 );

            // col: 39 offset: 0028
            ObjectiveIcon = new ushort[8];
            ObjectiveIcon[0] = parser.ReadOffset< ushort >( 0x28 );
            ObjectiveIcon[1] = parser.ReadOffset< ushort >( 0x2a );
            ObjectiveIcon[2] = parser.ReadOffset< ushort >( 0x2c );
            ObjectiveIcon[3] = parser.ReadOffset< ushort >( 0x2e );
            ObjectiveIcon[4] = parser.ReadOffset< ushort >( 0x30 );
            ObjectiveIcon[5] = parser.ReadOffset< ushort >( 0x32 );
            ObjectiveIcon[6] = parser.ReadOffset< ushort >( 0x34 );
            ObjectiveIcon[7] = parser.ReadOffset< ushort >( 0x36 );

            // col: 3 offset: 0038
            Location = parser.ReadOffset< uint >( 0x38 );

            // col: 6 offset: 003c
            EventItem = parser.ReadOffset< uint >( 0x3c );

            // col: 10 offset: 0040
            IconObjective = parser.ReadOffset< uint >( 0x40 );

            // col: 11 offset: 0044
            IconMap = parser.ReadOffset< uint >( 0x44 );

            // col: 12 offset: 0048
            IconInactiveMap = parser.ReadOffset< uint >( 0x48 );

            // col: 14 offset: 004c
            LGBGuardNPCLocation = parser.ReadOffset< uint >( 0x4c );

            // col: 26 offset: 0050
            FATEChain = parser.ReadOffset< uint >( 0x50 );

            // col: 13 offset: 0054
            Music = parser.ReadOffset< int >( 0x54 );

            // col: 2 offset: 0058
            FateRuleEx = parser.ReadOffset< ushort >( 0x58 );

            // col: 15 offset: 005a
            ScreenImageAccept = parser.ReadOffset< ushort >( 0x5a );

            // col: 16 offset: 005c
            ScreenImageComplete = parser.ReadOffset< ushort >( 0x5c );

            // col: 17 offset: 005e
            ScreenImageFailed = parser.ReadOffset< ushort >( 0x5e );

            // col: 21 offset: 0060
            GivenStatus = parser.ReadOffset< ushort >( 0x60 );

            // col: 22 offset: 0062
            unknown62 = parser.ReadOffset< ushort >( 0x62 );

            // col: 28 offset: 0064
            unknown64 = parser.ReadOffset< ushort >( 0x64 );

            // col: 0 offset: 0066
            EurekaFate = parser.ReadOffset< byte >( 0x66 );

            // col: 1 offset: 0067
            Rule = parser.ReadOffset< byte >( 0x67 );

            // col: 4 offset: 0068
            ClassJobLevel = parser.ReadOffset< byte >( 0x68 );

            // col: 5 offset: 0069
            ClassJobLevelMax = parser.ReadOffset< byte >( 0x69 );

            // col: 7 offset: 006a
            TypeToDoValue = new byte[3];
            TypeToDoValue[0] = parser.ReadOffset< byte >( 0x6a );
            TypeToDoValue[1] = parser.ReadOffset< byte >( 0x6b );
            TypeToDoValue[2] = parser.ReadOffset< byte >( 0x6c );

            // col: 27 offset: 006d
            unknown6d = parser.ReadOffset< byte >( 0x6d );

            // col: 18 offset: 006e
            packed6e = parser.ReadOffset< byte >( 0x6e, ExcelColumnDataType.UInt8 );

            HasWorldMapIcon = ( packed6e & 0x1 ) == 0x1;
            IsQuest = ( packed6e & 0x2 ) == 0x2;
            SpecialFate = ( packed6e & 0x4 ) == 0x4;
            AdventEvent = ( packed6e & 0x8 ) == 0x8;
            MoonFaireEvent = ( packed6e & 0x10 ) == 0x10;
            packed6e_20 = ( packed6e & 0x20 ) == 0x20;


        }
    }
}