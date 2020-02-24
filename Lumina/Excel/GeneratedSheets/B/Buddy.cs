namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Buddy", columnHash: 0xd2892cc5 )]
    public class Buddy : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 001c col: 0
         *  name: Base
         *  type: 
         */

        /* offset: 0010 col: 1
         *  name: QuestRequirement{2}
         *  type: 
         */

        /* offset: 0014 col: 2
         *  name: QuestRequirement{1}
         *  type: 
         */

        /* offset: 0018 col: 3
         *  name: BaseEquip
         *  type: 
         */

        /* offset: 0000 col: 4
         *  name: SoundEffect{4}
         *  type: 
         */

        /* offset: 0004 col: 5
         *  name: SoundEffect{3}
         *  type: 
         */

        /* offset: 0008 col: 6
         *  name: SoundEffect{2}
         *  type: 
         */

        /* offset: 000c col: 7
         *  name: SoundEffect{1}
         *  type: 
         */



        // col: 04 offset: 0000
        public string SoundEffect4;

        // col: 05 offset: 0004
        public string SoundEffect3;

        // col: 06 offset: 0008
        public string SoundEffect2;

        // col: 07 offset: 000c
        public string SoundEffect1;

        // col: 01 offset: 0010
        public int QuestRequirement2;

        // col: 02 offset: 0014
        public int QuestRequirement1;

        // col: 03 offset: 0018
        public int BaseEquip;

        // col: 00 offset: 001c
        public byte Base;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            SoundEffect4 = parser.ReadOffset< string >( 0x0 );

            // col: 5 offset: 0004
            SoundEffect3 = parser.ReadOffset< string >( 0x4 );

            // col: 6 offset: 0008
            SoundEffect2 = parser.ReadOffset< string >( 0x8 );

            // col: 7 offset: 000c
            SoundEffect1 = parser.ReadOffset< string >( 0xc );

            // col: 1 offset: 0010
            QuestRequirement2 = parser.ReadOffset< int >( 0x10 );

            // col: 2 offset: 0014
            QuestRequirement1 = parser.ReadOffset< int >( 0x14 );

            // col: 3 offset: 0018
            BaseEquip = parser.ReadOffset< int >( 0x18 );

            // col: 0 offset: 001c
            Base = parser.ReadOffset< byte >( 0x1c );


        }
    }
}