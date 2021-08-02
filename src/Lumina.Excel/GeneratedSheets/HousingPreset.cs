// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingPreset", columnHash: 0x9184af18 )]
    public partial class HousingPreset : ExcelRow
    {
        
        public SeString Singular { get; set; }
        public sbyte Adjective { get; set; }
        public SeString Plural { get; set; }
        public sbyte PossessivePronoun { get; set; }
        public sbyte StartsWithVowel { get; set; }
        public sbyte Unknown5 { get; set; }
        public sbyte Pronoun { get; set; }
        public sbyte Article { get; set; }
        public LazyRow< PlaceName > PlaceName { get; set; }
        public byte HousingSize { get; set; }
        public LazyRow< Item > ExteriorRoof { get; set; }
        public LazyRow< Item > ExteriorWall { get; set; }
        public LazyRow< Item > ExteriorWindow { get; set; }
        public LazyRow< Item > ExteriorDoor { get; set; }
        public LazyRow< Item > InteriorWall { get; set; }
        public LazyRow< Item > InteriorFlooring { get; set; }
        public LazyRow< Item > InteriorLighting { get; set; }
        public LazyRow< Item > OtherFloorWall { get; set; }
        public LazyRow< Item > OtherFloorFlooring { get; set; }
        public LazyRow< Item > OtherFloorLighting { get; set; }
        public LazyRow< Item > BasementWall { get; set; }
        public LazyRow< Item > BasementFlooring { get; set; }
        public LazyRow< Item > BasementLighting { get; set; }
        public LazyRow< Item > MansionLighting { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Singular = parser.ReadColumn< SeString >( 0 );
            Adjective = parser.ReadColumn< sbyte >( 1 );
            Plural = parser.ReadColumn< SeString >( 2 );
            PossessivePronoun = parser.ReadColumn< sbyte >( 3 );
            StartsWithVowel = parser.ReadColumn< sbyte >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
            Pronoun = parser.ReadColumn< sbyte >( 6 );
            Article = parser.ReadColumn< sbyte >( 7 );
            PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 8 ), language );
            HousingSize = parser.ReadColumn< byte >( 9 );
            ExteriorRoof = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 10 ), language );
            ExteriorWall = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 11 ), language );
            ExteriorWindow = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 12 ), language );
            ExteriorDoor = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 13 ), language );
            InteriorWall = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 14 ), language );
            InteriorFlooring = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 15 ), language );
            InteriorLighting = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 16 ), language );
            OtherFloorWall = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 17 ), language );
            OtherFloorFlooring = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 18 ), language );
            OtherFloorLighting = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 19 ), language );
            BasementWall = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 20 ), language );
            BasementFlooring = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 21 ), language );
            BasementLighting = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 22 ), language );
            MansionLighting = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 23 ), language );
        }
    }
}