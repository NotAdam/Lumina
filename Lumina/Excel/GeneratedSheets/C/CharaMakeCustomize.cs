using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CharaMakeCustomize", columnHash: 0x2ba6bf0f )]
    public class CharaMakeCustomize : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public uint Icon;

        // col: 04 offset: 0004
        public uint Hint;

        // col: 05 offset: 0008
        public uint HintItem;

        // col: 02 offset: 000c
        public ushort Data;

        // col: 00 offset: 000e
        public byte FeatureID;

        // col: 03 offset: 000f
        public bool IsPurchasable;
        public byte packedf;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Icon = parser.ReadOffset< uint >( 0x0 );

            // col: 4 offset: 0004
            Hint = parser.ReadOffset< uint >( 0x4 );

            // col: 5 offset: 0008
            HintItem = parser.ReadOffset< uint >( 0x8 );

            // col: 2 offset: 000c
            Data = parser.ReadOffset< ushort >( 0xc );

            // col: 0 offset: 000e
            FeatureID = parser.ReadOffset< byte >( 0xe );

            // col: 3 offset: 000f
            packedf = parser.ReadOffset< byte >( 0xf, ExcelColumnDataType.UInt8 );

            IsPurchasable = ( packedf & 0x1 ) == 0x1;


        }
    }
}