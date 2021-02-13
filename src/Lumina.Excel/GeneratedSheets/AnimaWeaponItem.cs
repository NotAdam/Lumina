// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeaponItem", columnHash: 0xe0a5cdd0 )]
    public class AnimaWeaponItem : ExcelRow
    {
        
        public LazyRow< Item >[] Item;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Item = new LazyRow< Item >[ 14 ];
            for( var i = 0; i < 14; i++ )
                Item[ i ] = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 0 + i ), language );
        }
    }
}