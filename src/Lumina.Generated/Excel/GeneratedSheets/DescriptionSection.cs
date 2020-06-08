using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DescriptionSection", columnHash: 0x2020acf6 )]
    public class DescriptionSection : IExcelRow
    {
        
        public LazyRow< DescriptionString > String;
        public LazyRow< DescriptionPage > Page;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            String = new LazyRow< DescriptionString >( lumina, parser.ReadColumn< ushort >( 0 ) );
            Page = new LazyRow< DescriptionPage >( lumina, parser.ReadColumn< ushort >( 1 ) );
        }
    }
}