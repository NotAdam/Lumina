// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentNpcTalk", columnHash: 0xcfa3d5cd )]
    public class ContentNpcTalk : IExcelRow
    {
        
        public int Type;
        public LazyRow< ContentTalk >[] ContentTalk;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Type = parser.ReadColumn< int >( 0 );
            ContentTalk = new LazyRow< ContentTalk >[ 8 ];
            for( var i = 0; i < 8; i++ )
                ContentTalk[ i ] = new LazyRow< ContentTalk >( lumina, parser.ReadColumn< uint >( 1 + i ), language );
        }
    }
}