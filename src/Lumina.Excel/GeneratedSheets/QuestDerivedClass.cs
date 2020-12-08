// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestDerivedClass", columnHash: 0xdcfd9eba )]
    public class QuestDerivedClass : IExcelRow
    {
        
        public LazyRow< ClassJob > ClassJob;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ClassJob = new LazyRow< ClassJob >( lumina, parser.ReadColumn< byte >( 0 ), language );
        }
    }
}