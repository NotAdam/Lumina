// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeaponTimeline", columnHash: 0x9ab94c53 )]
    public class WeaponTimeline : ExcelRow
    {
        
        public SeString File { get; set; }
        public short NextWeaponTimeline { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            File = parser.ReadColumn< SeString >( 0 );
            NextWeaponTimeline = parser.ReadColumn< short >( 1 );
        }
    }
}