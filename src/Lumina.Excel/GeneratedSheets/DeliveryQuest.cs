// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeliveryQuest", columnHash: 0xda365c51 )]
    public class DeliveryQuest : ExcelRow
    {
        
        public LazyRow< Quest > Quest;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< int >( 0 ), language );
        }
    }
}