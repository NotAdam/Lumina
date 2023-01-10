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
        public byte Unknown62 { get; set; }
        public byte Unknown63 { get; set; }
        public byte Unknown64 { get; set; }
        public byte Unknown65 { get; set; }
        public byte Unknown66 { get; set; }
        public byte Unknown67 { get; set; }
        public byte Unknown68 { get; set; }
        public byte Unknown69 { get; set; }
        public byte Unknown70 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Popularity = new LazyRow< MJICraftworksPopularityType >[ 62 ];
            for( var i = 0; i < 62; i++ )
                Popularity[ i ] = new LazyRow< MJICraftworksPopularityType >( gameData, parser.ReadColumn< byte >( 0 + i ), language );
            Unknown62 = parser.ReadColumn< byte >( 62 );
            Unknown63 = parser.ReadColumn< byte >( 63 );
            Unknown64 = parser.ReadColumn< byte >( 64 );
            Unknown65 = parser.ReadColumn< byte >( 65 );
            Unknown66 = parser.ReadColumn< byte >( 66 );
            Unknown67 = parser.ReadColumn< byte >( 67 );
            Unknown68 = parser.ReadColumn< byte >( 68 );
            Unknown69 = parser.ReadColumn< byte >( 69 );
            Unknown70 = parser.ReadColumn< byte >( 70 );
        }
    }
}