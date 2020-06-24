using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDSharedGroup", columnHash: 0x5a516458 )]
    public class HWDSharedGroup : IExcelRow
    {
        
        public uint LGB;
        public LazyRow< HWDSharedGroupControlParam > Param;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            LGB = parser.ReadColumn< uint >( 0 );
            Param = new LazyRow< HWDSharedGroupControlParam >( lumina, parser.ReadColumn< byte >( 1 ), language );
        }
    }
}