using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CharaMakeClassEquip", columnHash: 0x41dafacb )]
    public class CharaMakeClassEquip : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 00 offset: 0000
        public ulong Helmet;

        // col: 01 offset: 0008
        public ulong Top;

        // col: 02 offset: 0010
        public ulong Glove;

        // col: 03 offset: 0018
        public ulong Down;

        // col: 04 offset: 0020
        public ulong Shoes;

        // col: 05 offset: 0028
        public ulong Weapon;

        // col: 06 offset: 0030
        public ulong SubWeapon;

        // col: 07 offset: 0038
        public int Class;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Helmet = parser.ReadOffset< ulong >( 0x0 );

            // col: 1 offset: 0008
            Top = parser.ReadOffset< ulong >( 0x8 );

            // col: 2 offset: 0010
            Glove = parser.ReadOffset< ulong >( 0x10 );

            // col: 3 offset: 0018
            Down = parser.ReadOffset< ulong >( 0x18 );

            // col: 4 offset: 0020
            Shoes = parser.ReadOffset< ulong >( 0x20 );

            // col: 5 offset: 0028
            Weapon = parser.ReadOffset< ulong >( 0x28 );

            // col: 6 offset: 0030
            SubWeapon = parser.ReadOffset< ulong >( 0x30 );

            // col: 7 offset: 0038
            Class = parser.ReadOffset< int >( 0x38 );


        }
    }
}