namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentTalk", columnHash: 0x5eb59ccb )]
    public class ContentTalk : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0004 col: 0
         *  name: ContentTalkParam
         *  type: 
         */

        /* offset: 0000 col: 1
         *  name: Text
         *  type: 
         */



        // col: 01 offset: 0000
        public string Text;

        // col: 00 offset: 0004
        public byte ContentTalkParam;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Text = parser.ReadOffset< string >( 0x0 );

            // col: 0 offset: 0004
            ContentTalkParam = parser.ReadOffset< byte >( 0x4 );


        }
    }
}