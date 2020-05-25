using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGMFadeType", columnHash: 0xe018b5fa )]
    public class BGMFadeType : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public float FadeOutTime;

        // col: 01 offset: 0004
        public float FadeInTime;

        // col: 02 offset: 0008
        public float FadeInStartTime;

        // col: 03 offset: 000c
        public float ResumeFadeInTime;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            FadeOutTime = parser.ReadOffset< float >( 0x0 );

            // col: 1 offset: 0004
            FadeInTime = parser.ReadOffset< float >( 0x4 );

            // col: 2 offset: 0008
            FadeInStartTime = parser.ReadOffset< float >( 0x8 );

            // col: 3 offset: 000c
            ResumeFadeInTime = parser.ReadOffset< float >( 0xc );


        }
    }
}