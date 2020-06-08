using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemSearchCategory", columnHash: 0xeffa5b93 )]
    public class ItemSearchCategory : IExcelRow
    {
        
        public string Name;
        public int Icon;
        public byte Category;
        public byte Order;
        public LazyRow< ClassJob > ClassJob;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            Category = parser.ReadColumn< byte >( 2 );
            Order = parser.ReadColumn< byte >( 3 );
            ClassJob = new LazyRow< ClassJob >( lumina, parser.ReadColumn< sbyte >( 4 ) );
        }
    }
}