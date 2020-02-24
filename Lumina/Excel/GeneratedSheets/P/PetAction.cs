namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PetAction", columnHash: 0x5e492849 )]
    public class PetAction : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Name
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Description
         *  type: 
         */

        /* offset: 0008 col: 2
         *  name: Icon
         *  type: 
         */

        /* offset: 000c col: 3
         *  name: Action
         *  type: 
         */

        /* offset: 000e col: 4
         *  name: Pet
         *  type: 
         */

        /* offset: 000f col: 5
         *  name: MasterOrder
         *  type: 
         */

        /* offset: 000f col: 6
         *  name: DisableOrder
         *  type: 
         */

        /* offset: 000f col: 7
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public string Description;

        // col: 02 offset: 0008
        public int Icon;

        // col: 03 offset: 000c
        public ushort Action;

        // col: 04 offset: 000e
        public byte Pet;

        // col: 05 offset: 000f
        private byte packedf;
        public bool MasterOrder => ( packedf & 0x1 ) == 0x1;
        public bool DisableOrder => ( packedf & 0x2 ) == 0x2;
        public bool packedf_4 => ( packedf & 0x4 ) == 0x4;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Description = parser.ReadOffset< string >( 0x4 );

            // col: 2 offset: 0008
            Icon = parser.ReadOffset< int >( 0x8 );

            // col: 3 offset: 000c
            Action = parser.ReadOffset< ushort >( 0xc );

            // col: 4 offset: 000e
            Pet = parser.ReadOffset< byte >( 0xe );

            // col: 5 offset: 000f
            packedf = parser.ReadOffset< byte >( 0xf );


        }
    }
}