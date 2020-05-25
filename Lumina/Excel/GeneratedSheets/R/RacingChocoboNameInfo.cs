using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RacingChocoboNameInfo", columnHash: 0x171828cf )]
    public class RacingChocoboNameInfo : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 05 offset: 0000
        public ushort unknown0;

        // col: 06 offset: 0002
        public ushort unknown2;

        // col: 07 offset: 0004
        public ushort unknown4;

        // col: 00 offset: 0006
        public byte RacingChocoboNameCategory;

        // col: 01 offset: 0007
        public bool unknown7;

        // col: 02 offset: 0008
        public bool unknown8;

        // col: 03 offset: 0009
        public bool unknown9;

        // col: 04 offset: 000a
        public bool unknowna;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 5 offset: 0000
            unknown0 = parser.ReadOffset< ushort >( 0x0 );

            // col: 6 offset: 0002
            unknown2 = parser.ReadOffset< ushort >( 0x2 );

            // col: 7 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );

            // col: 0 offset: 0006
            RacingChocoboNameCategory = parser.ReadOffset< byte >( 0x6 );

            // col: 1 offset: 0007
            unknown7 = parser.ReadOffset< bool >( 0x7 );

            // col: 2 offset: 0008
            unknown8 = parser.ReadOffset< bool >( 0x8 );

            // col: 3 offset: 0009
            unknown9 = parser.ReadOffset< bool >( 0x9 );

            // col: 4 offset: 000a
            unknowna = parser.ReadOffset< bool >( 0xa );


        }
    }
}