namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PhysicsGroup", columnHash: 0xfa594271 )]
    public class PhysicsGroup : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: SimulationTime
         *  repeat count: 6
         */

        /* offset: 0004 col: 1
         *  no SaintCoinach definition found
         */

        /* offset: 0008 col: 2
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 3
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 4
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 0018 col: 6
         *  name: PS3SimulationTime
         *  repeat count: 6
         */

        /* offset: 001c col: 7
         *  no SaintCoinach definition found
         */

        /* offset: 0020 col: 8
         *  no SaintCoinach definition found
         */

        /* offset: 0024 col: 9
         *  no SaintCoinach definition found
         */

        /* offset: 0028 col: 10
         *  no SaintCoinach definition found
         */

        /* offset: 002c col: 11
         *  no SaintCoinach definition found
         */

        /* offset: 003b col: 12
         *  name: ResetByLookAt
         *  type: 
         */

        /* offset: 0030 col: 13
         *  name: RootFollowingGame
         *  type: 
         */

        /* offset: 0034 col: 14
         *  name: RootFollowingCutScene
         *  type: 
         */

        /* offset: 0038 col: 15
         *  name: ConfigSwitch
         *  repeat count: 3
         */

        /* offset: 0039 col: 16
         *  no SaintCoinach definition found
         */

        /* offset: 003a col: 17
         *  no SaintCoinach definition found
         */

        /* offset: 003b col: 18
         *  name: ForceAttractByPhysicsOff
         *  type: 
         */



        // col: 00 offset: 0000
        public float[] SimulationTime;

        // col: 06 offset: 0018
        public float[] PS3SimulationTime;

        // col: 13 offset: 0030
        public float RootFollowingGame;

        // col: 14 offset: 0034
        public float RootFollowingCutScene;

        // col: 15 offset: 0038
        public sbyte[] ConfigSwitch;

        // col: 12 offset: 003b
        private byte packed3b;
        public bool ResetByLookAt => ( packed3b & 0x1 ) == 0x1;
        public bool ForceAttractByPhysicsOff => ( packed3b & 0x2 ) == 0x2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            SimulationTime = new float[6];
            SimulationTime[0] = parser.ReadOffset< float >( 0x0 );
            SimulationTime[1] = parser.ReadOffset< float >( 0x4 );
            SimulationTime[2] = parser.ReadOffset< float >( 0x8 );
            SimulationTime[3] = parser.ReadOffset< float >( 0xc );
            SimulationTime[4] = parser.ReadOffset< float >( 0x10 );
            SimulationTime[5] = parser.ReadOffset< float >( 0x14 );

            // col: 6 offset: 0018
            PS3SimulationTime = new float[6];
            PS3SimulationTime[0] = parser.ReadOffset< float >( 0x18 );
            PS3SimulationTime[1] = parser.ReadOffset< float >( 0x1c );
            PS3SimulationTime[2] = parser.ReadOffset< float >( 0x20 );
            PS3SimulationTime[3] = parser.ReadOffset< float >( 0x24 );
            PS3SimulationTime[4] = parser.ReadOffset< float >( 0x28 );
            PS3SimulationTime[5] = parser.ReadOffset< float >( 0x2c );

            // col: 13 offset: 0030
            RootFollowingGame = parser.ReadOffset< float >( 0x30 );

            // col: 14 offset: 0034
            RootFollowingCutScene = parser.ReadOffset< float >( 0x34 );

            // col: 15 offset: 0038
            ConfigSwitch = new sbyte[3];
            ConfigSwitch[0] = parser.ReadOffset< sbyte >( 0x38 );
            ConfigSwitch[1] = parser.ReadOffset< sbyte >( 0x39 );
            ConfigSwitch[2] = parser.ReadOffset< sbyte >( 0x3a );

            // col: 12 offset: 003b
            packed3b = parser.ReadOffset< byte >( 0x3b );


        }
    }
}