namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "UIColor", columnHash: 0x96a22aea )]
    public class UIColor : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: UIForeground
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: UIGlow
         *  type: 
         */

        /* offset: 0008 col: 2
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public uint UIForeground;

        // col: 01 offset: 0004
        public uint UIGlow;

        // col: 02 offset: 0008
        public uint unknown8;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            UIForeground = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            UIGlow = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            unknown8 = parser.ReadOffset< uint >( 0x8 );


        }
    }
}