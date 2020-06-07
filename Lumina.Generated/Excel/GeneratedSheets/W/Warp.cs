using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Warp", columnHash: 0x1a234b7b )]
    public class Warp : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 10 offset: 0000
        public string Name;

        // col: 11 offset: 0004
        public string Question;

        // col: 00 offset: 0008
        public uint PopRange;

        // col: 02 offset: 000c
        public uint ConditionSuccessEvent;

        // col: 03 offset: 0010
        public uint ConditionFailEvent;

        // col: 04 offset: 0014
        public uint ConfirmEvent;

        // col: 01 offset: 0018
        public ushort TerritoryType;

        // col: 05 offset: 001a
        public ushort WarpCondition;

        // col: 06 offset: 001c
        public ushort WarpLogic;

        // col: 07 offset: 001e
        public ushort StartCutscene;

        // col: 08 offset: 0020
        public ushort EndCutscene;

        // col: 09 offset: 0022
        public bool CanSkipCutscene;
        public byte packed22;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 10 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 11 offset: 0004
            Question = parser.ReadOffset< string >( 0x4 );

            // col: 0 offset: 0008
            PopRange = parser.ReadOffset< uint >( 0x8 );

            // col: 2 offset: 000c
            ConditionSuccessEvent = parser.ReadOffset< uint >( 0xc );

            // col: 3 offset: 0010
            ConditionFailEvent = parser.ReadOffset< uint >( 0x10 );

            // col: 4 offset: 0014
            ConfirmEvent = parser.ReadOffset< uint >( 0x14 );

            // col: 1 offset: 0018
            TerritoryType = parser.ReadOffset< ushort >( 0x18 );

            // col: 5 offset: 001a
            WarpCondition = parser.ReadOffset< ushort >( 0x1a );

            // col: 6 offset: 001c
            WarpLogic = parser.ReadOffset< ushort >( 0x1c );

            // col: 7 offset: 001e
            StartCutscene = parser.ReadOffset< ushort >( 0x1e );

            // col: 8 offset: 0020
            EndCutscene = parser.ReadOffset< ushort >( 0x20 );

            // col: 9 offset: 0022
            packed22 = parser.ReadOffset< byte >( 0x22, ExcelColumnDataType.UInt8 );

            CanSkipCutscene = ( packed22 & 0x1 ) == 0x1;


        }
    }
}