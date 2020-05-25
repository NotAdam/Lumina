using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PhysicsGroup", columnHash: 0xfa594271 )]
    public class PhysicsGroup : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


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
        public bool ResetByLookAt;
        public byte packed3b;
        public bool ForceAttractByPhysicsOff;


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
            packed3b = parser.ReadOffset< byte >( 0x3b, ExcelColumnDataType.UInt8 );

            ResetByLookAt = ( packed3b & 0x1 ) == 0x1;
            ForceAttractByPhysicsOff = ( packed3b & 0x2 ) == 0x2;


        }
    }
}