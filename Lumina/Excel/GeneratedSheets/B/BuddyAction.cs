using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BuddyAction", columnHash: 0x9a695bec )]
    public class BuddyAction : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public string Description;

        // col: 02 offset: 0008
        public int Icon;

        // col: 03 offset: 000c
        public int IconStatus;

        // col: 04 offset: 0010
        public ushort Reward;

        // col: 05 offset: 0012
        public byte Sort;


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
            IconStatus = parser.ReadOffset< int >( 0xc );

            // col: 4 offset: 0010
            Reward = parser.ReadOffset< ushort >( 0x10 );

            // col: 5 offset: 0012
            Sort = parser.ReadOffset< byte >( 0x12 );


        }
    }
}