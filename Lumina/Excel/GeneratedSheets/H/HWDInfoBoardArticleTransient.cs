namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDInfoBoardArticleTransient", columnHash: 0x11a44a12 )]
    public class HWDInfoBoardArticleTransient : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0008 col: 0
         *  name: Image
         *  type: 
         */

        /* offset: 0000 col: 1
         *  name: Text
         *  type: 
         */

        /* offset: 0004 col: 2
         *  name: NpcName
         *  type: 
         */



        // col: 01 offset: 0000
        public string Text;

        // col: 02 offset: 0004
        public string NpcName;

        // col: 00 offset: 0008
        public uint Image;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Text = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            NpcName = parser.ReadOffset< string >( 0x4 );

            // col: 0 offset: 0008
            Image = parser.ReadOffset< uint >( 0x8 );


        }
    }
}