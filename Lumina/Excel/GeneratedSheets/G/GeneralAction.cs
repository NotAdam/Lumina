namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GeneralAction", columnHash: 0x5dffa8fa )]
    public class GeneralAction : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Name
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Description
         *  type: 
         */

        /* offset: 0010 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 3
         *  name: Action
         *  type: 
         */

        /* offset: 000e col: 4
         *  name: UnlockLink
         *  type: 
         */

        /* offset: 0011 col: 5
         *  name: Recast
         *  type: 
         */

        /* offset: 0012 col: 6
         *  name: UIPriority
         *  type: 
         */

        /* offset: 0008 col: 7
         *  name: Icon
         *  type: 
         */

        /* offset: 0013 col: 8
         *  no SaintCoinach definition found
         */



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
        private byte packed13;
        public bool packed13_1 => ( packed13 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

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
            packed13 = parser.ReadOffset< byte >( 0x13 );


        }
    }
}