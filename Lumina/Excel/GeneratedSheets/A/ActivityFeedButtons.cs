using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActivityFeedButtons", columnHash: 0x20072d40 )]
    public class ActivityFeedButtons : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 01 offset: 0000
        public string BannerURL;

        // col: 02 offset: 0004
        public string Description;

        // col: 03 offset: 0008
        public string Language;

        // col: 04 offset: 000c
        public string PictureURL;

        // col: 00 offset: 0010
        public byte unknown10;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            BannerURL = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            Description = parser.ReadOffset< string >( 0x4 );

            // col: 3 offset: 0008
            Language = parser.ReadOffset< string >( 0x8 );

            // col: 4 offset: 000c
            PictureURL = parser.ReadOffset< string >( 0xc );

            // col: 0 offset: 0010
            unknown10 = parser.ReadOffset< byte >( 0x10 );


        }
    }
}