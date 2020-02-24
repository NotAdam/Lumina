namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ScreenImage", columnHash: 0xf03c70eb )]
    public class ScreenImage : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Image
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Jingle
         *  type: 
         */

        /* offset: 0006 col: 2
         *  name: Type
         *  type: 
         */

        /* offset: 0007 col: 3
         *  name: Lang
         *  type: 
         */



        // col: 00 offset: 0000
        public uint Image;

        // col: 01 offset: 0004
        public short Jingle;

        // col: 02 offset: 0006
        public sbyte Type;

        // col: 03 offset: 0007
        private byte packed7;
        public bool Lang => ( packed7 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Image = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            Jingle = parser.ReadOffset< short >( 0x4 );

            // col: 2 offset: 0006
            Type = parser.ReadOffset< sbyte >( 0x6 );

            // col: 3 offset: 0007
            packed7 = parser.ReadOffset< byte >( 0x7 );


        }
    }
}