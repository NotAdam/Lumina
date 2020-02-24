using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingPreset", columnHash: 0xb0025c7b )]
    public class HousingPreset : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public string Singular;

        // col: 02 offset: 0004
        public string Plural;

        // col: 01 offset: 0008
        public sbyte Adjective;

        // col: 03 offset: 0009
        public sbyte PossessivePronoun;

        // col: 04 offset: 000a
        public sbyte StartsWithVowel;

        // col: 05 offset: 000b
        public sbyte unknownb;

        // col: 06 offset: 000c
        public sbyte Pronoun;

        // col: 07 offset: 000d
        public sbyte Article;

        // col: 10 offset: 0010
        public int ExteriorRoof;

        // col: 11 offset: 0014
        public int ExteriorWall;

        // col: 12 offset: 0018
        public int ExteriorWindow;

        // col: 13 offset: 001c
        public int ExteriorDoor;

        // col: 14 offset: 0020
        public int InteriorWall;

        // col: 15 offset: 0024
        public int InteriorFlooring;

        // col: 16 offset: 0028
        public int InteriorLighting;

        // col: 17 offset: 002c
        public int OtherFloorWall;

        // col: 18 offset: 0030
        public int OtherFloorFlooring;

        // col: 19 offset: 0034
        public int OtherFloorLighting;

        // col: 20 offset: 0038
        public int BasementWall;

        // col: 21 offset: 003c
        public int BasementFlooring;

        // col: 22 offset: 0040
        public int BasementLighting;

        // col: 23 offset: 0044
        public int MansionLighting;

        // col: 08 offset: 0048
        public ushort PlaceName;

        // col: 09 offset: 004a
        public byte HousingSize;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Singular = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            Plural = parser.ReadOffset< string >( 0x4 );

            // col: 1 offset: 0008
            Adjective = parser.ReadOffset< sbyte >( 0x8 );

            // col: 3 offset: 0009
            PossessivePronoun = parser.ReadOffset< sbyte >( 0x9 );

            // col: 4 offset: 000a
            StartsWithVowel = parser.ReadOffset< sbyte >( 0xa );

            // col: 5 offset: 000b
            unknownb = parser.ReadOffset< sbyte >( 0xb );

            // col: 6 offset: 000c
            Pronoun = parser.ReadOffset< sbyte >( 0xc );

            // col: 7 offset: 000d
            Article = parser.ReadOffset< sbyte >( 0xd );

            // col: 10 offset: 0010
            ExteriorRoof = parser.ReadOffset< int >( 0x10 );

            // col: 11 offset: 0014
            ExteriorWall = parser.ReadOffset< int >( 0x14 );

            // col: 12 offset: 0018
            ExteriorWindow = parser.ReadOffset< int >( 0x18 );

            // col: 13 offset: 001c
            ExteriorDoor = parser.ReadOffset< int >( 0x1c );

            // col: 14 offset: 0020
            InteriorWall = parser.ReadOffset< int >( 0x20 );

            // col: 15 offset: 0024
            InteriorFlooring = parser.ReadOffset< int >( 0x24 );

            // col: 16 offset: 0028
            InteriorLighting = parser.ReadOffset< int >( 0x28 );

            // col: 17 offset: 002c
            OtherFloorWall = parser.ReadOffset< int >( 0x2c );

            // col: 18 offset: 0030
            OtherFloorFlooring = parser.ReadOffset< int >( 0x30 );

            // col: 19 offset: 0034
            OtherFloorLighting = parser.ReadOffset< int >( 0x34 );

            // col: 20 offset: 0038
            BasementWall = parser.ReadOffset< int >( 0x38 );

            // col: 21 offset: 003c
            BasementFlooring = parser.ReadOffset< int >( 0x3c );

            // col: 22 offset: 0040
            BasementLighting = parser.ReadOffset< int >( 0x40 );

            // col: 23 offset: 0044
            MansionLighting = parser.ReadOffset< int >( 0x44 );

            // col: 8 offset: 0048
            PlaceName = parser.ReadOffset< ushort >( 0x48 );

            // col: 9 offset: 004a
            HousingSize = parser.ReadOffset< byte >( 0x4a );


        }
    }
}