// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RecastNavimesh", columnHash: 0x98c040df )]
    public partial class RecastNavimesh : ExcelRow
    {
        
        public SeString Unknown0 { get; set; }
        public float TileSize { get; set; }
        public float CellSize { get; set; }
        public float CellHeight { get; set; }
        public float AgentHeight { get; set; }
        public float AgentRadius { get; set; }
        public float AgentMaxClimb { get; set; }
        public float AgentMaxSlope { get; set; }
        public bool Unknown8 { get; set; }
        public float RegionMinSize { get; set; }
        public float RegionMergedSize { get; set; }
        public bool Unknown11 { get; set; }
        public float MaxEdgeLength { get; set; }
        public float MaxEdgeError { get; set; }
        public float VertsPerPoly { get; set; }
        public float DetailMeshSampleDistance { get; set; }
        public float DetailMeshMaxSampleError { get; set; }
        public float Unknown17 { get; set; }
        public float Unknown18 { get; set; }
        public float Unknown19 { get; set; }
        public float Unknown20 { get; set; }
        public float Unknown21 { get; set; }
        public float Unknown22 { get; set; }
        public float Unknown23 { get; set; }
        public float Unknown24 { get; set; }
        public float Unknown25 { get; set; }
        public float Unknown26 { get; set; }
        public float Unknown27 { get; set; }
        public float Unknown28 { get; set; }
        public float Unknown29 { get; set; }
        public bool Unknown30 { get; set; }
        public float Unknown31 { get; set; }
        public float Unknown32 { get; set; }
        public float Unknown33 { get; set; }
        public bool Unknown34 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< SeString >( 0 );
            TileSize = parser.ReadColumn< float >( 1 );
            CellSize = parser.ReadColumn< float >( 2 );
            CellHeight = parser.ReadColumn< float >( 3 );
            AgentHeight = parser.ReadColumn< float >( 4 );
            AgentRadius = parser.ReadColumn< float >( 5 );
            AgentMaxClimb = parser.ReadColumn< float >( 6 );
            AgentMaxSlope = parser.ReadColumn< float >( 7 );
            Unknown8 = parser.ReadColumn< bool >( 8 );
            RegionMinSize = parser.ReadColumn< float >( 9 );
            RegionMergedSize = parser.ReadColumn< float >( 10 );
            Unknown11 = parser.ReadColumn< bool >( 11 );
            MaxEdgeLength = parser.ReadColumn< float >( 12 );
            MaxEdgeError = parser.ReadColumn< float >( 13 );
            VertsPerPoly = parser.ReadColumn< float >( 14 );
            DetailMeshSampleDistance = parser.ReadColumn< float >( 15 );
            DetailMeshMaxSampleError = parser.ReadColumn< float >( 16 );
            Unknown17 = parser.ReadColumn< float >( 17 );
            Unknown18 = parser.ReadColumn< float >( 18 );
            Unknown19 = parser.ReadColumn< float >( 19 );
            Unknown20 = parser.ReadColumn< float >( 20 );
            Unknown21 = parser.ReadColumn< float >( 21 );
            Unknown22 = parser.ReadColumn< float >( 22 );
            Unknown23 = parser.ReadColumn< float >( 23 );
            Unknown24 = parser.ReadColumn< float >( 24 );
            Unknown25 = parser.ReadColumn< float >( 25 );
            Unknown26 = parser.ReadColumn< float >( 26 );
            Unknown27 = parser.ReadColumn< float >( 27 );
            Unknown28 = parser.ReadColumn< float >( 28 );
            Unknown29 = parser.ReadColumn< float >( 29 );
            Unknown30 = parser.ReadColumn< bool >( 30 );
            Unknown31 = parser.ReadColumn< float >( 31 );
            Unknown32 = parser.ReadColumn< float >( 32 );
            Unknown33 = parser.ReadColumn< float >( 33 );
            Unknown34 = parser.ReadColumn< bool >( 34 );
        }
    }
}