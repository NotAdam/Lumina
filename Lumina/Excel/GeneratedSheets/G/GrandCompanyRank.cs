namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GrandCompanyRank", columnHash: 0x939f7424 )]
    public class GrandCompanyRank : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0020 col: 0
         *  name: Tier
         *  type: 
         */

        /* offset: 0021 col: 1
         *  name: Order
         *  type: 
         */

        /* offset: 0000 col: 2
         *  name: MaxSeals
         *  type: 
         */

        /* offset: 0004 col: 3
         *  name: RequiredSeals
         *  type: 
         */

        /* offset: 0008 col: 4
         *  name: Icon{Maelstrom}
         *  type: 
         */

        /* offset: 000c col: 5
         *  name: Icon{Serpents}
         *  type: 
         */

        /* offset: 0010 col: 6
         *  name: Icon{Flames}
         *  type: 
         */

        /* offset: 0014 col: 7
         *  name: Quest{Maelstrom}
         *  type: 
         */

        /* offset: 0018 col: 8
         *  name: Quest{Serpents}
         *  type: 
         */

        /* offset: 001c col: 9
         *  name: Quest{Flames}
         *  type: 
         */

        /* offset: 0022 col: 10
         *  no SaintCoinach definition found
         */



        // col: 02 offset: 0000
        public uint MaxSeals;

        // col: 03 offset: 0004
        public uint RequiredSeals;

        // col: 04 offset: 0008
        public int IconMaelstrom;

        // col: 05 offset: 000c
        public int IconSerpents;

        // col: 06 offset: 0010
        public int IconFlames;

        // col: 07 offset: 0014
        public int QuestMaelstrom;

        // col: 08 offset: 0018
        public int QuestSerpents;

        // col: 09 offset: 001c
        public int QuestFlames;

        // col: 00 offset: 0020
        public byte Tier;

        // col: 01 offset: 0021
        public byte Order;

        // col: 10 offset: 0022
        public byte unknown22;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            MaxSeals = parser.ReadOffset< uint >( 0x0 );

            // col: 3 offset: 0004
            RequiredSeals = parser.ReadOffset< uint >( 0x4 );

            // col: 4 offset: 0008
            IconMaelstrom = parser.ReadOffset< int >( 0x8 );

            // col: 5 offset: 000c
            IconSerpents = parser.ReadOffset< int >( 0xc );

            // col: 6 offset: 0010
            IconFlames = parser.ReadOffset< int >( 0x10 );

            // col: 7 offset: 0014
            QuestMaelstrom = parser.ReadOffset< int >( 0x14 );

            // col: 8 offset: 0018
            QuestSerpents = parser.ReadOffset< int >( 0x18 );

            // col: 9 offset: 001c
            QuestFlames = parser.ReadOffset< int >( 0x1c );

            // col: 0 offset: 0020
            Tier = parser.ReadOffset< byte >( 0x20 );

            // col: 1 offset: 0021
            Order = parser.ReadOffset< byte >( 0x21 );

            // col: 10 offset: 0022
            unknown22 = parser.ReadOffset< byte >( 0x22 );


        }
    }
}