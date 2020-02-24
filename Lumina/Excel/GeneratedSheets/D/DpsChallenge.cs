using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DpsChallenge", columnHash: 0x944cf024 )]
    public class DpsChallenge : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 04 offset: 0000
        public string Name;

        // col: 05 offset: 0004
        public string Description;

        // col: 02 offset: 0008
        public uint Icon;

        // col: 00 offset: 000c
        public ushort PlayerLevel;

        // col: 01 offset: 000e
        public ushort PlaceName;

        // col: 03 offset: 0010
        public ushort Order;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 5 offset: 0004
            Description = parser.ReadOffset< string >( 0x4 );

            // col: 2 offset: 0008
            Icon = parser.ReadOffset< uint >( 0x8 );

            // col: 0 offset: 000c
            PlayerLevel = parser.ReadOffset< ushort >( 0xc );

            // col: 1 offset: 000e
            PlaceName = parser.ReadOffset< ushort >( 0xe );

            // col: 3 offset: 0010
            Order = parser.ReadOffset< ushort >( 0x10 );


        }
    }
}