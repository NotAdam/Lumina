// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingEmploymentNpcRace", columnHash: 0xd70d6cc8 )]
    public partial class HousingEmploymentNpcRace : ExcelRow
    {
        
        public SeString Race { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Race = parser.ReadColumn< SeString >( 0 );
        }
    }
}