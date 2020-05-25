using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ParamGrow", columnHash: 0x64a92445 )]
    public class ParamGrow : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public int ExpToNext;

        // col: 04 offset: 0004
        public int MpModifier;

        // col: 05 offset: 0008
        public int BaseSpeed;

        // col: 06 offset: 000c
        public int LevelModifier;

        // col: 09 offset: 0010
        public int HuntingLogExpReward;

        // col: 10 offset: 0014
        public int MonsterNoteSeals;

        // col: 03 offset: 0018
        public ushort ScaledQuestXP;

        // col: 08 offset: 001a
        public ushort HpModifier;

        // col: 11 offset: 001c
        public ushort ItemLevelSync;

        // col: 12 offset: 001e
        public ushort ProperDungeon;

        // col: 13 offset: 0020
        public ushort ProperGuildOrder;

        // col: 14 offset: 0022
        public ushort CraftingLevel;

        // col: 01 offset: 0024
        public byte AdditionalActions;

        // col: 02 offset: 0025
        public byte ApplyAction;

        // col: 07 offset: 0026
        public byte QuestExpModifier;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            ExpToNext = parser.ReadOffset< int >( 0x0 );

            // col: 4 offset: 0004
            MpModifier = parser.ReadOffset< int >( 0x4 );

            // col: 5 offset: 0008
            BaseSpeed = parser.ReadOffset< int >( 0x8 );

            // col: 6 offset: 000c
            LevelModifier = parser.ReadOffset< int >( 0xc );

            // col: 9 offset: 0010
            HuntingLogExpReward = parser.ReadOffset< int >( 0x10 );

            // col: 10 offset: 0014
            MonsterNoteSeals = parser.ReadOffset< int >( 0x14 );

            // col: 3 offset: 0018
            ScaledQuestXP = parser.ReadOffset< ushort >( 0x18 );

            // col: 8 offset: 001a
            HpModifier = parser.ReadOffset< ushort >( 0x1a );

            // col: 11 offset: 001c
            ItemLevelSync = parser.ReadOffset< ushort >( 0x1c );

            // col: 12 offset: 001e
            ProperDungeon = parser.ReadOffset< ushort >( 0x1e );

            // col: 13 offset: 0020
            ProperGuildOrder = parser.ReadOffset< ushort >( 0x20 );

            // col: 14 offset: 0022
            CraftingLevel = parser.ReadOffset< ushort >( 0x22 );

            // col: 1 offset: 0024
            AdditionalActions = parser.ReadOffset< byte >( 0x24 );

            // col: 2 offset: 0025
            ApplyAction = parser.ReadOffset< byte >( 0x25 );

            // col: 7 offset: 0026
            QuestExpModifier = parser.ReadOffset< byte >( 0x26 );


        }
    }
}