using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentMemberType", columnHash: 0x48587c6d )]
    public class ContentMemberType : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public byte unknown0;

        // col: 04 offset: 0001
        public byte unknown1;

        // col: 05 offset: 0002
        public byte unknown2;

        // col: 06 offset: 0003
        public byte unknown3;

        // col: 07 offset: 0004
        public byte unknown4;

        // col: 08 offset: 0005
        public byte unknown5;

        // col: 09 offset: 0006
        public byte TanksPerParty;

        // col: 10 offset: 0007
        public byte HealersPerParty;

        // col: 11 offset: 0008
        public byte MeleesPerParty;

        // col: 12 offset: 0009
        public byte RangedPerParty;

        // col: 00 offset: 000a
        public bool packeda_1;
        public byte packeda;
        public bool packeda_2;
        public bool packeda_4;
        public bool packeda_8;
        public bool packeda_10;
        public bool packeda_20;
        public bool packeda_40;
        public bool packeda_80;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            unknown0 = parser.ReadOffset< byte >( 0x0 );

            // col: 4 offset: 0001
            unknown1 = parser.ReadOffset< byte >( 0x1 );

            // col: 5 offset: 0002
            unknown2 = parser.ReadOffset< byte >( 0x2 );

            // col: 6 offset: 0003
            unknown3 = parser.ReadOffset< byte >( 0x3 );

            // col: 7 offset: 0004
            unknown4 = parser.ReadOffset< byte >( 0x4 );

            // col: 8 offset: 0005
            unknown5 = parser.ReadOffset< byte >( 0x5 );

            // col: 9 offset: 0006
            TanksPerParty = parser.ReadOffset< byte >( 0x6 );

            // col: 10 offset: 0007
            HealersPerParty = parser.ReadOffset< byte >( 0x7 );

            // col: 11 offset: 0008
            MeleesPerParty = parser.ReadOffset< byte >( 0x8 );

            // col: 12 offset: 0009
            RangedPerParty = parser.ReadOffset< byte >( 0x9 );

            // col: 0 offset: 000a
            packeda = parser.ReadOffset< byte >( 0xa, ExcelColumnDataType.UInt8 );

            packeda_1 = ( packeda & 0x1 ) == 0x1;
            packeda_2 = ( packeda & 0x2 ) == 0x2;
            packeda_4 = ( packeda & 0x4 ) == 0x4;
            packeda_8 = ( packeda & 0x8 ) == 0x8;
            packeda_10 = ( packeda & 0x10 ) == 0x10;
            packeda_20 = ( packeda & 0x20 ) == 0x20;
            packeda_40 = ( packeda & 0x40 ) == 0x40;
            packeda_80 = ( packeda & 0x80 ) == 0x80;


        }
    }
}