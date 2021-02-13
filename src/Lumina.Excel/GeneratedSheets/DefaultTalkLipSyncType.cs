// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DefaultTalkLipSyncType", columnHash: 0xda365c51 )]
    public class DefaultTalkLipSyncType : ExcelRow
    {
        
        public LazyRow< ActionTimeline > ActionTimeline;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            ActionTimeline = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< int >( 0 ), language );
        }
    }
}