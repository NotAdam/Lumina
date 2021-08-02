// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringLeveRoute", columnHash: 0xf20ec1e1 )]
    public class GatheringLeveRoute : ExcelRow
    {
        public class GatheringLeveRoutePoint
        {
            public int GatheringPoint { get; set; }
            public int PopRange { get; set; }
        }
        
        public GatheringLeveRoutePoint[] RoutePoints { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            RoutePoints = new GatheringLeveRoutePoint[ 12 ];
            for( var i = 0; i < 12; i++ )
            {
                RoutePoints[ i ] = new GatheringLeveRoutePoint();
                RoutePoints[ i ].GatheringPoint = parser.ReadColumn< int >( 0 + ( i * 2 + 0 ) );
                RoutePoints[ i ].PopRange = parser.ReadColumn< int >( 0 + ( i * 2 + 1 ) );
            }
        }
    }
}