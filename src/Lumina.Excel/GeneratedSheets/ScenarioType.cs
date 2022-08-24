// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ScenarioType", columnHash: 0x9e3430e1 )]
    public partial class ScenarioType : ExcelRow
    {
        
        public SeString Type { get; set; }
        public sbyte Unknown1 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Type = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< sbyte >( 1 );
        }
    }
}