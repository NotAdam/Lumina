// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Balloon", columnHash: 0x9d1b5f4b )]
    public partial class Balloon : ExcelRow
    {
        
        public bool Slowly { get; set; }
        public SeString Dialogue { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Slowly = parser.ReadColumn< bool >( 0 );
            Dialogue = parser.ReadColumn< SeString >( 1 );
        }
    }
}