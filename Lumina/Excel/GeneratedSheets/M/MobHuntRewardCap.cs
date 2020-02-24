using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MobHuntRewardCap", columnHash: 0xdbf43666 )]
    public class MobHuntRewardCap : IExcelRow
    {
        // column defs from Tue, 29 Oct 2019 18:50:18 GMT


        // col: 00 offset: 0000
        public uint ExpCap;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            ExpCap = parser.ReadOffset< uint >( 0x0 );


        }
    }
}