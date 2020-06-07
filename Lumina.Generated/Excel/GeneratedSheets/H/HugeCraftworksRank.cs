using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HugeCraftworksRank", columnHash: 0xf7af7ac5 )]
    public class HugeCraftworksRank : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public uint ExpRewardPerItem;

        // col: 00 offset: 0004
        public byte CrafterLevel;

        // col: 02 offset: 0005
        public byte unknown5;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            ExpRewardPerItem = parser.ReadOffset< uint >( 0x0 );

            // col: 0 offset: 0004
            CrafterLevel = parser.ReadOffset< byte >( 0x4 );

            // col: 2 offset: 0005
            unknown5 = parser.ReadOffset< byte >( 0x5 );


        }
    }
}