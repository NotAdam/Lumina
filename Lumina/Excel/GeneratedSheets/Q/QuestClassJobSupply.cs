using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestClassJobSupply", columnHash: 0xdd620f3e )]
    public class QuestClassJobSupply : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 02 offset: 0000
        public uint ENpcResident;

        // col: 03 offset: 0004
        public uint Item;

        // col: 00 offset: 0008
        public byte ClassJobCategory;

        // col: 01 offset: 0009
        public byte unknown9;

        // col: 04 offset: 000a
        public byte unknowna;

        // col: 05 offset: 000b
        private byte packedb;
        public bool packedb_1 => ( packedb & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            ENpcResident = parser.ReadOffset< uint >( 0x0 );

            // col: 3 offset: 0004
            Item = parser.ReadOffset< uint >( 0x4 );

            // col: 0 offset: 0008
            ClassJobCategory = parser.ReadOffset< byte >( 0x8 );

            // col: 1 offset: 0009
            unknown9 = parser.ReadOffset< byte >( 0x9 );

            // col: 4 offset: 000a
            unknowna = parser.ReadOffset< byte >( 0xa );

            // col: 5 offset: 000b
            packedb = parser.ReadOffset< byte >( 0xb, ExcelColumnDataType.UInt8 );


        }
    }
}