using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GeneralAction", columnHash: 0x5dffa8fa )]
    public class GeneralAction : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public string Description;

        // col: 07 offset: 0008
        public int Icon;

        // col: 03 offset: 000c
        public ushort Action;

        // col: 04 offset: 000e
        public ushort UnlockLink;

        // col: 02 offset: 0010
        public byte unknown10;

        // col: 05 offset: 0011
        public byte Recast;

        // col: 06 offset: 0012
        public byte UIPriority;

        // col: 08 offset: 0013
        public bool packed13_1;
        public byte packed13;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Description = parser.ReadOffset< string >( 0x4 );

            // col: 7 offset: 0008
            Icon = parser.ReadOffset< int >( 0x8 );

            // col: 3 offset: 000c
            Action = parser.ReadOffset< ushort >( 0xc );

            // col: 4 offset: 000e
            UnlockLink = parser.ReadOffset< ushort >( 0xe );

            // col: 2 offset: 0010
            unknown10 = parser.ReadOffset< byte >( 0x10 );

            // col: 5 offset: 0011
            Recast = parser.ReadOffset< byte >( 0x11 );

            // col: 6 offset: 0012
            UIPriority = parser.ReadOffset< byte >( 0x12 );

            // col: 8 offset: 0013
            packed13 = parser.ReadOffset< byte >( 0x13, ExcelColumnDataType.UInt8 );

            packed13_1 = ( packed13 & 0x1 ) == 0x1;


        }
    }
}