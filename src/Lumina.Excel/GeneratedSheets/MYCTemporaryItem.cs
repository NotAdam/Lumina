// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MYCTemporaryItem", columnHash: 0x9176820b )]
    public partial class MYCTemporaryItem : ExcelRow
    {
        
        public LazyRow< MYCTemporaryItemUICategory > Category { get; set; }
        public byte Type { get; set; }
        public LazyRow< Action > Action { get; set; }
        public byte Max { get; set; }
        public byte Weight { get; set; }
        public byte Order { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Category = new LazyRow< MYCTemporaryItemUICategory >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Type = parser.ReadColumn< byte >( 1 );
            Action = new LazyRow< Action >( gameData, parser.ReadColumn< uint >( 2 ), language );
            Max = parser.ReadColumn< byte >( 3 );
            Weight = parser.ReadColumn< byte >( 4 );
            Order = parser.ReadColumn< byte >( 5 );
        }
    }
}