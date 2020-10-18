// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuildleveAssignmentCategory", columnHash: 0xeb15b554 )]
    public class GuildleveAssignmentCategory : IExcelRow
    {
        
        public LazyRow< LeveAssignmentType >[] Category;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Category = new LazyRow< LeveAssignmentType >[ 8 ];
            for( var i = 0; i < 8; i++ )
                Category[ i ] = new LazyRow< LeveAssignmentType >( lumina, parser.ReadColumn< int >( 0 + i ), language );
        }
    }
}