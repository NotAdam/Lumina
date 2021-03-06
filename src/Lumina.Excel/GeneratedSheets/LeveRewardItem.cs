// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LeveRewardItem", columnHash: 0x00035bbe )]
    public class LeveRewardItem : ExcelRow
    {
        public struct UnkStruct0Struct
        {
            public ushort LeveRewardItemGroup;
            public byte ProbabilityPct;
        }
        
        public UnkStruct0Struct[] UnkStruct0 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            UnkStruct0 = new UnkStruct0Struct[ 8 ];
            for( var i = 0; i < 8; i++ )
            {
                UnkStruct0[ i ] = new UnkStruct0Struct();
                UnkStruct0[ i ].LeveRewardItemGroup = parser.ReadColumn< ushort >( 0 + ( i * 2 + 0 ) );
                UnkStruct0[ i ].ProbabilityPct = parser.ReadColumn< byte >( 0 + ( i * 2 + 1 ) );
            }
        }
    }
}