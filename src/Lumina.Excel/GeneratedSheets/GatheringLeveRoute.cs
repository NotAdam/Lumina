// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringLeveRoute", columnHash: 0xf20ec1e1 )]
    public partial class GatheringLeveRoute : ExcelRow
    {
        public class GatheringLeveRouteUnkData0Obj
        {
            public int GatheringPoint { get; set; }
            public int PopRange { get; set; }
        }
        
        public GatheringLeveRouteUnkData0Obj[] UnkData0 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            UnkData0 = new GatheringLeveRouteUnkData0Obj[ 12 ];
            for( var i = 0; i < 12; i++ )
            {
                UnkData0[ i ] = new GatheringLeveRouteUnkData0Obj();
                UnkData0[ i ].GatheringPoint = parser.ReadColumn< int >( 0 + ( i * 2 + 0 ) );
                UnkData0[ i ].PopRange = parser.ReadColumn< int >( 0 + ( i * 2 + 1 ) );
            }
        }
    }
}