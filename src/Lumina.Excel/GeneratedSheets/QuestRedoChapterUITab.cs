// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestRedoChapterUITab", columnHash: 0x198356e8 )]
    public partial class QuestRedoChapterUITab : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public uint Icon1 { get; set; }
        public uint Icon2 { get; set; }
        public SeString Text { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Icon1 = parser.ReadColumn< uint >( 1 );
            Icon2 = parser.ReadColumn< uint >( 2 );
            Text = parser.ReadColumn< SeString >( 3 );
        }
    }
}