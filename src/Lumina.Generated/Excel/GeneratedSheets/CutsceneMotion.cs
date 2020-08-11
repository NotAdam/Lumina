// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CutsceneMotion", columnHash: 0x3d86ce33 )]
    public class CutsceneMotion : IExcelRow
    {
        
        public float WALK_LOOP_SPEED;
        public float RUN_LOOP_SPEED;
        public float SLOWWALK_LOOP_SPEED;
        public float SLOWRUN_LOOP_SPEED;
        public float BATTLEWALK_LOOP_SPEED;
        public float BATTLERUN_LOOP_SPEED;
        public float DASH_LOOP_SPEED;
        public byte TURN_CW90_FRAME;
        public byte TURN_CCW90_FRAME;
        public byte TURN_CW180_FRAME;
        public byte TURN_CCW180_FRAME;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            WALK_LOOP_SPEED = parser.ReadColumn< float >( 0 );
            RUN_LOOP_SPEED = parser.ReadColumn< float >( 1 );
            SLOWWALK_LOOP_SPEED = parser.ReadColumn< float >( 2 );
            SLOWRUN_LOOP_SPEED = parser.ReadColumn< float >( 3 );
            BATTLEWALK_LOOP_SPEED = parser.ReadColumn< float >( 4 );
            BATTLERUN_LOOP_SPEED = parser.ReadColumn< float >( 5 );
            DASH_LOOP_SPEED = parser.ReadColumn< float >( 6 );
            TURN_CW90_FRAME = parser.ReadColumn< byte >( 7 );
            TURN_CCW90_FRAME = parser.ReadColumn< byte >( 8 );
            TURN_CW180_FRAME = parser.ReadColumn< byte >( 9 );
            TURN_CCW180_FRAME = parser.ReadColumn< byte >( 10 );
        }
    }
}