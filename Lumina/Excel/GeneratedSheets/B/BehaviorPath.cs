namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BehaviorPath", columnHash: 0x96572d0d )]
    public class BehaviorPath : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0004 col: 0
         *  name: IsTurnTransition
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: IsFadeOut
         *  type: 
         */

        /* offset: 0004 col: 2
         *  name: IsFadeIn
         *  type: 
         */

        /* offset: 0004 col: 3
         *  name: IsWalking
         *  type: 
         */

        /* offset: 0004 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0000 col: 5
         *  name: Speed
         *  type: 
         */



        // col: 05 offset: 0000
        public float Speed;

        // col: 00 offset: 0004
        private byte packed4;
        public bool IsTurnTransition => ( packed4 & 0x1 ) == 0x1;
        public bool IsFadeOut => ( packed4 & 0x2 ) == 0x2;
        public bool IsFadeIn => ( packed4 & 0x4 ) == 0x4;
        public bool IsWalking => ( packed4 & 0x8 ) == 0x8;
        public bool packed4_10 => ( packed4 & 0x10 ) == 0x10;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 5 offset: 0000
            Speed = parser.ReadOffset< float >( 0x0 );

            // col: 0 offset: 0004
            packed4 = parser.ReadOffset< byte >( 0x4 );


        }
    }
}