// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeapon5Param", columnHash: 0x5eb59ccb )]
    public partial class AnimaWeapon5Param : ExcelRow
    {
        
        public LazyRow< BaseParam > BaseParam { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            BaseParam = new LazyRow< BaseParam >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Name = parser.ReadColumn< SeString >( 1 );
        }
    }
}