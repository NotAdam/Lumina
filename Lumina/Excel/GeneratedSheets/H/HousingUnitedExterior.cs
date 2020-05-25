using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingUnitedExterior", columnHash: 0x88a791a7 )]
    public class HousingUnitedExterior : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public uint[] Item;

        // col: 00 offset: 0020
        public byte unknown20;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Item = new uint[8];
            Item[0] = parser.ReadOffset< uint >( 0x0 );
            Item[1] = parser.ReadOffset< uint >( 0x4 );
            Item[2] = parser.ReadOffset< uint >( 0x8 );
            Item[3] = parser.ReadOffset< uint >( 0xc );
            Item[4] = parser.ReadOffset< uint >( 0x10 );
            Item[5] = parser.ReadOffset< uint >( 0x14 );
            Item[6] = parser.ReadOffset< uint >( 0x18 );
            Item[7] = parser.ReadOffset< uint >( 0x1c );

            // col: 0 offset: 0020
            unknown20 = parser.ReadOffset< byte >( 0x20 );


        }
    }
}