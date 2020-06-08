using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GcArmyExpeditionMemberBonus", columnHash: 0xde74b4c4 )]
    public class GcArmyExpeditionMemberBonus : IExcelRow
    {
        
        public LazyRow< Race > Race;
        public LazyRow< ClassJob > ClassJob;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Race = new LazyRow< Race >( lumina, parser.ReadColumn< byte >( 0 ) );
            ClassJob = new LazyRow< ClassJob >( lumina, parser.ReadColumn< byte >( 1 ) );
        }
    }
}