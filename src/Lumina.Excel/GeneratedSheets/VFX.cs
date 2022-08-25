// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "VFX", columnHash: 0xc3e55322 )]
    public partial class VFX : ExcelRow
    {
        
        public SeString Location { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Location = parser.ReadColumn< SeString >( 0 );
        }
    }
}