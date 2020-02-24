namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MotionTimelineBlendTable", columnHash: 0x69213275 )]
    public class MotionTimelineBlendTable : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: DestBlendGroup
         *  type: 
         */

        /* offset: 0001 col: 1
         *  name: SrcBlendGroup
         *  type: 
         */

        /* offset: 0002 col: 2
         *  name: BlendFrame_PC
         *  type: 
         */

        /* offset: 0003 col: 3
         *  name: BlendFram_TypeA
         *  type: 
         */

        /* offset: 0004 col: 4
         *  name: BlendFram_TypeB
         *  type: 
         */

        /* offset: 0005 col: 5
         *  name: BlendFram_TypeC
         *  type: 
         */



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


        public int RowId { get; set; }
        public int SubRowId { get; set; }

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