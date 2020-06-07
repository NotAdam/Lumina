using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GCScripShopItem", columnHash: 0x6c3dae69 )]
    public class GCScripShopItem : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 02 offset: 0000
        public uint CostGCSeals;

        // col: 00 offset: 0004
        public int Item;

        // col: 01 offset: 0008
        public int RequiredGrandCompanyRank;

        // col: 03 offset: 000c
        public byte SortKey;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            CostGCSeals = parser.ReadOffset< uint >( 0x0 );

            // col: 0 offset: 0004
            Item = parser.ReadOffset< int >( 0x4 );

            // col: 1 offset: 0008
            RequiredGrandCompanyRank = parser.ReadOffset< int >( 0x8 );

            // col: 3 offset: 000c
            SortKey = parser.ReadOffset< byte >( 0xc );


        }
    }
}