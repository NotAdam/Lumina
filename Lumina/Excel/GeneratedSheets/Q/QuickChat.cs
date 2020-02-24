using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuickChat", columnHash: 0x66d693c5 )]
    public class QuickChat : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public string NameAction;

        // col: 01 offset: 0004
        public int Icon;

        // col: 02 offset: 0008
        public int Addon;

        // col: 04 offset: 000c
        public ushort unknownc;

        // col: 03 offset: 000e
        public sbyte QuickChatTransient;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            NameAction = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Icon = parser.ReadOffset< int >( 0x4 );

            // col: 2 offset: 0008
            Addon = parser.ReadOffset< int >( 0x8 );

            // col: 4 offset: 000c
            unknownc = parser.ReadOffset< ushort >( 0xc );

            // col: 3 offset: 000e
            QuickChatTransient = parser.ReadOffset< sbyte >( 0xe );


        }
    }
}