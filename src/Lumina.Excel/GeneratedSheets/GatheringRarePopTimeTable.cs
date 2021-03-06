// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringRarePopTimeTable", columnHash: 0x865de322 )]
    public class GatheringRarePopTimeTable : ExcelRow
    {
        public struct UnkStruct0Struct
        {
            public ushort StartTime;
            public ushort Durationm;
        }
        
        public UnkStruct0Struct[] UnkStruct0 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            UnkStruct0 = new UnkStruct0Struct[ 3 ];
            for( var i = 0; i < 3; i++ )
            {
                UnkStruct0[ i ] = new UnkStruct0Struct();
                UnkStruct0[ i ].StartTime = parser.ReadColumn< ushort >( 0 + ( i * 2 + 0 ) );
                UnkStruct0[ i ].Durationm = parser.ReadColumn< ushort >( 0 + ( i * 2 + 1 ) );
            }
        }
    }
}