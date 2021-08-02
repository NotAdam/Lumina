// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LeveRewardItemGroup", columnHash: 0xf065e622 )]
    public partial class LeveRewardItemGroup : ExcelRow
    {
        public class LeveRewardItemGroupUnkData0Obj
        {
            public int Item { get; set; }
            public byte Count { get; set; }
            public bool HQ { get; set; }
        }
        
        public LeveRewardItemGroupUnkData0Obj[] UnkData0 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            UnkData0 = new LeveRewardItemGroupUnkData0Obj[ 9 ];
            for( var i = 0; i < 9; i++ )
            {
                UnkData0[ i ] = new LeveRewardItemGroupUnkData0Obj();
                UnkData0[ i ].Item = parser.ReadColumn< int >( 0 + ( i * 3 + 0 ) );
                UnkData0[ i ].Count = parser.ReadColumn< byte >( 0 + ( i * 3 + 1 ) );
                UnkData0[ i ].HQ = parser.ReadColumn< bool >( 0 + ( i * 3 + 2 ) );
            }
        }
    }
}