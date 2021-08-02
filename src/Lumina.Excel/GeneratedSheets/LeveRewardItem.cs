// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LeveRewardItem", columnHash: 0x00035bbe )]
    public partial class LeveRewardItem : ExcelRow
    {
        public class LeveRewardItemUnkData0Obj
        {
            public ushort LeveRewardItemGroup { get; set; }
            public byte ProbabilityPct { get; set; }
        }
        
        public LeveRewardItemUnkData0Obj[] UnkData0 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            UnkData0 = new LeveRewardItemUnkData0Obj[ 8 ];
            for( var i = 0; i < 8; i++ )
            {
                UnkData0[ i ] = new LeveRewardItemUnkData0Obj();
                UnkData0[ i ].LeveRewardItemGroup = parser.ReadColumn< ushort >( 0 + ( i * 2 + 0 ) );
                UnkData0[ i ].ProbabilityPct = parser.ReadColumn< byte >( 0 + ( i * 2 + 1 ) );
            }
        }
    }
}