// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestChapter", columnHash: 0x5edc18ea )]
    public class QuestChapter : ExcelRow
    {
        
        public LazyRow< Quest > Quest;
        public ushort Redo;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 0 ), language );
            Redo = parser.ReadColumn< ushort >( 1 );
        }
    }
}