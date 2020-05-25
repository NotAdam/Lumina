using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CraftLeve", columnHash: 0x51a3acc3 )]
    public class CraftLeve : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public int Leve;

        // col: 01 offset: 0004
        public int CraftLeveTalk;

        // col: 03 offset: 0008
        public int[] unknown8;

        // col: 07 offset: 0010
        public int unknown10;

        // col: 09 offset: 0014
        public int unknown14;

        // col: 08 offset: 001c
        public ushort unknown1c;

        // col: 10 offset: 001e
        public ushort unknown1e;

        // col: 02 offset: 0020
        public byte Repeats;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Leve = parser.ReadOffset< int >( 0x0 );

            // col: 1 offset: 0004
            CraftLeveTalk = parser.ReadOffset< int >( 0x4 );

            // col: 3 offset: 0008
            unknown8 = new int[4];
            unknown8[0] = parser.ReadOffset< int >( 0x8 );
            unknown8[1] = parser.ReadOffset< int >( 0x18 );
            unknown8[2] = parser.ReadOffset< int >( 0xc );
            unknown8[3] = parser.ReadOffset< int >( 0x1a );

            // col: 7 offset: 0010
            unknown10 = parser.ReadOffset< int >( 0x10 );

            // col: 9 offset: 0014
            unknown14 = parser.ReadOffset< int >( 0x14 );

            // col: 8 offset: 001c
            unknown1c = parser.ReadOffset< ushort >( 0x1c );

            // col: 10 offset: 001e
            unknown1e = parser.ReadOffset< ushort >( 0x1e );

            // col: 2 offset: 0020
            Repeats = parser.ReadOffset< byte >( 0x20 );


        }
    }
}