// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuildleveAssignmentCategory", columnHash: 0xeb15b554 )]
    public partial class GuildleveAssignmentCategory : ExcelRow
    {
        
        public LazyRow< LeveAssignmentType >[] Category { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Category = new LazyRow< LeveAssignmentType >[ 8 ];
            for( var i = 0; i < 8; i++ )
                Category[ i ] = new LazyRow< LeveAssignmentType >( gameData, parser.ReadColumn< int >( 0 + i ), language );
        }
    }
}