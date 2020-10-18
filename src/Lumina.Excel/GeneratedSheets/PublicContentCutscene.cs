// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PublicContentCutscene", columnHash: 0x5d58cc84 )]
    public class PublicContentCutscene : IExcelRow
    {
        
        public LazyRow< Cutscene > Cutscene;
        public LazyRow< Cutscene > Cutscene2;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Cutscene = new LazyRow< Cutscene >( lumina, parser.ReadColumn< uint >( 0 ), language );
            Cutscene2 = new LazyRow< Cutscene >( lumina, parser.ReadColumn< uint >( 1 ), language );
        }
    }
}