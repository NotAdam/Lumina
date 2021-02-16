// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingUnitedExterior", columnHash: 0x88a791a7 )]
    public class HousingUnitedExterior : ExcelRow
    {
        
        public byte Unknown0;
        public LazyRow< HousingExterior >[] Item;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Item = new LazyRow< HousingExterior >[ 8 ];
            for( var i = 0; i < 8; i++ )
                Item[ i ] = new LazyRow< HousingExterior >( gameData, parser.ReadColumn< uint >( 1 + i ), language );
        }
    }
}