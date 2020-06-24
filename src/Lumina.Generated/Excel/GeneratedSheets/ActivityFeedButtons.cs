using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActivityFeedButtons", columnHash: 0x20072d40 )]
    public class ActivityFeedButtons : IExcelRow
    {
        
        public byte Unknown0;
        public string BannerURL;
        public string Description;
        public string Language;
        public string PictureURL;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            BannerURL = parser.ReadColumn< string >( 1 );
            Description = parser.ReadColumn< string >( 2 );
            Language = parser.ReadColumn< string >( 3 );
            PictureURL = parser.ReadColumn< string >( 4 );
        }
    }
}