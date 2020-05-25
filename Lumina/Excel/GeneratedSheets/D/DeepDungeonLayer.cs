using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonLayer", columnHash: 0x832a5a83 )]
    public class DeepDungeonLayer : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 02 offset: 0000
        public ushort unknown0;

        // col: 03 offset: 0002
        public ushort unknown2;

        // col: 04 offset: 0004
        public ushort unknown4;

        // col: 00 offset: 0006
        public byte DeepDungeon;

        // col: 01 offset: 0007
        public byte unknown7;

        // col: 05 offset: 0008
        public byte unknown8;

        // col: 06 offset: 0009
        public byte unknown9;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            unknown0 = parser.ReadOffset< ushort >( 0x0 );

            // col: 3 offset: 0002
            unknown2 = parser.ReadOffset< ushort >( 0x2 );

            // col: 4 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );

            // col: 0 offset: 0006
            DeepDungeon = parser.ReadOffset< byte >( 0x6 );

            // col: 1 offset: 0007
            unknown7 = parser.ReadOffset< byte >( 0x7 );

            // col: 5 offset: 0008
            unknown8 = parser.ReadOffset< byte >( 0x8 );

            // col: 6 offset: 0009
            unknown9 = parser.ReadOffset< byte >( 0x9 );


        }
    }
}