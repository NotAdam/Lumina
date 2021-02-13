// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestRepeatFlag", columnHash: 0xdbf43666 )]
    public class QuestRepeatFlag : ExcelRow
    {
        
        public LazyRow< Quest > Quest;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 0 ), language );
        }
    }
}