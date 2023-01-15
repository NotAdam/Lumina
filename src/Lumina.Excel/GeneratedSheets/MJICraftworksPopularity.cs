// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJICraftworksPopularity", columnHash: 0xd6b37dbc )]
    public partial class MJICraftworksPopularity : ExcelRow
    {
        
        public LazyRow< MJICraftworksPopularityType >[] Popularity { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Popularity = new LazyRow< MJICraftworksPopularityType >[ 71 ];
            for( var i = 0; i < 71; i++ )
                Popularity[ i ] = new LazyRow< MJICraftworksPopularityType >( gameData, parser.ReadColumn< byte >( 0 + i ), language );
        }
    }
}