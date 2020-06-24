using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LegacyQuest", columnHash: 0x6624322e )]
    public class LegacyQuest : IExcelRow
    {
        
        public ushort LegacyQuestID;
        public string Text;
        public string String;
        public ushort SortKey;
        public byte Genre;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            LegacyQuestID = parser.ReadColumn< ushort >( 0 );
            Text = parser.ReadColumn< string >( 1 );
            String = parser.ReadColumn< string >( 2 );
            SortKey = parser.ReadColumn< ushort >( 3 );
            Genre = parser.ReadColumn< byte >( 4 );
        }
    }
}