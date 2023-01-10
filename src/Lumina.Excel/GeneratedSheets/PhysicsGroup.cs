// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PhysicsGroup", columnHash: 0xfa594271 )]
    public partial class PhysicsGroup : ExcelRow
    {
        
        public float[] SimulationTime { get; set; }
        public float[] PS3SimulationTime { get; set; }
        public bool ResetByLookAt { get; set; }
        public float RootFollowingGame { get; set; }
        public float RootFollowingCutScene { get; set; }
        public sbyte[] ConfigSwitch { get; set; }
        public bool ForceAttractByPhysicsOff { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

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