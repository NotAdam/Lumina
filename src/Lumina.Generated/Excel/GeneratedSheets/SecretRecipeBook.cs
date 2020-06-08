using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SecretRecipeBook", columnHash: 0x0c8db36c )]
    public class SecretRecipeBook : IExcelRow
    {
        
        public LazyRow< Item > Item;
        public string Name;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Item = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 0 ) );
            Name = parser.ReadColumn< string >( 1 );
        }
    }
}