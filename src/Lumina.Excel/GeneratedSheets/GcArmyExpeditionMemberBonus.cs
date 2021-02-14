// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GcArmyExpeditionMemberBonus", columnHash: 0xde74b4c4 )]
    public class GcArmyExpeditionMemberBonus : ExcelRow
    {
        
        public LazyRow< Race > Race;
        public LazyRow< ClassJob > ClassJob;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Race = new LazyRow< Race >( lumina, parser.ReadColumn< byte >( 0 ), language );
            ClassJob = new LazyRow< ClassJob >( lumina, parser.ReadColumn< byte >( 1 ), language );
        }
    }
}