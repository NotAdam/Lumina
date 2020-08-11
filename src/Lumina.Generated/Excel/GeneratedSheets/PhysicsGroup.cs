// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PhysicsGroup", columnHash: 0xfa594271 )]
    public class PhysicsGroup : IExcelRow
    {
        
        public float[] SimulationTime;
        public float[] PS3SimulationTime;
        public bool ResetByLookAt;
        public float RootFollowingGame;
        public float RootFollowingCutScene;
        public sbyte[] ConfigSwitch;
        public bool ForceAttractByPhysicsOff;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            SimulationTime = new float[ 6 ];
            for( var i = 0; i < 6; i++ )
                SimulationTime[ i ] = parser.ReadColumn< float >( 0 + i );
            PS3SimulationTime = new float[ 6 ];
            for( var i = 0; i < 6; i++ )
                PS3SimulationTime[ i ] = parser.ReadColumn< float >( 6 + i );
            ResetByLookAt = parser.ReadColumn< bool >( 12 );
            RootFollowingGame = parser.ReadColumn< float >( 13 );
            RootFollowingCutScene = parser.ReadColumn< float >( 14 );
            ConfigSwitch = new sbyte[ 3 ];
            for( var i = 0; i < 3; i++ )
                ConfigSwitch[ i ] = parser.ReadColumn< sbyte >( 15 + i );
            ForceAttractByPhysicsOff = parser.ReadColumn< bool >( 18 );
        }
    }
}