namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "InstanceContentCSBonus", columnHash: 0x8613e13c )]
    public class InstanceContentCSBonus : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0004 col: 0
         *  name: Instance
         *  type: 
         */

        /* offset: 0000 col: 1
         *  name: Item
         *  type: 
         */

        /* offset: 0006 col: 2
         *  no SaintCoinach definition found
         */



        // col: 01 offset: 0000
        public uint Item;

        // col: 00 offset: 0004
        public ushort Instance;

        // col: 02 offset: 0006
        public byte unknown6;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Item = parser.ReadOffset< uint >( 0x0 );

            // col: 0 offset: 0004
            Instance = parser.ReadOffset< ushort >( 0x4 );

            // col: 2 offset: 0006
            unknown6 = parser.ReadOffset< byte >( 0x6 );


        }
    }
}