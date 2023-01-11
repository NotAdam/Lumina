// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestChapter", columnHash: 0x5edc18ea )]
    public partial class QuestChapter : ExcelRow
    {
        
        public LazyRow< Quest > Quest { get; set; }
        public ushort Redo { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Redo = parser.ReadColumn< ushort >( 1 );
        }
    }
}