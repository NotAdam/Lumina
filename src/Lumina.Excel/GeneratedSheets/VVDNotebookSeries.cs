// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "VVDNotebookSeries", columnHash: 0x1b4af395 )]
    public partial class VVDNotebookSeries : ExcelRow
    {
        
        public SeString Name { get; set; }
        public LazyRow< VVDNotebookContents >[] Contents { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Contents = new LazyRow< VVDNotebookContents >[ 12 ];
            for( var i = 0; i < 12; i++ )
                Contents[ i ] = new LazyRow< VVDNotebookContents >( gameData, parser.ReadColumn< int >( 1 + i ), language );
        }
    }
}