using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Guide", columnHash: 0x2020acf6 )]
    public class Guide : IExcelRow
    {
        
        public LazyRow< GuideTitle > GuideTitle;
        public LazyRow< GuidePage > GuidePage;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            GuideTitle = new LazyRow< GuideTitle >( lumina, parser.ReadColumn< ushort >( 0 ) );
            GuidePage = new LazyRow< GuidePage >( lumina, parser.ReadColumn< ushort >( 1 ) );
        }
    }
}