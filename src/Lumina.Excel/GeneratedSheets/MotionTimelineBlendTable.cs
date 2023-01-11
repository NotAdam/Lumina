// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MotionTimelineBlendTable", columnHash: 0x69213275 )]
    public partial class MotionTimelineBlendTable : ExcelRow
    {
        
        public byte DestBlendGroup { get; set; }
        public byte SrcBlendGroup { get; set; }
        public byte BlendFrame_PC { get; set; }
        public byte BlendFram_TypeA { get; set; }
        public byte BlendFram_TypeB { get; set; }
        public byte BlendFram_TypeC { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            DestBlendGroup = parser.ReadColumn< byte >( 0 );
            SrcBlendGroup = parser.ReadColumn< byte >( 1 );
            BlendFrame_PC = parser.ReadColumn< byte >( 2 );
            BlendFram_TypeA = parser.ReadColumn< byte >( 3 );
            BlendFram_TypeB = parser.ReadColumn< byte >( 4 );
            BlendFram_TypeC = parser.ReadColumn< byte >( 5 );
        }
    }
}