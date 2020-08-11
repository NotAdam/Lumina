// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeon", columnHash: 0xea7a6143 )]
    public class DeepDungeon : IExcelRow
    {
        
        public LazyRow< DeepDungeonEquipment > AetherpoolArm;
        public LazyRow< DeepDungeonEquipment > AetherpoolArmor;
        public LazyRow< DeepDungeonItem >[] PomanderSlot;
        public LazyRow< DeepDungeonMagicStone >[] MagiciteSlot;
        public string Name;
        public LazyRow< ContentFinderCondition > ContentFinderConditionStart;
        public bool Unknown24;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            AetherpoolArm = new LazyRow< DeepDungeonEquipment >( lumina, parser.ReadColumn< byte >( 0 ), language );
            AetherpoolArmor = new LazyRow< DeepDungeonEquipment >( lumina, parser.ReadColumn< byte >( 1 ), language );
            PomanderSlot = new LazyRow< DeepDungeonItem >[ 16 ];
            for( var i = 0; i < 16; i++ )
                PomanderSlot[ i ] = new LazyRow< DeepDungeonItem >( lumina, parser.ReadColumn< byte >( 2 + i ), language );
            MagiciteSlot = new LazyRow< DeepDungeonMagicStone >[ 4 ];
            for( var i = 0; i < 4; i++ )
                MagiciteSlot[ i ] = new LazyRow< DeepDungeonMagicStone >( lumina, parser.ReadColumn< byte >( 18 + i ), language );
            Name = parser.ReadColumn< string >( 22 );
            ContentFinderConditionStart = new LazyRow< ContentFinderCondition >( lumina, parser.ReadColumn< ushort >( 23 ), language );
            Unknown24 = parser.ReadColumn< bool >( 24 );
        }
    }
}