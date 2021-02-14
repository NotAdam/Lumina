// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AetherCurrentCompFlgSet", columnHash: 0xa562e4cf )]
    public class AetherCurrentCompFlgSet : ExcelRow
    {
        
        public LazyRow< TerritoryType > Territory;
        public byte Unknown1;
        public LazyRow< AetherCurrent >[] AetherCurrent;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Territory = new LazyRow< TerritoryType >( lumina, parser.ReadColumn< int >( 0 ), language );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            AetherCurrent = new LazyRow< AetherCurrent >[ 15 ];
            for( var i = 0; i < 15; i++ )
                AetherCurrent[ i ] = new LazyRow< AetherCurrent >( lumina, parser.ReadColumn< int >( 2 + i ), language );
        }
    }
}