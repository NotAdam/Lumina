// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BannerFacial", columnHash: 0xd8ae9355 )]
    public partial class BannerFacial : ExcelRow
    {
        
        public LazyRow< Emote > Emote { get; set; }
        public LazyRow< BannerCondition > UnlockCondition { get; set; }
        public byte SortKey { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Emote = new LazyRow< Emote >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            UnlockCondition = new LazyRow< BannerCondition >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            SortKey = parser.ReadColumn< byte >( 2 );
        }
    }
}