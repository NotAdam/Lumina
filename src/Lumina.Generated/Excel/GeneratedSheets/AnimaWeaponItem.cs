using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeaponItem", columnHash: 0xe0a5cdd0 )]
    public class AnimaWeaponItem : IExcelRow
    {
        
        public LazyRow< Item >[] Item;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Item = new LazyRow< Item >[ 14 ];
            for( var i = 0; i < 14; i++ )
                Item[ i ] = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 0 + i ), language );
        }
    }
}