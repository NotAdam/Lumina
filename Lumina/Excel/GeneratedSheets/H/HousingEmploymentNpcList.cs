namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingEmploymentNpcList", columnHash: 0x6195119b )]
    public class HousingEmploymentNpcList : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0008 col: 0
         *  name: Race
         *  type: 
         */

        /* offset: 0000 col: 1
         *  name: ENpcBase
         *  repeat count: 2
         */

        /* offset: 0004 col: 2
         *  no SaintCoinach definition found
         */



        // col: 01 offset: 0000
        public uint[] ENpcBase;

        // col: 00 offset: 0008
        public byte Race;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            ENpcBase = new uint[2];
            ENpcBase[0] = parser.ReadOffset< uint >( 0x0 );
            ENpcBase[1] = parser.ReadOffset< uint >( 0x4 );

            // col: 0 offset: 0008
            Race = parser.ReadOffset< byte >( 0x8 );


        }
    }
}