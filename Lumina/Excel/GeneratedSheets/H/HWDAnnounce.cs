namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDAnnounce", columnHash: 0x1d91a784 )]
    public class HWDAnnounce : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Name
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: ENPC
         *  type: 
         */

        /* offset: 0008 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 0009 col: 3
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public uint ENPC;

        // col: 02 offset: 0008
        public byte unknown8;

        // col: 03 offset: 0009
        public byte unknown9;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            ENPC = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            unknown8 = parser.ReadOffset< byte >( 0x8 );

            // col: 3 offset: 0009
            unknown9 = parser.ReadOffset< byte >( 0x9 );


        }
    }
}