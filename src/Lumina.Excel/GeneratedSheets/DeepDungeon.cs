// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeon", columnHash: 0x2b582528 )]
    public partial class DeepDungeon : ExcelRow
    {
        
        public LazyRow< DeepDungeonEquipment > AetherpoolArm { get; set; }
        public LazyRow< DeepDungeonEquipment > AetherpoolArmor { get; set; }
        public LazyRow< DeepDungeonItem >[] PomanderSlot { get; set; }
        public LazyRow< DeepDungeonMagicStone >[] MagiciteSlot { get; set; }
        public SeString Name { get; set; }
        public LazyRow< ContentFinderCondition > ContentFinderConditionStart { get; set; }
        public bool Unknown25 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            AetherpoolArm = new LazyRow< DeepDungeonEquipment >( gameData, parser.ReadColumn< byte >( 0 ), language );
            AetherpoolArmor = new LazyRow< DeepDungeonEquipment >( gameData, parser.ReadColumn< byte >( 1 ), language );
            PomanderSlot = new LazyRow< DeepDungeonItem >[ 16 ];
            for( var i = 0; i < 16; i++ )
                PomanderSlot[ i ] = new LazyRow< DeepDungeonItem >( gameData, parser.ReadColumn< byte >( 2 + i ), language );
            MagiciteSlot = new LazyRow< DeepDungeonMagicStone >[ 5 ];
            for( var i = 0; i < 5; i++ )
                MagiciteSlot[ i ] = new LazyRow< DeepDungeonMagicStone >( gameData, parser.ReadColumn< byte >( 18 + i ), language );
            Name = parser.ReadColumn< SeString >( 23 );
            ContentFinderConditionStart = new LazyRow< ContentFinderCondition >( gameData, parser.ReadColumn< ushort >( 24 ), language );
            Unknown25 = parser.ReadColumn< bool >( 25 );
        }
    }
}