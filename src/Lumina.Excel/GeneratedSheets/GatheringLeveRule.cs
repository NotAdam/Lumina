// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringLeveRule", columnHash: 0xaed1d46c )]
    public partial class GatheringLeveRule : ExcelRow
    {
        
        public SeString Rule { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Rule = parser.ReadColumn< SeString >( 0 );
        }
    }
}