// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActivityFeedButtons", columnHash: 0x20072d40 )]
    public class ActivityFeedButtons : IExcelRow
    {
        
        public byte Unknown0;
        public SeString BannerURL;
        public SeString Description;
        public SeString Language;
        public SeString PictureURL;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            BannerURL = parser.ReadColumn< SeString >( 1 );
            Description = parser.ReadColumn< SeString >( 2 );
            Language = parser.ReadColumn< SeString >( 3 );
            PictureURL = parser.ReadColumn< SeString >( 4 );
        }
    }
}