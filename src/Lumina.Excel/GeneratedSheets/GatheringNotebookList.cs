// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringNotebookList", columnHash: 0x1da7bb26 )]
    public partial class GatheringNotebookList : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public LazyRow< GatheringItem >[] GatheringItem { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            GatheringItem = new LazyRow< GatheringItem >[ 100 ];
            for( var i = 0; i < 100; i++ )
                GatheringItem[ i ] = new LazyRow< GatheringItem >( gameData, parser.ReadColumn< int >( 1 + i ), language );
        }
    }
}