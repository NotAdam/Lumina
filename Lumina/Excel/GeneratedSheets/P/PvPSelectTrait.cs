namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PvPSelectTrait", columnHash: 0xbddf8130 )]
    public class PvPSelectTrait : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Effect
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Icon
         *  type: 
         */

        /* offset: 0008 col: 2
         *  name: Value
         *  type: 
         */



        // col: 00 offset: 0000
        public string Effect;

        // col: 01 offset: 0004
        public uint Icon;

        // col: 02 offset: 0008
        public short Value;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Effect = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Icon = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            Value = parser.ReadOffset< short >( 0x8 );


        }
    }
}