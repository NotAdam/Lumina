// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDLevelChangeDeception", columnHash: 0xda365c51 )]
    public class HWDLevelChangeDeception : IExcelRow
    {
        
        public LazyRow< ScreenImage > Image;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Image = new LazyRow< ScreenImage >( lumina, parser.ReadColumn< int >( 0 ), language );
        }
    }
}