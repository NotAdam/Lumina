// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "UDS_Event", columnHash: 0xdfabf9e4 )]
    public partial class UDS_Event : ExcelRow
    {
        
        public SeString Text { get; set; }
        public SeString Type { get; set; }
        public LazyRow< UDS_Property >[] Property { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Text = parser.ReadColumn< SeString >( 0 );
            Type = parser.ReadColumn< SeString >( 1 );
            Property = new LazyRow< UDS_Property >[ 32 ];
            for( var i = 0; i < 32; i++ )
                Property[ i ] = new LazyRow< UDS_Property >( gameData, parser.ReadColumn< int >( 2 + i ), language );
        }
    }
}