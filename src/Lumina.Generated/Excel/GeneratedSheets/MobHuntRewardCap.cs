using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MobHuntRewardCap", columnHash: 0xdbf43666 )]
    public class MobHuntRewardCap : IExcelRow
    {
        
        public uint ExpCap;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ExpCap = parser.ReadColumn< uint >( 0 );
        }
    }
}