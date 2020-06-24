using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ParamGrow", columnHash: 0x64a92445 )]
    public class ParamGrow : IExcelRow
    {
        
        public int ExpToNext;
        public byte AdditionalActions;
        public byte ApplyAction;
        public ushort ScaledQuestXP;
        public int MpModifier;
        public int BaseSpeed;
        public int LevelModifier;
        public byte QuestExpModifier;
        public ushort HpModifier;
        public int HuntingLogExpReward;
        public int MonsterNoteSeals;
        public ushort ItemLevelSync;
        public ushort ProperDungeon;
        public ushort ProperGuildOrder;
        public ushort CraftingLevel;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ExpToNext = parser.ReadColumn< int >( 0 );
            AdditionalActions = parser.ReadColumn< byte >( 1 );
            ApplyAction = parser.ReadColumn< byte >( 2 );
            ScaledQuestXP = parser.ReadColumn< ushort >( 3 );
            MpModifier = parser.ReadColumn< int >( 4 );
            BaseSpeed = parser.ReadColumn< int >( 5 );
            LevelModifier = parser.ReadColumn< int >( 6 );
            QuestExpModifier = parser.ReadColumn< byte >( 7 );
            HpModifier = parser.ReadColumn< ushort >( 8 );
            HuntingLogExpReward = parser.ReadColumn< int >( 9 );
            MonsterNoteSeals = parser.ReadColumn< int >( 10 );
            ItemLevelSync = parser.ReadColumn< ushort >( 11 );
            ProperDungeon = parser.ReadColumn< ushort >( 12 );
            ProperGuildOrder = parser.ReadColumn< ushort >( 13 );
            CraftingLevel = parser.ReadColumn< ushort >( 14 );
        }
    }
}