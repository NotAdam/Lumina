using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestRedoIncompChapter", columnHash: 0xd870e208 )]
    public class QuestRedoIncompChapter : IExcelRow
    {
        
        public ushort Chapter;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Chapter = parser.ReadColumn< ushort >( 0 );
        }
    }
}