using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RecastNavimesh", columnHash: 0x75b2270a )]
    public class RecastNavimesh : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public string unknown0;

        // col: 01 offset: 0004
        public float TileSize;

        // col: 02 offset: 0008
        public float CellSize;

        // col: 03 offset: 000c
        public float CellHeight;

        // col: 04 offset: 0010
        public float AgentHeight;

        // col: 05 offset: 0014
        public float AgentRadius;

        // col: 06 offset: 0018
        public float AgentMaxClimb;

        // col: 07 offset: 001c
        public float AgentMaxSlope;

        // col: 09 offset: 0020
        public float RegionMinSize;

        // col: 10 offset: 0024
        public float RegionMergedSize;

        // col: 12 offset: 0028
        public float MaxEdgeLength;

        // col: 13 offset: 002c
        public float MaxEdgeError;

        // col: 14 offset: 0030
        public float VertsPerPoly;

        // col: 15 offset: 0034
        public float DetailMeshSampleDistance;

        // col: 16 offset: 0038
        public float DetailMeshMaxSampleError;

        // col: 17 offset: 003c
        public float unknown3c;

        // col: 18 offset: 0040
        public float unknown40;

        // col: 19 offset: 0044
        public float unknown44;

        // col: 20 offset: 0048
        public float unknown48;

        // col: 21 offset: 004c
        public float unknown4c;

        // col: 22 offset: 0050
        public float unknown50;

        // col: 23 offset: 0054
        public float unknown54;

        // col: 24 offset: 0058
        public float unknown58;

        // col: 25 offset: 005c
        public float unknown5c;

        // col: 26 offset: 0060
        public float unknown60;

        // col: 27 offset: 0064
        public float unknown64;

        // col: 28 offset: 0068
        public float unknown68;

        // col: 29 offset: 006c
        public float unknown6c;

        // col: 31 offset: 0070
        public float unknown70;

        // col: 32 offset: 0074
        public float unknown74;

        // col: 33 offset: 0078
        public float unknown78;

        // col: 08 offset: 007c
        private byte packed7c;
        public bool packed7c_1 => ( packed7c & 0x1 ) == 0x1;
        public bool packed7c_2 => ( packed7c & 0x2 ) == 0x2;
        public bool packed7c_4 => ( packed7c & 0x4 ) == 0x4;
        public bool packed7c_8 => ( packed7c & 0x8 ) == 0x8;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            unknown0 = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            TileSize = parser.ReadOffset< float >( 0x4 );

            // col: 2 offset: 0008
            CellSize = parser.ReadOffset< float >( 0x8 );

            // col: 3 offset: 000c
            CellHeight = parser.ReadOffset< float >( 0xc );

            // col: 4 offset: 0010
            AgentHeight = parser.ReadOffset< float >( 0x10 );

            // col: 5 offset: 0014
            AgentRadius = parser.ReadOffset< float >( 0x14 );

            // col: 6 offset: 0018
            AgentMaxClimb = parser.ReadOffset< float >( 0x18 );

            // col: 7 offset: 001c
            AgentMaxSlope = parser.ReadOffset< float >( 0x1c );

            // col: 9 offset: 0020
            RegionMinSize = parser.ReadOffset< float >( 0x20 );

            // col: 10 offset: 0024
            RegionMergedSize = parser.ReadOffset< float >( 0x24 );

            // col: 12 offset: 0028
            MaxEdgeLength = parser.ReadOffset< float >( 0x28 );

            // col: 13 offset: 002c
            MaxEdgeError = parser.ReadOffset< float >( 0x2c );

            // col: 14 offset: 0030
            VertsPerPoly = parser.ReadOffset< float >( 0x30 );

            // col: 15 offset: 0034
            DetailMeshSampleDistance = parser.ReadOffset< float >( 0x34 );

            // col: 16 offset: 0038
            DetailMeshMaxSampleError = parser.ReadOffset< float >( 0x38 );

            // col: 17 offset: 003c
            unknown3c = parser.ReadOffset< float >( 0x3c );

            // col: 18 offset: 0040
            unknown40 = parser.ReadOffset< float >( 0x40 );

            // col: 19 offset: 0044
            unknown44 = parser.ReadOffset< float >( 0x44 );

            // col: 20 offset: 0048
            unknown48 = parser.ReadOffset< float >( 0x48 );

            // col: 21 offset: 004c
            unknown4c = parser.ReadOffset< float >( 0x4c );

            // col: 22 offset: 0050
            unknown50 = parser.ReadOffset< float >( 0x50 );

            // col: 23 offset: 0054
            unknown54 = parser.ReadOffset< float >( 0x54 );

            // col: 24 offset: 0058
            unknown58 = parser.ReadOffset< float >( 0x58 );

            // col: 25 offset: 005c
            unknown5c = parser.ReadOffset< float >( 0x5c );

            // col: 26 offset: 0060
            unknown60 = parser.ReadOffset< float >( 0x60 );

            // col: 27 offset: 0064
            unknown64 = parser.ReadOffset< float >( 0x64 );

            // col: 28 offset: 0068
            unknown68 = parser.ReadOffset< float >( 0x68 );

            // col: 29 offset: 006c
            unknown6c = parser.ReadOffset< float >( 0x6c );

            // col: 31 offset: 0070
            unknown70 = parser.ReadOffset< float >( 0x70 );

            // col: 32 offset: 0074
            unknown74 = parser.ReadOffset< float >( 0x74 );

            // col: 33 offset: 0078
            unknown78 = parser.ReadOffset< float >( 0x78 );

            // col: 8 offset: 007c
            packed7c = parser.ReadOffset< byte >( 0x7c, ExcelColumnDataType.UInt8 );


        }
    }
}