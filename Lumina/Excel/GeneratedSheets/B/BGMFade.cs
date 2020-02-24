using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGMFade", columnHash: 0xf09994a9 )]
    public class BGMFade : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 00 offset: 0000
        public int SceneOut;

        // col: 01 offset: 0004
        public int SceneIn;

        // col: 02 offset: 0008
        public int BGMFadeType;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            SceneOut = parser.ReadOffset< int >( 0x0 );

            // col: 1 offset: 0004
            SceneIn = parser.ReadOffset< int >( 0x4 );

            // col: 2 offset: 0008
            BGMFadeType = parser.ReadOffset< int >( 0x8 );


        }
    }
}