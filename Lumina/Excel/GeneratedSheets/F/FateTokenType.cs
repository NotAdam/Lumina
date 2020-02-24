namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FateTokenType", columnHash: 0xdbf43666 )]
    public class FateTokenType : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Currency
         *  type: 
         */



        // col: 00 offset: 0000
        public uint Currency;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Currency = parser.ReadOffset< uint >( 0x0 );


        }
    }
}