// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PvPTrait", columnHash: 0xdc23efe7 )]
    public partial class PvPTrait : ExcelRow
    {
        
        public LazyRow< Trait > Trait1 { get; set; }
        public LazyRow< Trait > Trait2 { get; set; }
        public LazyRow< Trait > Trait3 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Trait1 = new LazyRow< Trait >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            Trait2 = new LazyRow< Trait >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            Trait3 = new LazyRow< Trait >( gameData, parser.ReadColumn< ushort >( 2 ), language );
        }
    }
}