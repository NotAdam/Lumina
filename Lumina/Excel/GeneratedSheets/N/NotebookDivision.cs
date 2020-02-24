namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "NotebookDivision", columnHash: 0xb4638be9 )]
    public class NotebookDivision : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Name
         *  type: 
         */

        /* offset: 0008 col: 1
         *  name: NotebookDivisionCategory
         *  type: 
         */

        /* offset: 0009 col: 2
         *  name: CraftOpeningLevel
         *  type: 
         */

        /* offset: 000a col: 3
         *  name: GatheringOpeningLevel
         *  type: 
         */

        /* offset: 0004 col: 4
         *  name: QuestUnlock
         *  type: 
         */

        /* offset: 000b col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 7
         *  name: CRPCraft
         *  type: 
         */

        /* offset: 000d col: 8
         *  name: BSMCraft
         *  type: 
         */

        /* offset: 000e col: 9
         *  name: ARMCraft
         *  type: 
         */

        /* offset: 000f col: 10
         *  name: GSMCraft
         *  type: 
         */

        /* offset: 0010 col: 11
         *  name: LTWCraft
         *  type: 
         */

        /* offset: 0011 col: 12
         *  name: WVRCraft
         *  type: 
         */

        /* offset: 0012 col: 13
         *  name: ALCCraft
         *  type: 
         */

        /* offset: 0013 col: 14
         *  name: CULCraft
         *  type: 
         */



        // col: 00 offset: 0000
        public string Name;

        // col: 04 offset: 0004
        public uint QuestUnlock;

        // col: 01 offset: 0008
        public byte NotebookDivisionCategory;

        // col: 02 offset: 0009
        public byte CraftOpeningLevel;

        // col: 03 offset: 000a
        public byte GatheringOpeningLevel;

        // col: 05 offset: 000b
        public byte unknownb;

        // col: 07 offset: 000c
        public bool CRPCraft;

        // col: 08 offset: 000d
        public bool BSMCraft;

        // col: 09 offset: 000e
        public bool ARMCraft;

        // col: 10 offset: 000f
        public bool GSMCraft;

        // col: 11 offset: 0010
        public bool LTWCraft;

        // col: 12 offset: 0011
        public bool WVRCraft;

        // col: 13 offset: 0012
        public bool ALCCraft;

        // col: 14 offset: 0013
        public bool CULCraft;

        // col: 06 offset: 0014
        private byte packed14;
        public bool packed14_1 => ( packed14 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 4 offset: 0004
            QuestUnlock = parser.ReadOffset< uint >( 0x4 );

            // col: 1 offset: 0008
            NotebookDivisionCategory = parser.ReadOffset< byte >( 0x8 );

            // col: 2 offset: 0009
            CraftOpeningLevel = parser.ReadOffset< byte >( 0x9 );

            // col: 3 offset: 000a
            GatheringOpeningLevel = parser.ReadOffset< byte >( 0xa );

            // col: 5 offset: 000b
            unknownb = parser.ReadOffset< byte >( 0xb );

            // col: 7 offset: 000c
            CRPCraft = parser.ReadOffset< bool >( 0xc );

            // col: 8 offset: 000d
            BSMCraft = parser.ReadOffset< bool >( 0xd );

            // col: 9 offset: 000e
            ARMCraft = parser.ReadOffset< bool >( 0xe );

            // col: 10 offset: 000f
            GSMCraft = parser.ReadOffset< bool >( 0xf );

            // col: 11 offset: 0010
            LTWCraft = parser.ReadOffset< bool >( 0x10 );

            // col: 12 offset: 0011
            WVRCraft = parser.ReadOffset< bool >( 0x11 );

            // col: 13 offset: 0012
            ALCCraft = parser.ReadOffset< bool >( 0x12 );

            // col: 14 offset: 0013
            CULCraft = parser.ReadOffset< bool >( 0x13 );

            // col: 6 offset: 0014
            packed14 = parser.ReadOffset< byte >( 0x14 );


        }
    }
}