// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RecastNavimesh", columnHash: 0x98c040df )]
    public class RecastNavimesh : ExcelRow
    {
        
        public SeString Unknown0;
        public float TileSize;
        public float CellSize;
        public float CellHeight;
        public float AgentHeight;
        public float AgentRadius;
        public float AgentMaxClimb;
        public float AgentMaxSlope;
        public bool Unknown8;
        public float RegionMinSize;
        public float RegionMergedSize;
        public bool Unknown11;
        public float MaxEdgeLength;
        public float MaxEdgeError;
        public float VertsPerPoly;
        public float DetailMeshSampleDistance;
        public float DetailMeshMaxSampleError;
        public float Unknown17;
        public float Unknown18;
        public float Unknown19;
        public float Unknown20;
        public float Unknown21;
        public float Unknown22;
        public float Unknown23;
        public float Unknown24;
        public float Unknown25;
        public float Unknown26;
        public float Unknown27;
        public float Unknown28;
        public float Unknown29;
        public bool Unknown30;
        public float Unknown31;
        public float Unknown32;
        public float Unknown33;
        public bool Unknown34;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

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