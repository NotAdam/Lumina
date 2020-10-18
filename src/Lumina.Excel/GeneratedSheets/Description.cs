// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Description", columnHash: 0x1933868c )]
    public class Description : IExcelRow
    {
        
        public LazyRow< Quest > Quest;
        public SeString TextLong;
        public SeString TextShort;
        public SeString TextCommentary;
        public bool Unknown4;
        public LazyRow< DescriptionSection > Section;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 0 ), language );
            TextLong = parser.ReadColumn< SeString >( 1 );
            TextShort = parser.ReadColumn< SeString >( 2 );
            TextCommentary = parser.ReadColumn< SeString >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Section = new LazyRow< DescriptionSection >( lumina, parser.ReadColumn< uint >( 5 ), language );
        }
    }
}