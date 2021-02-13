// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestRedoChapterUITab", columnHash: 0x198356e8 )]
    public class QuestRedoChapterUITab : ExcelRow
    {
        
        public byte Unknown0;
        public uint Icon1;
        public uint Icon2;
        public SeString Text;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Icon1 = parser.ReadColumn< uint >( 1 );
            Icon2 = parser.ReadColumn< uint >( 2 );
            Text = parser.ReadColumn< SeString >( 3 );
        }
    }
}