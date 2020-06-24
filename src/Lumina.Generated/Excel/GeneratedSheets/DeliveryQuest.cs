using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeliveryQuest", columnHash: 0xda365c51 )]
    public class DeliveryQuest : IExcelRow
    {
        
        public LazyRow< Quest > Quest;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< int >( 0 ), language );
        }
    }
}