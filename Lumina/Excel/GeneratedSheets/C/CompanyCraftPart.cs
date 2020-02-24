namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyCraftPart", columnHash: 0xe9ffd316 )]
    public class CompanyCraftPart : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0008 col: 0
         *  no SaintCoinach definition found
         */

        /* offset: 0009 col: 1
         *  name: CompanyCraftType
         *  type: 
         */

        /* offset: 0000 col: 2
         *  name: CompanyCraftProcess
         *  repeat count: 3
         */

        /* offset: 0002 col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0004 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0006 col: 5
         *  no SaintCoinach definition found
         */



        // col: 02 offset: 0000
        public ushort[] CompanyCraftProcess;

        // col: 05 offset: 0006
        public ushort unknown6;

        // col: 00 offset: 0008
        public byte unknown8;

        // col: 01 offset: 0009
        public byte CompanyCraftType;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            CompanyCraftProcess = new ushort[3];
            CompanyCraftProcess[0] = parser.ReadOffset< ushort >( 0x0 );
            CompanyCraftProcess[1] = parser.ReadOffset< ushort >( 0x2 );
            CompanyCraftProcess[2] = parser.ReadOffset< ushort >( 0x4 );

            // col: 5 offset: 0006
            unknown6 = parser.ReadOffset< ushort >( 0x6 );

            // col: 0 offset: 0008
            unknown8 = parser.ReadOffset< byte >( 0x8 );

            // col: 1 offset: 0009
            CompanyCraftType = parser.ReadOffset< byte >( 0x9 );


        }
    }
}