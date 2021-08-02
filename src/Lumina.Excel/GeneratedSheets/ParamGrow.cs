// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ParamGrow", columnHash: 0x64a92445 )]
    public partial class ParamGrow : ExcelRow
    {
        
        public int ExpToNext { get; set; }
        public byte AdditionalActions { get; set; }
        public byte ApplyAction { get; set; }
        public ushort ScaledQuestXP { get; set; }
        public int MpModifier { get; set; }
        public int BaseSpeed { get; set; }
        public int LevelModifier { get; set; }
        public byte QuestExpModifier { get; set; }
        public ushort HpModifier { get; set; }
        public int HuntingLogExpReward { get; set; }
        public int MonsterNoteSeals { get; set; }
        public ushort ItemLevelSync { get; set; }
        public ushort ProperDungeon { get; set; }
        public ushort ProperGuildOrder { get; set; }
        public ushort CraftingLevel { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

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