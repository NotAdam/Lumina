namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EmoteMode", columnHash: 0x087a32e7 )]
    public class EmoteMode : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: StartEmote
         *  type: 
         */

        /* offset: 0002 col: 1
         *  name: EndEmote
         *  type: 
         */

        /* offset: 0005 col: 2
         *  name: Move
         *  type: 
         */

        /* offset: 0005 col: 3
         *  name: Camera
         *  type: 
         */

        /* offset: 0005 col: 4
         *  name: EndOnRotate
         *  type: 
         */

        /* offset: 0005 col: 5
         *  name: EndOnEmote
         *  type: 
         */

        /* offset: 0004 col: 6
         *  name: ConditionMode
         *  type: 
         */

        /* offset: 0005 col: 7
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public ushort StartEmote;

        // col: 01 offset: 0002
        public ushort EndEmote;

        // col: 06 offset: 0004
        public byte ConditionMode;

        // col: 02 offset: 0005
        private byte packed5;
        public bool Move => ( packed5 & 0x1 ) == 0x1;
        public bool Camera => ( packed5 & 0x2 ) == 0x2;
        public bool EndOnRotate => ( packed5 & 0x4 ) == 0x4;
        public bool EndOnEmote => ( packed5 & 0x8 ) == 0x8;
        public bool packed5_10 => ( packed5 & 0x10 ) == 0x10;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            StartEmote = parser.ReadOffset< ushort >( 0x0 );

            // col: 1 offset: 0002
            EndEmote = parser.ReadOffset< ushort >( 0x2 );

            // col: 6 offset: 0004
            ConditionMode = parser.ReadOffset< byte >( 0x4 );

            // col: 2 offset: 0005
            packed5 = parser.ReadOffset< byte >( 0x5 );


        }
    }
}