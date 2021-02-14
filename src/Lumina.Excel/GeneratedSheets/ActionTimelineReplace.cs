// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionTimelineReplace", columnHash: 0x2020acf6 )]
    public class ActionTimelineReplace : ExcelRow
    {
        
        public LazyRow< ActionTimeline > Old;
        public LazyRow< ActionTimeline > New;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Old = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            New = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 1 ), language );
        }
    }
}