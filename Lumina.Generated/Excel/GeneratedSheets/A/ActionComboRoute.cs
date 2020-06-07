using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionComboRoute", columnHash: 0xc4b3400f )]
    public class ActionComboRoute : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 02 offset: 0004
        public ushort[] Action;

        // col: 01 offset: 000c
        public sbyte unknownc;

        // col: 06 offset: 000d
        public bool packedd_1;
        public byte packedd;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            Action = new ushort[4];
            Action[0] = parser.ReadOffset< ushort >( 0x4 );
            Action[1] = parser.ReadOffset< ushort >( 0x6 );
            Action[2] = parser.ReadOffset< ushort >( 0x8 );
            Action[3] = parser.ReadOffset< ushort >( 0xa );

            // col: 1 offset: 000c
            unknownc = parser.ReadOffset< sbyte >( 0xc );

            // col: 6 offset: 000d
            packedd = parser.ReadOffset< byte >( 0xd, ExcelColumnDataType.UInt8 );

            packedd_1 = ( packedd & 0x1 ) == 0x1;


        }
    }
}