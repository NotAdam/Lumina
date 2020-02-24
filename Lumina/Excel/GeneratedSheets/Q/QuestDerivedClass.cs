namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestDerivedClass", columnHash: 0x5a516458 )]
    public class QuestDerivedClass : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Quest
         *  type: 
         */

        /* offset: 0004 col: 1
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public uint Quest;

        // col: 01 offset: 0004
        public byte unknown4;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Quest = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            unknown4 = parser.ReadOffset< byte >( 0x4 );


        }
    }
}