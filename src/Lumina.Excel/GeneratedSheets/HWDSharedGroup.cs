// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDSharedGroup", columnHash: 0x5a516458 )]
    public class HWDSharedGroup : ExcelRow
    {
        
        public uint LGB { get; set; }
        public LazyRow< HWDSharedGroupControlParam > Param { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            LGB = parser.ReadColumn< uint >( 0 );
            Param = new LazyRow< HWDSharedGroupControlParam >( gameData, parser.ReadColumn< byte >( 1 ), language );
        }
    }
}