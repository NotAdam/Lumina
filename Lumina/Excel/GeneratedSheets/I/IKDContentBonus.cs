namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDContentBonus", columnHash: 0xb7d9b7a3 )]
    public class IKDContentBonus : IExcelRow
    {
        // column defs from Mon, 24 Feb 2020 17:34:06 GMT

        /* offset: 0000 col: 0
         *  name: Objective
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Requirement
         *  type: 
         */

        /* offset: 000c col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 3
         *  name: Image
         *  type: 
         */

        /* offset: 000e col: 4
         *  name: Order
         *  type: 
         */



        // col: 00 offset: 0000
        public string Objective;

        // col: 01 offset: 0004
        public string Requirement;

        // col: 03 offset: 0008
        public uint Image;

        // col: 02 offset: 000c
        public ushort unknownc;

        // col: 04 offset: 000e
        public byte Order;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Objective = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Requirement = parser.ReadOffset< string >( 0x4 );

            // col: 3 offset: 0008
            Image = parser.ReadOffset< uint >( 0x8 );

            // col: 2 offset: 000c
            unknownc = parser.ReadOffset< ushort >( 0xc );

            // col: 4 offset: 000e
            Order = parser.ReadOffset< byte >( 0xe );


        }
    }
}