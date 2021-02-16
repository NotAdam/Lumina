// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LegacyQuest", columnHash: 0x6624322e )]
    public class LegacyQuest : ExcelRow
    {
        
        public ushort LegacyQuestID;
        public SeString Text;
        public SeString String;
        public ushort SortKey;
        public byte Genre;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            LegacyQuestID = parser.ReadColumn< ushort >( 0 );
            Text = parser.ReadColumn< SeString >( 1 );
            String = parser.ReadColumn< SeString >( 2 );
            SortKey = parser.ReadColumn< ushort >( 3 );
            Genre = parser.ReadColumn< byte >( 4 );
        }
    }
}