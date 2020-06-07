using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MovieSubtitleVoyage", columnHash: 0x07f99ad3 )]
    public class MovieSubtitleVoyage : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public float StartTime;

        // col: 01 offset: 0004
        public float EndTime;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            StartTime = parser.ReadOffset< float >( 0x0 );

            // col: 1 offset: 0004
            EndTime = parser.ReadOffset< float >( 0x4 );


        }
    }
}