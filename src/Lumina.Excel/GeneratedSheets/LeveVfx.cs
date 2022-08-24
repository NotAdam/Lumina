// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LeveVfx", columnHash: 0x993d983d )]
    public partial class LeveVfx : ExcelRow
    {
        
        public SeString Effect { get; set; }
        public int Icon { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Effect = parser.ReadColumn< SeString >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
        }
    }
}