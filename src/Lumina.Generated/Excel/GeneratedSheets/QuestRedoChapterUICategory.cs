using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestRedoChapterUICategory", columnHash: 0x5eb59ccb )]
    public class QuestRedoChapterUICategory : IExcelRow
    {
        
        public byte Unknown0;
        public string Expac;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Expac = parser.ReadColumn< string >( 1 );
        }
    }
}