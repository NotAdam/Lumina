using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MotionTimelineBlendTable", columnHash: 0x69213275 )]
    public class MotionTimelineBlendTable : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public byte DestBlendGroup;

        // col: 01 offset: 0001
        public byte SrcBlendGroup;

        // col: 02 offset: 0002
        public byte BlendFrame_PC;

        // col: 03 offset: 0003
        public byte BlendFram_TypeA;

        // col: 04 offset: 0004
        public byte BlendFram_TypeB;

        // col: 05 offset: 0005
        public byte BlendFram_TypeC;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            DestBlendGroup = parser.ReadOffset< byte >( 0x0 );

            // col: 1 offset: 0001
            SrcBlendGroup = parser.ReadOffset< byte >( 0x1 );

            // col: 2 offset: 0002
            BlendFrame_PC = parser.ReadOffset< byte >( 0x2 );

            // col: 3 offset: 0003
            BlendFram_TypeA = parser.ReadOffset< byte >( 0x3 );

            // col: 4 offset: 0004
            BlendFram_TypeB = parser.ReadOffset< byte >( 0x4 );

            // col: 5 offset: 0005
            BlendFram_TypeC = parser.ReadOffset< byte >( 0x5 );


        }
    }
}