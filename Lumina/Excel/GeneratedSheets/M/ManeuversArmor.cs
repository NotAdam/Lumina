namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ManeuversArmor", columnHash: 0xc8b98ed4 )]
    public class ManeuversArmor : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0024 col: 0
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 1
         *  name: BNpcBase
         *  repeat count: 2
         */

        /* offset: 000c col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 0026 col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0027 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 5
         *  name: Icon
         *  repeat count: 5
         */

        /* offset: 0014 col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 0018 col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 001c col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 0020 col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 0000 col: 10
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 11
         *  no SaintCoinach definition found
         */



        // col: 10 offset: 0000
        public string unknown0;

        // col: 11 offset: 0004
        public string unknown4;

        // col: 01 offset: 0008
        public uint[] BNpcBase;

        // col: 05 offset: 0010
        public uint[] Icon;

        // col: 00 offset: 0024
        public ushort unknown24;

        // col: 03 offset: 0026
        public byte unknown26;

        // col: 04 offset: 0027
        private byte packed27;
        public bool packed27_1 => ( packed27 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 10 offset: 0000
            unknown0 = parser.ReadOffset< string >( 0x0 );

            // col: 11 offset: 0004
            unknown4 = parser.ReadOffset< string >( 0x4 );

            // col: 1 offset: 0008
            BNpcBase = new uint[2];
            BNpcBase[0] = parser.ReadOffset< uint >( 0x8 );
            BNpcBase[1] = parser.ReadOffset< uint >( 0xc );

            // col: 5 offset: 0010
            Icon = new uint[5];
            Icon[0] = parser.ReadOffset< uint >( 0x10 );
            Icon[1] = parser.ReadOffset< uint >( 0x14 );
            Icon[2] = parser.ReadOffset< uint >( 0x18 );
            Icon[3] = parser.ReadOffset< uint >( 0x1c );
            Icon[4] = parser.ReadOffset< uint >( 0x20 );

            // col: 0 offset: 0024
            unknown24 = parser.ReadOffset< ushort >( 0x24 );

            // col: 3 offset: 0026
            unknown26 = parser.ReadOffset< byte >( 0x26 );

            // col: 4 offset: 0027
            packed27 = parser.ReadOffset< byte >( 0x27 );


        }
    }
}