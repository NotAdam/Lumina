using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDFishParam", columnHash: 0x5a516458 )]
    public class IKDFishParam : IExcelRow
    {
        
        public LazyRow< FishParameter > Fish;
        public LazyRow< IKDContentBonus > IKDContentBonus;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Fish = new LazyRow< FishParameter >( lumina, parser.ReadColumn< uint >( 0 ) );
            IKDContentBonus = new LazyRow< IKDContentBonus >( lumina, parser.ReadColumn< byte >( 1 ) );
        }
    }
}