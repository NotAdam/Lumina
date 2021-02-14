// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuildleveAssignmentCategory", columnHash: 0xeb15b554 )]
    public class GuildleveAssignmentCategory : ExcelRow
    {
        
        public LazyRow< LeveAssignmentType >[] Category;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Category = new LazyRow< LeveAssignmentType >[ 8 ];
            for( var i = 0; i < 8; i++ )
                Category[ i ] = new LazyRow< LeveAssignmentType >( lumina, parser.ReadColumn< int >( 0 + i ), language );
        }
    }
}