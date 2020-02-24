namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LogFilter", columnHash: 0x6ef5ba16 )]
    public class LogFilter : IExcelRow
    {
        // column defs from Mon, 24 Feb 2020 17:34:06 GMT

        /* offset: 000c col: 0
         *  name: LogKind
         *  type: 
         */

        /* offset: 0008 col: 1
         *  name: Caster
         *  type: 
         */

        /* offset: 000a col: 2
         *  name: Target
         *  type: 
         */

        /* offset: 000d col: 3
         *  name: Category
         *  type: 
         */

        /* offset: 000e col: 4
         *  name: DisplayOrder
         *  type: 
         */

        /* offset: 000f col: 5
         *  name: Preset
         *  type: 
         */

        /* offset: 0000 col: 6
         *  name: Name
         *  type: 
         */

        /* offset: 0004 col: 7
         *  name: Example
         *  type: 
         */



        // col: 06 offset: 0000
        public string Name;

        // col: 07 offset: 0004
        public string Example;

        // col: 01 offset: 0008
        public ushort Caster;

        // col: 02 offset: 000a
        public ushort Target;

        // col: 00 offset: 000c
        public byte LogKind;

        // col: 03 offset: 000d
        public byte Category;

        // col: 04 offset: 000e
        public byte DisplayOrder;

        // col: 05 offset: 000f
        public byte Preset;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 6 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 7 offset: 0004
            Example = parser.ReadOffset< string >( 0x4 );

            // col: 1 offset: 0008
            Caster = parser.ReadOffset< ushort >( 0x8 );

            // col: 2 offset: 000a
            Target = parser.ReadOffset< ushort >( 0xa );

            // col: 0 offset: 000c
            LogKind = parser.ReadOffset< byte >( 0xc );

            // col: 3 offset: 000d
            Category = parser.ReadOffset< byte >( 0xd );

            // col: 4 offset: 000e
            DisplayOrder = parser.ReadOffset< byte >( 0xe );

            // col: 5 offset: 000f
            Preset = parser.ReadOffset< byte >( 0xf );


        }
    }
}