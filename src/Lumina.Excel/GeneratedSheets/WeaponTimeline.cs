// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeaponTimeline", columnHash: 0x7f718689 )]
    public partial class WeaponTimeline : ExcelRow
    {
        
        public SeString File { get; set; }
        public short NextWeaponTimeline { get; set; }
        public bool Unknown2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            File = parser.ReadColumn< SeString >( 0 );
            NextWeaponTimeline = parser.ReadColumn< short >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
        }
    }
}