// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RetainerTaskRandom", columnHash: 0x9ab94c53 )]
    public partial class RetainerTaskRandom : ExcelRow
    {
        
        public SeString Name { get; set; }
        public short Requirement { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Requirement = parser.ReadColumn< short >( 1 );
        }
    }
}