// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventItemTimeline", columnHash: 0xdbf43666 )]
    public class EventItemTimeline : ExcelRow
    {
        
        public LazyRow< ActionTimeline > ActionTimeline;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            ActionTimeline = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< uint >( 0 ), language );
        }
    }
}