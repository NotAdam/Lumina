namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WarpCondition", columnHash: 0xc096f9d0 )]
    public class WarpCondition : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0010 col: 0
         *  name: Gil
         *  type: 
         */

        /* offset: 0016 col: 1
         *  name: CompleteParam
         *  type: 
         */

        /* offset: 0000 col: 2
         *  name: RequiredQuest{1}
         *  type: 
         */

        /* offset: 0004 col: 3
         *  name: RequiredQuest{2}
         *  type: 
         */

        /* offset: 0008 col: 4
         *  name: DRequiredQuest{3}
         *  type: 
         */

        /* offset: 000c col: 5
         *  name: RequiredQuest{4}
         *  type: 
         */

        /* offset: 0012 col: 6
         *  name: QuestReward
         *  type: 
         */

        /* offset: 0014 col: 7
         *  name: Class{Level}
         *  type: 
         */



        // col: 02 offset: 0000
        public uint RequiredQuest1;

        // col: 03 offset: 0004
        public uint RequiredQuest2;

        // col: 04 offset: 0008
        public uint DRequiredQuest3;

        // col: 05 offset: 000c
        public uint RequiredQuest4;

        // col: 00 offset: 0010
        public ushort Gil;

        // col: 06 offset: 0012
        public ushort QuestReward;

        // col: 07 offset: 0014
        public ushort ClassLevel;

        // col: 01 offset: 0016
        public byte CompleteParam;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            RequiredQuest1 = parser.ReadOffset< uint >( 0x0 );

            // col: 3 offset: 0004
            RequiredQuest2 = parser.ReadOffset< uint >( 0x4 );

            // col: 4 offset: 0008
            DRequiredQuest3 = parser.ReadOffset< uint >( 0x8 );

            // col: 5 offset: 000c
            RequiredQuest4 = parser.ReadOffset< uint >( 0xc );

            // col: 0 offset: 0010
            Gil = parser.ReadOffset< ushort >( 0x10 );

            // col: 6 offset: 0012
            QuestReward = parser.ReadOffset< ushort >( 0x12 );

            // col: 7 offset: 0014
            ClassLevel = parser.ReadOffset< ushort >( 0x14 );

            // col: 1 offset: 0016
            CompleteParam = parser.ReadOffset< byte >( 0x16 );


        }
    }
}