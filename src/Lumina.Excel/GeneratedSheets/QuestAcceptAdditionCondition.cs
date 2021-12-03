// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestAcceptAdditionCondition", columnHash: 0x801aa490 )]
    public partial class QuestAcceptAdditionCondition : ExcelRow
    {
        
        public LazyRow< Quest > Requirement0 { get; set; }
        public LazyRow< Quest > Requirement1 { get; set; }
        public bool Unknown2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Requirement0 = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Requirement1 = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 1 ), language );
            Unknown2 = parser.ReadColumn< bool >( 2 );
        }
    }
}