// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventItemTimeline", columnHash: 0xdbf43666 )]
    public partial class EventItemTimeline : ExcelRow
    {
        
        public LazyRow< ActionTimeline > ActionTimeline { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ActionTimeline = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< uint >( 0 ), language );
        }
    }
}