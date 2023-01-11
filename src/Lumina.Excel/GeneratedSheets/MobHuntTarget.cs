// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MobHuntTarget", columnHash: 0x83a7f541 )]
    public partial class MobHuntTarget : ExcelRow
    {
        
        public LazyRow< BNpcName > Name { get; set; }
        public LazyRow< Fate > FATE { get; set; }
        public uint Icon { get; set; }
        public LazyRow< Map > TerritoryType { get; set; }
        public LazyRow< PlaceName > PlaceName { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = new LazyRow< BNpcName >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            FATE = new LazyRow< Fate >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            Icon = parser.ReadColumn< uint >( 2 );
            TerritoryType = new LazyRow< Map >( gameData, parser.ReadColumn< ushort >( 3 ), language );
            PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 4 ), language );
        }
    }
}