namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeddingBGM", columnHash: 0x3d65a9f1 )]
    public class WeddingBGM : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0004 col: 0
         *  name: Song
         *  type: 
         */

        /* offset: 0000 col: 1
         *  name: SongName
         *  type: 
         */



        // col: 01 offset: 0000
        public string SongName;

        // col: 00 offset: 0004
        public ushort Song;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            SongName = parser.ReadOffset< string >( 0x0 );

            // col: 0 offset: 0004
            Song = parser.ReadOffset< ushort >( 0x4 );


        }
    }
}