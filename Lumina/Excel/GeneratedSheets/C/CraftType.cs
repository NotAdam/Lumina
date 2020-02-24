namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CraftType", columnHash: 0xb92c9b70 )]
    public class CraftType : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0004 col: 0
         *  name: MainPhysical
         *  type: 
         */

        /* offset: 0005 col: 1
         *  name: SubPhysical
         *  type: 
         */

        /* offset: 0000 col: 2
         *  name: Name
         *  type: 
         */



        // col: 02 offset: 0000
        public string Name;

        // col: 00 offset: 0004
        public byte MainPhysical;

        // col: 01 offset: 0005
        public byte SubPhysical;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 0 offset: 0004
            MainPhysical = parser.ReadOffset< byte >( 0x4 );

            // col: 1 offset: 0005
            SubPhysical = parser.ReadOffset< byte >( 0x5 );


        }
    }
}