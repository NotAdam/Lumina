// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GcArmyExpeditionMemberBonus", columnHash: 0xde74b4c4 )]
    public partial class GcArmyExpeditionMemberBonus : ExcelRow
    {
        
        public LazyRow< Race > Race { get; set; }
        public LazyRow< ClassJob > ClassJob { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Race = new LazyRow< Race >( gameData, parser.ReadColumn< byte >( 0 ), language );
            ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadColumn< byte >( 1 ), language );
        }
    }
}