// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DefaultTalkLipSyncType", columnHash: 0xda365c51 )]
    public partial class DefaultTalkLipSyncType : ExcelRow
    {
        
        public LazyRow< ActionTimeline > ActionTimeline { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ActionTimeline = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< int >( 0 ), language );
        }
    }
}