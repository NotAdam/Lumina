// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestDerivedClass", columnHash: 0xdcfd9eba )]
    public class QuestDerivedClass : ExcelRow
    {
        
        public LazyRow< ClassJob > ClassJob;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            ClassJob = new LazyRow< ClassJob >( lumina, parser.ReadColumn< byte >( 0 ), language );
        }
    }
}