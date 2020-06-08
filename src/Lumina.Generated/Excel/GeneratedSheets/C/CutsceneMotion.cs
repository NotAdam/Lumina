using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CutsceneMotion", columnHash: 0x3d86ce33 )]
    public class CutsceneMotion : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public float WALK_LOOP_SPEED;

        // col: 01 offset: 0004
        public float RUN_LOOP_SPEED;

        // col: 02 offset: 0008
        public float SLOWWALK_LOOP_SPEED;

        // col: 03 offset: 000c
        public float SLOWRUN_LOOP_SPEED;

        // col: 04 offset: 0010
        public float BATTLEWALK_LOOP_SPEED;

        // col: 05 offset: 0014
        public float BATTLERUN_LOOP_SPEED;

        // col: 06 offset: 0018
        public float DASH_LOOP_SPEED;

        // col: 07 offset: 001c
        public byte TURN_CW90_FRAME;

        // col: 08 offset: 001d
        public byte TURN_CCW90_FRAME;

        // col: 09 offset: 001e
        public byte TURN_CW180_FRAME;

        // col: 10 offset: 001f
        public byte TURN_CCW180_FRAME;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            WALK_LOOP_SPEED = parser.ReadOffset< float >( 0x0 );

            // col: 1 offset: 0004
            RUN_LOOP_SPEED = parser.ReadOffset< float >( 0x4 );

            // col: 2 offset: 0008
            SLOWWALK_LOOP_SPEED = parser.ReadOffset< float >( 0x8 );

            // col: 3 offset: 000c
            SLOWRUN_LOOP_SPEED = parser.ReadOffset< float >( 0xc );

            // col: 4 offset: 0010
            BATTLEWALK_LOOP_SPEED = parser.ReadOffset< float >( 0x10 );

            // col: 5 offset: 0014
            BATTLERUN_LOOP_SPEED = parser.ReadOffset< float >( 0x14 );

            // col: 6 offset: 0018
            DASH_LOOP_SPEED = parser.ReadOffset< float >( 0x18 );

            // col: 7 offset: 001c
            TURN_CW90_FRAME = parser.ReadOffset< byte >( 0x1c );

            // col: 8 offset: 001d
            TURN_CCW90_FRAME = parser.ReadOffset< byte >( 0x1d );

            // col: 9 offset: 001e
            TURN_CW180_FRAME = parser.ReadOffset< byte >( 0x1e );

            // col: 10 offset: 001f
            TURN_CCW180_FRAME = parser.ReadOffset< byte >( 0x1f );


        }
    }
}