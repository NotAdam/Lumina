// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestRedoIncompChapter", columnHash: 0xd870e208 )]
    public partial class QuestRedoIncompChapter : ExcelRow
    {
        
        public ushort Chapter { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Chapter = parser.ReadColumn< ushort >( 0 );
        }
    }
}