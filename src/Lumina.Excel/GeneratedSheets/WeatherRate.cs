// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeatherRate", columnHash: 0x474abce2 )]
    public class WeatherRate : ExcelRow
    {
        public class RateDefinition
        {
            public int Weather { get; set; }
            public byte Rate { get; set; }
        }
        
        public RateDefinition[] RateDefinitions { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            RateDefinitions = new RateDefinition[ 8 ];
            for( var i = 0; i < 8; i++ )
            {
                RateDefinitions[ i ] = new RateDefinition();
                RateDefinitions[ i ].Weather = parser.ReadColumn< int >( 0 + ( i * 2 + 0 ) );
                RateDefinitions[ i ].Rate = parser.ReadColumn< byte >( 0 + ( i * 2 + 1 ) );
            }
        }
    }
}