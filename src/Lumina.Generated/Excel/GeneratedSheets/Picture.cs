using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Picture", columnHash: 0xfaedad07 )]
    public class Picture : IExcelRow
    {
        
        public LazyRow< Item > Item;
        public int Image;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Item = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 0 ) );
            Image = parser.ReadColumn< int >( 1 );
        }
    }
}