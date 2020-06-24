using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "JournalCategory", columnHash: 0xc5670d26 )]
    public class JournalCategory : IExcelRow
    {
        
        public string Name;
        public byte SeparateType;
        public byte DataType;
        public LazyRow< JournalSection > JournalSection;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            SeparateType = parser.ReadColumn< byte >( 1 );
            DataType = parser.ReadColumn< byte >( 2 );
            JournalSection = new LazyRow< JournalSection >( lumina, parser.ReadColumn< byte >( 3 ), language );
        }
    }
}