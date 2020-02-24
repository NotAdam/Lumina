using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeaponItem", columnHash: 0xe0a5cdd0 )]
    public class AnimaWeaponItem : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public uint[] Item;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Item = new uint[14];
            Item[0] = parser.ReadOffset< uint >( 0x0 );
            Item[1] = parser.ReadOffset< uint >( 0x4 );
            Item[2] = parser.ReadOffset< uint >( 0x8 );
            Item[3] = parser.ReadOffset< uint >( 0xc );
            Item[4] = parser.ReadOffset< uint >( 0x10 );
            Item[5] = parser.ReadOffset< uint >( 0x14 );
            Item[6] = parser.ReadOffset< uint >( 0x18 );
            Item[7] = parser.ReadOffset< uint >( 0x1c );
            Item[8] = parser.ReadOffset< uint >( 0x20 );
            Item[9] = parser.ReadOffset< uint >( 0x24 );
            Item[10] = parser.ReadOffset< uint >( 0x28 );
            Item[11] = parser.ReadOffset< uint >( 0x2c );
            Item[12] = parser.ReadOffset< uint >( 0x30 );
            Item[13] = parser.ReadOffset< uint >( 0x34 );


        }
    }
}