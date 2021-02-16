// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringLeveRoute", columnHash: 0xf20ec1e1 )]
    public class GatheringLeveRoute : ExcelRow
    {
        public struct UnkStruct0Struct
        {
            public int GatheringPoint;
            public int PopRange;
        }
        
        public UnkStruct0Struct[] UnkStruct0;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            UnkStruct0 = new UnkStruct0Struct[ 12 ];
            for( var i = 0; i < 12; i++ )
            {
                UnkStruct0[ i ] = new UnkStruct0Struct();
                UnkStruct0[ i ].GatheringPoint = parser.ReadColumn< int >( 0 + ( i * 2 + 0 ) );
                UnkStruct0[ i ].PopRange = parser.ReadColumn< int >( 0 + ( i * 2 + 1 ) );
            }
        }
    }
}