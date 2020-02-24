using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentRoulette", columnHash: 0x8dd999fc )]
    public class ContentRoulette : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public string unknown4;

        // col: 02 offset: 0008
        public string Description;

        // col: 03 offset: 000c
        public string DutyType;

        // col: 05 offset: 0010
        public uint unknown10;

        // col: 14 offset: 0014
        public uint ContentRouletteRoleBonus;

        // col: 19 offset: 0018
        public uint unknown18;

        // col: 12 offset: 001c
        public ushort unknown1c;

        // col: 13 offset: 001e
        public ushort Icon;

        // col: 16 offset: 0020
        public ushort RewardTomeB;

        // col: 17 offset: 0022
        public ushort RewardTomeC;

        // col: 18 offset: 0024
        public ushort unknown24;

        // col: 20 offset: 0026
        public ushort SortKey;

        // col: 36 offset: 0028
        public ushort unknown28;

        // col: 04 offset: 002a
        public byte unknown2a;

        // col: 08 offset: 002b
        public byte unknown2b;

        // col: 10 offset: 002c
        public byte unknown2c;

        // col: 11 offset: 002d
        public byte ItemLevelRequired;

        // col: 15 offset: 002e
        public byte RewardTomeA;

        // col: 21 offset: 002f
        public byte unknown2f;

        // col: 22 offset: 0030
        public byte ContentMemberType;

        // col: 23 offset: 0031
        public byte unknown31;

        // col: 24 offset: 0032
        public byte unknown32;

        // col: 25 offset: 0033
        public byte unknown33;

        // col: 27 offset: 0034
        public byte unknown34;

        // col: 28 offset: 0035
        public byte unknown35;

        // col: 29 offset: 0036
        public byte unknown36;

        // col: 30 offset: 0037
        public byte unknown37;

        // col: 35 offset: 0038
        public byte InstanceContent;

        // col: 38 offset: 0039
        public byte unknown39;

        // col: 26 offset: 003a
        public sbyte unknown3a;

        // col: 06 offset: 003b
        private byte packed3b;
        public bool IsInDutyFinder => ( packed3b & 0x1 ) == 0x1;
        public bool OpenRule => ( packed3b & 0x2 ) == 0x2;
        public bool RequiredLevel => ( packed3b & 0x4 ) == 0x4;
        public bool packed3b_8 => ( packed3b & 0x8 ) == 0x8;
        public bool RequireAllDuties => ( packed3b & 0x10 ) == 0x10;
        public bool packed3b_20 => ( packed3b & 0x20 ) == 0x20;
        public bool ContentRouletteOpenRule => ( packed3b & 0x40 ) == 0x40;
        public bool packed3b_80 => ( packed3b & 0x80 ) == 0x80;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            unknown4 = parser.ReadOffset< string >( 0x4 );

            // col: 2 offset: 0008
            Description = parser.ReadOffset< string >( 0x8 );

            // col: 3 offset: 000c
            DutyType = parser.ReadOffset< string >( 0xc );

            // col: 5 offset: 0010
            unknown10 = parser.ReadOffset< uint >( 0x10 );

            // col: 14 offset: 0014
            ContentRouletteRoleBonus = parser.ReadOffset< uint >( 0x14 );

            // col: 19 offset: 0018
            unknown18 = parser.ReadOffset< uint >( 0x18 );

            // col: 12 offset: 001c
            unknown1c = parser.ReadOffset< ushort >( 0x1c );

            // col: 13 offset: 001e
            Icon = parser.ReadOffset< ushort >( 0x1e );

            // col: 16 offset: 0020
            RewardTomeB = parser.ReadOffset< ushort >( 0x20 );

            // col: 17 offset: 0022
            RewardTomeC = parser.ReadOffset< ushort >( 0x22 );

            // col: 18 offset: 0024
            unknown24 = parser.ReadOffset< ushort >( 0x24 );

            // col: 20 offset: 0026
            SortKey = parser.ReadOffset< ushort >( 0x26 );

            // col: 36 offset: 0028
            unknown28 = parser.ReadOffset< ushort >( 0x28 );

            // col: 4 offset: 002a
            unknown2a = parser.ReadOffset< byte >( 0x2a );

            // col: 8 offset: 002b
            unknown2b = parser.ReadOffset< byte >( 0x2b );

            // col: 10 offset: 002c
            unknown2c = parser.ReadOffset< byte >( 0x2c );

            // col: 11 offset: 002d
            ItemLevelRequired = parser.ReadOffset< byte >( 0x2d );

            // col: 15 offset: 002e
            RewardTomeA = parser.ReadOffset< byte >( 0x2e );

            // col: 21 offset: 002f
            unknown2f = parser.ReadOffset< byte >( 0x2f );

            // col: 22 offset: 0030
            ContentMemberType = parser.ReadOffset< byte >( 0x30 );

            // col: 23 offset: 0031
            unknown31 = parser.ReadOffset< byte >( 0x31 );

            // col: 24 offset: 0032
            unknown32 = parser.ReadOffset< byte >( 0x32 );

            // col: 25 offset: 0033
            unknown33 = parser.ReadOffset< byte >( 0x33 );

            // col: 27 offset: 0034
            unknown34 = parser.ReadOffset< byte >( 0x34 );

            // col: 28 offset: 0035
            unknown35 = parser.ReadOffset< byte >( 0x35 );

            // col: 29 offset: 0036
            unknown36 = parser.ReadOffset< byte >( 0x36 );

            // col: 30 offset: 0037
            unknown37 = parser.ReadOffset< byte >( 0x37 );

            // col: 35 offset: 0038
            InstanceContent = parser.ReadOffset< byte >( 0x38 );

            // col: 38 offset: 0039
            unknown39 = parser.ReadOffset< byte >( 0x39 );

            // col: 26 offset: 003a
            unknown3a = parser.ReadOffset< sbyte >( 0x3a );

            // col: 6 offset: 003b
            packed3b = parser.ReadOffset< byte >( 0x3b, ExcelColumnDataType.UInt8 );


        }
    }
}