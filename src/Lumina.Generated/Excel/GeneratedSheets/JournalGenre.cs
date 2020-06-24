using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "JournalGenre", columnHash: 0x2c6b75bb )]
    public class JournalGenre : IExcelRow
    {
        
        public int Icon;
        public LazyRow< JournalCategory > JournalCategory;
        public bool Unknown2;
        public string Name;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Icon = parser.ReadColumn< int >( 0 );
            JournalCategory = new LazyRow< JournalCategory >( lumina, parser.ReadColumn< byte >( 1 ), language );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Name = parser.ReadColumn< string >( 3 );
        }
    }
}