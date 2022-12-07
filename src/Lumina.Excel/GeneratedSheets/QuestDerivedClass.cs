// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestDerivedClass", columnHash: 0x7c36f3d1 )]
    public partial class QuestDerivedClass : ExcelRow
    {
        
        public LazyRow< ClassJob > ClassJob { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadColumn< byte >( 0 ), language );
        }
    }
}