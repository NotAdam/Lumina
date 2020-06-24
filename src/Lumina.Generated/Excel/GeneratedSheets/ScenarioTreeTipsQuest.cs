using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ScenarioTreeTipsQuest", columnHash: 0xdbf43666 )]
    public class ScenarioTreeTipsQuest : IExcelRow
    {
        
        public LazyRow< Level > Level;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Level = new LazyRow< Level >( lumina, parser.ReadColumn< uint >( 0 ), language );
        }
    }
}