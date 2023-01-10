// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FateShop", columnHash: 0x478c9a56 )]
    public partial class FateShop : ExcelRow
    {
        
        public LazyRow< SpecialShop >[] SpecialShop { get; set; }
        public LazyRow< DefaultTalk >[] DefaultTalk { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            SpecialShop = new LazyRow< SpecialShop >[ 2 ];
            for( var i = 0; i < 2; i++ )
                SpecialShop[ i ] = new LazyRow< SpecialShop >( gameData, parser.ReadColumn< uint >( 0 + i ), language );
            DefaultTalk = new LazyRow< DefaultTalk >[ 8 ];
            for( var i = 0; i < 8; i++ )
                DefaultTalk[ i ] = new LazyRow< DefaultTalk >( gameData, parser.ReadColumn< uint >( 2 + i ), language );
        }
    }
}