// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDRoute", columnHash: 0x9a3e7720 )]
    public partial class IKDRoute : ExcelRow
    {
        public class IKDRouteUnkData0Obj
        {
            public uint Spot { get; set; }
            public byte Time { get; set; }
        }
        
        public IKDRouteUnkData0Obj[] UnkData0 { get; set; }
        public uint Image { get; set; }
        public LazyRow< TerritoryType > TerritoryType { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            UnkData0 = new IKDRouteUnkData0Obj[ 3 ];
            for( var i = 0; i < 3; i++ )
            {
                UnkData0[ i ] = new IKDRouteUnkData0Obj();
                UnkData0[ i ].Spot = parser.ReadColumn< uint >( 0 + ( i * 2 + 0 ) );
                UnkData0[ i ].Time = parser.ReadColumn< byte >( 0 + ( i * 2 + 1 ) );
            }
            Image = parser.ReadColumn< uint >( 6 );
            TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadColumn< uint >( 7 ), language );
            Name = parser.ReadColumn< SeString >( 8 );
        }
    }
}