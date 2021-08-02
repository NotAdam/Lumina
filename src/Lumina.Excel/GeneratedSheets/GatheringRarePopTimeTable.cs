// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringRarePopTimeTable", columnHash: 0x865de322 )]
    public class GatheringRarePopTimeTable : ExcelRow
    {
        public class GatheringRarePop
        {
            public ushort StartTime { get; set; }
            public ushort Duration { get; set; }
        }
        
        public GatheringRarePop[] RarePops { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            RarePops = new GatheringRarePop[ 3 ];
            for( var i = 0; i < 3; i++ )
            {
                RarePops[ i ] = new GatheringRarePop();
                RarePops[ i ].StartTime = parser.ReadColumn< ushort >( 0 + ( i * 2 + 0 ) );
                RarePops[ i ].Duration = parser.ReadColumn< ushort >( 0 + ( i * 2 + 1 ) );
            }
        }
    }
}