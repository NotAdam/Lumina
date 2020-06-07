using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "NotebookDivision", columnHash: 0xb4638be9 )]
    public class NotebookDivision : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


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
        public bool packed14_1;
        public byte packed14;


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
            packed14 = parser.ReadOffset< byte >( 0x14, ExcelColumnDataType.UInt8 );

            packed14_1 = ( packed14 & 0x1 ) == 0x1;


        }
    }
}