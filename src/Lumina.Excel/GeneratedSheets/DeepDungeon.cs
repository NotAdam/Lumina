// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeon", columnHash: 0xea7a6143 )]
    public class DeepDungeon : ExcelRow
    {
        
        public LazyRow< DeepDungeonEquipment > AetherpoolArm;
        public LazyRow< DeepDungeonEquipment > AetherpoolArmor;
        public LazyRow< DeepDungeonItem >[] PomanderSlot;
        public LazyRow< DeepDungeonMagicStone >[] MagiciteSlot;
        public SeString Name;
        public LazyRow< ContentFinderCondition > ContentFinderConditionStart;
        public bool Unknown24;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            AetherpoolArm = new LazyRow< DeepDungeonEquipment >( gameData, parser.ReadColumn< byte >( 0 ), language );
            AetherpoolArmor = new LazyRow< DeepDungeonEquipment >( gameData, parser.ReadColumn< byte >( 1 ), language );
            PomanderSlot = new LazyRow< DeepDungeonItem >[ 16 ];
            for( var i = 0; i < 16; i++ )
                PomanderSlot[ i ] = new LazyRow< DeepDungeonItem >( gameData, parser.ReadColumn< byte >( 2 + i ), language );
            MagiciteSlot = new LazyRow< DeepDungeonMagicStone >[ 4 ];
            for( var i = 0; i < 4; i++ )
                MagiciteSlot[ i ] = new LazyRow< DeepDungeonMagicStone >( gameData, parser.ReadColumn< byte >( 18 + i ), language );
            Name = parser.ReadColumn< SeString >( 22 );
            ContentFinderConditionStart = new LazyRow< ContentFinderCondition >( gameData, parser.ReadColumn< ushort >( 23 ), language );
            Unknown24 = parser.ReadColumn< bool >( 24 );
        }
    }
}