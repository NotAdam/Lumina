using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MoveTimeline", columnHash: 0xf057da9c )]
    public class MoveTimeline : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public ushort Idle;

        // col: 01 offset: 0002
        public ushort MoveForward;

        // col: 02 offset: 0004
        public ushort MoveBack;

        // col: 03 offset: 0006
        public ushort MoveLeft;

        // col: 04 offset: 0008
        public ushort MoveRight;

        // col: 05 offset: 000a
        public ushort MoveUp;

        // col: 06 offset: 000c
        public ushort MoveDown;

        // col: 07 offset: 000e
        public ushort MoveTurnLeft;

        // col: 08 offset: 0010
        public ushort MoveTurnRight;

        // col: 09 offset: 0012
        public ushort Extra;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Idle = parser.ReadOffset< ushort >( 0x0 );

            // col: 1 offset: 0002
            MoveForward = parser.ReadOffset< ushort >( 0x2 );

            // col: 2 offset: 0004
            MoveBack = parser.ReadOffset< ushort >( 0x4 );

            // col: 3 offset: 0006
            MoveLeft = parser.ReadOffset< ushort >( 0x6 );

            // col: 4 offset: 0008
            MoveRight = parser.ReadOffset< ushort >( 0x8 );

            // col: 5 offset: 000a
            MoveUp = parser.ReadOffset< ushort >( 0xa );

            // col: 6 offset: 000c
            MoveDown = parser.ReadOffset< ushort >( 0xc );

            // col: 7 offset: 000e
            MoveTurnLeft = parser.ReadOffset< ushort >( 0xe );

            // col: 8 offset: 0010
            MoveTurnRight = parser.ReadOffset< ushort >( 0x10 );

            // col: 9 offset: 0012
            Extra = parser.ReadOffset< ushort >( 0x12 );


        }
    }
}