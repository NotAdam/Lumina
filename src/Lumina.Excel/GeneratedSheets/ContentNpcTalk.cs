// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentNpcTalk", columnHash: 0xcfa3d5cd )]
    public class ContentNpcTalk : ExcelRow
    {
        
        public int Type;
        public LazyRow< ContentTalk >[] ContentTalk;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Type = parser.ReadColumn< int >( 0 );
            ContentTalk = new LazyRow< ContentTalk >[ 8 ];
            for( var i = 0; i < 8; i++ )
                ContentTalk[ i ] = new LazyRow< ContentTalk >( lumina, parser.ReadColumn< uint >( 1 + i ), language );
        }
    }
}