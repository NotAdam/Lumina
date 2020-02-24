namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDFishParam", columnHash: 0x5a516458 )]
    public class IKDFishParam : IExcelRow
    {
        // column defs from Mon, 24 Feb 2020 17:34:06 GMT

        /* offset: 0000 col: 0
         *  name: Fish
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: IKDContentBonus
         *  type: 
         */



        // col: 00 offset: 0000
        public uint Fish;

        // col: 01 offset: 0004
        public byte IKDContentBonus;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Fish = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            IKDContentBonus = parser.ReadOffset< byte >( 0x4 );


        }
    }
}