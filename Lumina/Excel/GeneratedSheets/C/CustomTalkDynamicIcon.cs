namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CustomTalkDynamicIcon", columnHash: 0x5d58cc84 )]
    public class CustomTalkDynamicIcon : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: SmallIcon
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: LargeIcon
         *  type: 
         */



        // col: 00 offset: 0000
        public uint SmallIcon;

        // col: 01 offset: 0004
        public uint LargeIcon;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            SmallIcon = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            LargeIcon = parser.ReadOffset< uint >( 0x4 );


        }
    }
}