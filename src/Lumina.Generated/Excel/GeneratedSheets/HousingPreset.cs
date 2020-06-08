using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingPreset", columnHash: 0xb0025c7b )]
    public class HousingPreset : IExcelRow
    {
        
        public string Singular;
        public sbyte Adjective;
        public string Plural;
        public sbyte PossessivePronoun;
        public sbyte StartsWithVowel;
        public sbyte Unknown5;
        public sbyte Pronoun;
        public sbyte Article;
        public LazyRow< PlaceName > PlaceName;
        public byte HousingSize;
        public LazyRow< Item > ExteriorRoof;
        public LazyRow< Item > ExteriorWall;
        public LazyRow< Item > ExteriorWindow;
        public LazyRow< Item > ExteriorDoor;
        public LazyRow< Item > InteriorWall;
        public LazyRow< Item > InteriorFlooring;
        public LazyRow< Item > InteriorLighting;
        public LazyRow< Item > OtherFloorWall;
        public LazyRow< Item > OtherFloorFlooring;
        public LazyRow< Item > OtherFloorLighting;
        public LazyRow< Item > BasementWall;
        public LazyRow< Item > BasementFlooring;
        public LazyRow< Item > BasementLighting;
        public LazyRow< Item > MansionLighting;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Singular = parser.ReadColumn< string >( 0 );
            Adjective = parser.ReadColumn< sbyte >( 1 );
            Plural = parser.ReadColumn< string >( 2 );
            PossessivePronoun = parser.ReadColumn< sbyte >( 3 );
            StartsWithVowel = parser.ReadColumn< sbyte >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
            Pronoun = parser.ReadColumn< sbyte >( 6 );
            Article = parser.ReadColumn< sbyte >( 7 );
            PlaceName = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 8 ) );
            HousingSize = parser.ReadColumn< byte >( 9 );
            ExteriorRoof = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 10 ) );
            ExteriorWall = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 11 ) );
            ExteriorWindow = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 12 ) );
            ExteriorDoor = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 13 ) );
            InteriorWall = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 14 ) );
            InteriorFlooring = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 15 ) );
            InteriorLighting = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 16 ) );
            OtherFloorWall = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 17 ) );
            OtherFloorFlooring = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 18 ) );
            OtherFloorLighting = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 19 ) );
            BasementWall = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 20 ) );
            BasementFlooring = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 21 ) );
            BasementLighting = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 22 ) );
            MansionLighting = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 23 ) );
        }
    }
}