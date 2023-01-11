// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonLayer", columnHash: 0x832a5a83 )]
    public partial class DeepDungeonLayer : ExcelRow
    {
        
        public LazyRow< DeepDungeon > DeepDungeon { get; set; }
        public byte FloorSet { get; set; }
        public LazyRow< DeepDungeonMap5X > RoomA { get; set; }
        public LazyRow< DeepDungeonMap5X > RoomB { get; set; }
        public LazyRow< DeepDungeonMap5X > RoomC { get; set; }
        public byte WepMinLv { get; set; }
        public byte ArmourMinLv { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            DeepDungeon = new LazyRow< DeepDungeon >( gameData, parser.ReadColumn< byte >( 0 ), language );
            FloorSet = parser.ReadColumn< byte >( 1 );
            RoomA = new LazyRow< DeepDungeonMap5X >( gameData, parser.ReadColumn< ushort >( 2 ), language );
            RoomB = new LazyRow< DeepDungeonMap5X >( gameData, parser.ReadColumn< ushort >( 3 ), language );
            RoomC = new LazyRow< DeepDungeonMap5X >( gameData, parser.ReadColumn< ushort >( 4 ), language );
            WepMinLv = parser.ReadColumn< byte >( 5 );
            ArmourMinLv = parser.ReadColumn< byte >( 6 );
        }
    }
}