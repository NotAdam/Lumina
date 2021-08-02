// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GcArmyEquipPreset", columnHash: 0x5a4de23a )]
    public partial class GcArmyEquipPreset : ExcelRow
    {
        
        public LazyRow< Item > MainHand { get; set; }
        public LazyRow< Item > OffHand { get; set; }
        public LazyRow< Item > Head { get; set; }
        public LazyRow< Item > Body { get; set; }
        public LazyRow< Item > Gloves { get; set; }
        public LazyRow< Item > Legs { get; set; }
        public LazyRow< Item > Feet { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            MainHand = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 0 ), language );
            OffHand = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 1 ), language );
            Head = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 2 ), language );
            Body = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 3 ), language );
            Gloves = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 4 ), language );
            Legs = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 5 ), language );
            Feet = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 6 ), language );
        }
    }
}