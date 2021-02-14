// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestRedoIncompChapter", columnHash: 0xd870e208 )]
    public class QuestRedoIncompChapter : ExcelRow
    {
        
        public ushort Chapter;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Chapter = parser.ReadColumn< ushort >( 0 );
        }
    }
}