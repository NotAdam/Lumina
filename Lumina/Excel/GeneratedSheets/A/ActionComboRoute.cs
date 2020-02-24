namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionComboRoute", columnHash: 0xc4b3400f )]
    public class ActionComboRoute : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Name
         *  type: 
         */

        /* offset: 000c col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 2
         *  name: Action
         *  repeat count: 4
         */

        /* offset: 0006 col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 000a col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 000d col: 6
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public string Name;

        // col: 02 offset: 0004
        public ushort[] Action;

        // col: 01 offset: 000c
        public sbyte unknownc;

        // col: 06 offset: 000d
        private byte packedd;
        public bool packedd_1 => ( packedd & 0x1 ) == 0x1;


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
            packedd = parser.ReadOffset< byte >( 0xd );


        }
    }
}