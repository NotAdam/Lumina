using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingAppeal", columnHash: 0xb89097b5 )]
    public class HousingAppeal : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Tag;

        // col: 01 offset: 0004
        public uint Icon;

        // col: 02 offset: 0008
        public byte Order;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Tag = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Icon = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            Order = parser.ReadOffset< byte >( 0x8 );


        }
    }
}