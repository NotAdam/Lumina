namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGMSwitch", columnHash: 0x0989d4f2 )]
    public class BGMSwitch : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0006 col: 0
         *  name: BGMSystemDefine
         *  type: 
         */

        /* offset: 0000 col: 1
         *  name: Quest
         *  type: 
         */

        /* offset: 0007 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 3
         *  no SaintCoinach definition found
         */



        // col: 01 offset: 0000
        public uint Quest;

        // col: 03 offset: 0004
        public ushort unknown4;

        // col: 00 offset: 0006
        public byte BGMSystemDefine;

        // col: 02 offset: 0007
        public byte unknown7;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Quest = parser.ReadOffset< uint >( 0x0 );

            // col: 3 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );

            // col: 0 offset: 0006
            BGMSystemDefine = parser.ReadOffset< byte >( 0x6 );

            // col: 2 offset: 0007
            unknown7 = parser.ReadOffset< byte >( 0x7 );


        }
    }
}