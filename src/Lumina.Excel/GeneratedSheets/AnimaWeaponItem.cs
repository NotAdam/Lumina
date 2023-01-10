// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeaponItem", columnHash: 0xe0a5cdd0 )]
    public partial class AnimaWeaponItem : ExcelRow
    {
        
        public LazyRow< Item >[] Item { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >[ 14 ];
            for( var i = 0; i < 14; i++ )
                Item[ i ] = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 0 + i ), language );
        }
    }
}