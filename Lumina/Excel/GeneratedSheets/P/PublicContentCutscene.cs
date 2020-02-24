namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PublicContentCutscene", columnHash: 0x5d58cc84 )]
    public class PublicContentCutscene : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Cutscene
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Cutscene2
         *  type: 
         */



        // col: 00 offset: 0000
        public uint Cutscene;

        // col: 01 offset: 0004
        public uint Cutscene2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Cutscene = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            Cutscene2 = parser.ReadOffset< uint >( 0x4 );


        }
    }
}