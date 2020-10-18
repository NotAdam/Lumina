// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboTaxiStand", columnHash: 0x233d23d9 )]
    public class ChocoboTaxiStand : IExcelRow
    {
        
        public LazyRow< ChocoboTaxi >[] TargetLocations;
        public SeString PlaceName;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            TargetLocations = new LazyRow< ChocoboTaxi >[ 8 ];
            for( var i = 0; i < 8; i++ )
                TargetLocations[ i ] = new LazyRow< ChocoboTaxi >( lumina, parser.ReadColumn< ushort >( 0 + i ), language );
            PlaceName = parser.ReadColumn< SeString >( 8 );
        }
    }
}