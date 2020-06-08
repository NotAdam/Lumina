using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingUnitedExterior", columnHash: 0x88a791a7 )]
    public class HousingUnitedExterior : IExcelRow
    {
        
        public byte Unknown0;
        public LazyRow< HousingExterior >[] Item;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            for( var i = 0; i < 8; i++ )
                Item[ i ] = new LazyRow< HousingExterior >( lumina, parser.ReadColumn< uint >( 1 + i ) );
        }
    }
}