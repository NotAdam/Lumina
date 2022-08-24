// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyLeveRule", columnHash: 0xcc3ad729 )]
    public partial class CompanyLeveRule : ExcelRow
    {
        
        public SeString Type { get; set; }
        public LazyRow< LeveString > Objective { get; set; }
        public LazyRow< LeveString > Help { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Type = parser.ReadColumn< SeString >( 0 );
            Objective = new LazyRow< LeveString >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            Help = new LazyRow< LeveString >( gameData, parser.ReadColumn< ushort >( 2 ), language );
        }
    }
}