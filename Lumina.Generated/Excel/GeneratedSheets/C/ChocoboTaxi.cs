using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboTaxi", columnHash: 0x121fc5dc )]
    public class ChocoboTaxi : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public uint Location;

        // col: 02 offset: 0004
        public ushort TimeRequired;

        // col: 01 offset: 0006
        public byte Fare;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Location = parser.ReadOffset< uint >( 0x0 );

            // col: 2 offset: 0004
            TimeRequired = parser.ReadOffset< ushort >( 0x4 );

            // col: 1 offset: 0006
            Fare = parser.ReadOffset< byte >( 0x6 );


        }
    }
}