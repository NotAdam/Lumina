// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MotionTimelineBlendTable", columnHash: 0x69213275 )]
    public class MotionTimelineBlendTable : IExcelRow
    {
        
        public byte DestBlendGroup;
        public byte SrcBlendGroup;
        public byte BlendFrame_PC;
        public byte BlendFram_TypeA;
        public byte BlendFram_TypeB;
        public byte BlendFram_TypeC;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            DestBlendGroup = parser.ReadColumn< byte >( 0 );
            SrcBlendGroup = parser.ReadColumn< byte >( 1 );
            BlendFrame_PC = parser.ReadColumn< byte >( 2 );
            BlendFram_TypeA = parser.ReadColumn< byte >( 3 );
            BlendFram_TypeB = parser.ReadColumn< byte >( 4 );
            BlendFram_TypeC = parser.ReadColumn< byte >( 5 );
        }
    }
}