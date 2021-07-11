// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringRarePopTimeTable", columnHash: 0x865de322 )]
    public class GatheringRarePopTimeTable : ExcelRow
    {
        public class UnkData0Obj
        {
            public ushort StartTime { get; set; }
            public ushort Durationm { get; set; }
        }
        
        public UnkData0Obj[] UnkData0 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            UnkData0 = new UnkData0Obj[ 3 ];
            for( var i = 0; i < 3; i++ )
            {
                UnkData0[ i ] = new UnkData0Obj();
                UnkData0[ i ].StartTime = parser.ReadColumn< ushort >( 0 + ( i * 2 + 0 ) );
                UnkData0[ i ].Durationm = parser.ReadColumn< ushort >( 0 + ( i * 2 + 1 ) );
            }
        }
    }
}