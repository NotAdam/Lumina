using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AozActionTransient", columnHash: 0x4921bb28 )]
    public class AozActionTransient : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 02 offset: 0000
        public string Stats;

        // col: 03 offset: 0004
        public string Description;

        // col: 01 offset: 0008
        public uint Icon;

        // col: 06 offset: 000c
        public uint StartQuest;

        // col: 07 offset: 0010
        public uint NextQuest;

        // col: 05 offset: 0014
        public ushort Location;

        // col: 00 offset: 0016
        public byte Number;

        // col: 04 offset: 0017
        public byte unknown17;

        // col: 08 offset: 0018
        public bool packed18_1;
        public byte packed18;
        public bool packed18_2;
        public bool packed18_4;
        public bool packed18_8;
        public bool packed18_10;
        public bool packed18_20;
        public bool packed18_40;
        public bool packed18_80;

        // col: 16 offset: 0019
        public bool packed19_1;
        public byte packed19;
        public bool packed19_2;
        public bool packed19_4;
        public bool packed19_8;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            Stats = parser.ReadOffset< string >( 0x0 );

            // col: 3 offset: 0004
            Description = parser.ReadOffset< string >( 0x4 );

            // col: 1 offset: 0008
            Icon = parser.ReadOffset< uint >( 0x8 );

            // col: 6 offset: 000c
            StartQuest = parser.ReadOffset< uint >( 0xc );

            // col: 7 offset: 0010
            NextQuest = parser.ReadOffset< uint >( 0x10 );

            // col: 5 offset: 0014
            Location = parser.ReadOffset< ushort >( 0x14 );

            // col: 0 offset: 0016
            Number = parser.ReadOffset< byte >( 0x16 );

            // col: 4 offset: 0017
            unknown17 = parser.ReadOffset< byte >( 0x17 );

            // col: 8 offset: 0018
            packed18 = parser.ReadOffset< byte >( 0x18, ExcelColumnDataType.UInt8 );

            packed18_1 = ( packed18 & 0x1 ) == 0x1;
            packed18_2 = ( packed18 & 0x2 ) == 0x2;
            packed18_4 = ( packed18 & 0x4 ) == 0x4;
            packed18_8 = ( packed18 & 0x8 ) == 0x8;
            packed18_10 = ( packed18 & 0x10 ) == 0x10;
            packed18_20 = ( packed18 & 0x20 ) == 0x20;
            packed18_40 = ( packed18 & 0x40 ) == 0x40;
            packed18_80 = ( packed18 & 0x80 ) == 0x80;

            // col: 16 offset: 0019
            packed19 = parser.ReadOffset< byte >( 0x19, ExcelColumnDataType.UInt8 );

            packed19_1 = ( packed19 & 0x1 ) == 0x1;
            packed19_2 = ( packed19 & 0x2 ) == 0x2;
            packed19_4 = ( packed19 & 0x4 ) == 0x4;
            packed19_8 = ( packed19 & 0x8 ) == 0x8;


        }
    }
}