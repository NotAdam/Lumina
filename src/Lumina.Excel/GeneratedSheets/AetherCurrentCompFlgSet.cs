// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AetherCurrentCompFlgSet", columnHash: 0x39815af8 )]
    public partial class AetherCurrentCompFlgSet : ExcelRow
    {
        
        public LazyRow< TerritoryType > Territory { get; set; }
        public LazyRow< AetherCurrent >[] AetherCurrent { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Territory = new LazyRow< TerritoryType >( gameData, parser.ReadColumn< int >( 0 ), language );
            AetherCurrent = new LazyRow< AetherCurrent >[ 15 ];
            for( var i = 0; i < 15; i++ )
                AetherCurrent[ i ] = new LazyRow< AetherCurrent >( gameData, parser.ReadColumn< int >( 1 + i ), language );
        }
    }
}