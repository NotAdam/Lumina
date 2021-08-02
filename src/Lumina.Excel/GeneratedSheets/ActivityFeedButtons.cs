// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActivityFeedButtons", columnHash: 0x20072d40 )]
    public partial class ActivityFeedButtons : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public SeString BannerURL { get; set; }
        public SeString Description { get; set; }
        public SeString Language { get; set; }
        public SeString PictureURL { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            BannerURL = parser.ReadColumn< SeString >( 1 );
            Description = parser.ReadColumn< SeString >( 2 );
            Language = parser.ReadColumn< SeString >( 3 );
            PictureURL = parser.ReadColumn< SeString >( 4 );
        }
    }
}