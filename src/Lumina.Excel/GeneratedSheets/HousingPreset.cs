// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingPreset", columnHash: 0x9184af18 )]
    public class HousingPreset : ExcelRow
    {
        
        public SeString Singular;
        public sbyte Adjective;
        public SeString Plural;
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
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Singular = parser.ReadColumn< SeString >( 0 );
            Adjective = parser.ReadColumn< sbyte >( 1 );
            Plural = parser.ReadColumn< SeString >( 2 );
            PossessivePronoun = parser.ReadColumn< sbyte >( 3 );
            StartsWithVowel = parser.ReadColumn< sbyte >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
            Pronoun = parser.ReadColumn< sbyte >( 6 );
            Article = parser.ReadColumn< sbyte >( 7 );
            PlaceName = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 8 ), language );
            HousingSize = parser.ReadColumn< byte >( 9 );
            ExteriorRoof = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 10 ), language );
            ExteriorWall = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 11 ), language );
            ExteriorWindow = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 12 ), language );
            ExteriorDoor = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 13 ), language );
            InteriorWall = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 14 ), language );
            InteriorFlooring = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 15 ), language );
            InteriorLighting = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 16 ), language );
            OtherFloorWall = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 17 ), language );
            OtherFloorFlooring = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 18 ), language );
            OtherFloorLighting = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 19 ), language );
            BasementWall = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 20 ), language );
            BasementFlooring = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 21 ), language );
            BasementLighting = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 22 ), language );
            MansionLighting = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 23 ), language );
        }
    }
}