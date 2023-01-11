// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboTaxiStand", columnHash: 0x233d23d9 )]
    public partial class ChocoboTaxiStand : ExcelRow
    {
        
        public LazyRow< ChocoboTaxi >[] TargetLocations { get; set; }
        public SeString PlaceName { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            TargetLocations = new LazyRow< ChocoboTaxi >[ 8 ];
            for( var i = 0; i < 8; i++ )
                TargetLocations[ i ] = new LazyRow< ChocoboTaxi >( gameData, parser.ReadColumn< ushort >( 0 + i ), language );
            PlaceName = parser.ReadColumn< SeString >( 8 );
        }
    }
}