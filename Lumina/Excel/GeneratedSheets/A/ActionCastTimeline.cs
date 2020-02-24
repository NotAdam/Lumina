namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionCastTimeline", columnHash: 0x2020acf6 )]
    public class ActionCastTimeline : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Name
         *  type: 
         */

        /* offset: 0002 col: 1
         *  name: VFX
         *  type: 
         */



        // col: 00 offset: 0000
        public ushort Name;

        // col: 01 offset: 0002
        public ushort VFX;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< ushort >( 0x0 );

            // col: 1 offset: 0002
            VFX = parser.ReadOffset< ushort >( 0x2 );


        }
    }
}