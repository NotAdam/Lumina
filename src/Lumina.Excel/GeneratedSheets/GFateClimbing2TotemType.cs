// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GFateClimbing2TotemType", columnHash: 0xdbf43666 )]
    public class GFateClimbing2TotemType : IExcelRow
    {
        
        public LazyRow< PublicContentTextData > PublicContentTextData;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            PublicContentTextData = new LazyRow< PublicContentTextData >( lumina, parser.ReadColumn< uint >( 0 ), language );
        }
    }
}