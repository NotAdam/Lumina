// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EurekaMagiciteItem", columnHash: 0xbc638df5 )]
    public partial class EurekaMagiciteItem : ExcelRow
    {
        
        public LazyRow< EurekaMagiciteItemType > EurekaMagiciteItemType { get; set; }
        public LazyRow< ClassJobCategory > ClassJobCategory { get; set; }
        public LazyRow< Item > Item { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            EurekaMagiciteItemType = new LazyRow< EurekaMagiciteItemType >( gameData, parser.ReadColumn< byte >( 0 ), language );
            ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadColumn< byte >( 1 ), language );
            Item = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 2 ), language );
        }
    }
}