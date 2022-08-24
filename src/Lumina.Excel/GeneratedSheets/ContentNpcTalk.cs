// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentNpcTalk", columnHash: 0xcfa3d5cd )]
    public partial class ContentNpcTalk : ExcelRow
    {
        
        public int Type { get; set; }
        public LazyRow< ContentTalk >[] ContentTalk { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Type = parser.ReadColumn< int >( 0 );
            ContentTalk = new LazyRow< ContentTalk >[ 8 ];
            for( var i = 0; i < 8; i++ )
                ContentTalk[ i ] = new LazyRow< ContentTalk >( gameData, parser.ReadColumn< uint >( 1 + i ), language );
        }
    }
}