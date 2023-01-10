// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CutsceneMotion", columnHash: 0x3d86ce33 )]
    public partial class CutsceneMotion : ExcelRow
    {
        
        public float WALK_LOOP_SPEED { get; set; }
        public float RUN_LOOP_SPEED { get; set; }
        public float SLOWWALK_LOOP_SPEED { get; set; }
        public float SLOWRUN_LOOP_SPEED { get; set; }
        public float BATTLEWALK_LOOP_SPEED { get; set; }
        public float BATTLERUN_LOOP_SPEED { get; set; }
        public float DASH_LOOP_SPEED { get; set; }
        public byte TURN_CW90_FRAME { get; set; }
        public byte TURN_CCW90_FRAME { get; set; }
        public byte TURN_CW180_FRAME { get; set; }
        public byte TURN_CCW180_FRAME { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

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