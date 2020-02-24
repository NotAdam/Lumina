namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BuddySkill", columnHash: 0xe3220ddc )]
    public class BuddySkill : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0006 col: 0
         *  name: BuddyLevel
         *  type: 
         */

        /* offset: 0007 col: 1
         *  name: IsActive
         *  type: 
         */

        /* offset: 0000 col: 2
         *  name: Defender
         *  type: 
         */

        /* offset: 0002 col: 3
         *  name: Attacker
         *  type: 
         */

        /* offset: 0004 col: 4
         *  name: Healer
         *  type: 
         */



        // col: 02 offset: 0000
        public ushort Defender;

        // col: 03 offset: 0002
        public ushort Attacker;

        // col: 04 offset: 0004
        public ushort Healer;

        // col: 00 offset: 0006
        public byte BuddyLevel;

        // col: 01 offset: 0007
        private byte packed7;
        public bool IsActive => ( packed7 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            Defender = parser.ReadOffset< ushort >( 0x0 );

            // col: 3 offset: 0002
            Attacker = parser.ReadOffset< ushort >( 0x2 );

            // col: 4 offset: 0004
            Healer = parser.ReadOffset< ushort >( 0x4 );

            // col: 0 offset: 0006
            BuddyLevel = parser.ReadOffset< byte >( 0x6 );

            // col: 1 offset: 0007
            packed7 = parser.ReadOffset< byte >( 0x7 );


        }
    }
}