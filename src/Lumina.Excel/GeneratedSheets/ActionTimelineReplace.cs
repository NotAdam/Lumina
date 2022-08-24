// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionTimelineReplace", columnHash: 0x2020acf6 )]
    public partial class ActionTimelineReplace : ExcelRow
    {
        
        public LazyRow< ActionTimeline > Old { get; set; }
        public LazyRow< ActionTimeline > New { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Old = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            New = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 1 ), language );
        }
    }
}