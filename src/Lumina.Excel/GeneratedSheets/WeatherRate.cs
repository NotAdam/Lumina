// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeatherRate", columnHash: 0x474abce2 )]
    public partial class WeatherRate : ExcelRow
    {
        public class WeatherRateUnkData0Obj
        {
            public int Weather { get; set; }
            public byte Rate { get; set; }
        }
        
        public WeatherRateUnkData0Obj[] UnkData0 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            UnkData0 = new WeatherRateUnkData0Obj[ 8 ];
            for( var i = 0; i < 8; i++ )
            {
                UnkData0[ i ] = new WeatherRateUnkData0Obj();
                UnkData0[ i ].Weather = parser.ReadColumn< int >( 0 + ( i * 2 + 0 ) );
                UnkData0[ i ].Rate = parser.ReadColumn< byte >( 0 + ( i * 2 + 1 ) );
            }
        }
    }
}