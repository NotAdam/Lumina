// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Race", columnHash: 0x3403807a )]
    public partial class Race : ExcelRow
    {
        
        public SeString Masculine { get; set; }
        public SeString Feminine { get; set; }
        public LazyRow< Item > RSEMBody { get; set; }
        public LazyRow< Item > RSEMHands { get; set; }
        public LazyRow< Item > RSEMLegs { get; set; }
        public LazyRow< Item > RSEMFeet { get; set; }
        public LazyRow< Item > RSEFBody { get; set; }
        public LazyRow< Item > RSEFHands { get; set; }
        public LazyRow< Item > RSEFLegs { get; set; }
        public LazyRow< Item > RSEFFeet { get; set; }
        public byte Unknown10 { get; set; }
        public LazyRow< ExVersion > ExPac { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Masculine = parser.ReadColumn< SeString >( 0 );
            Feminine = parser.ReadColumn< SeString >( 1 );
            RSEMBody = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 2 ), language );
            RSEMHands = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 3 ), language );
            RSEMLegs = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 4 ), language );
            RSEMFeet = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 5 ), language );
            RSEFBody = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 6 ), language );
            RSEFHands = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 7 ), language );
            RSEFLegs = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 8 ), language );
            RSEFFeet = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 9 ), language );
            Unknown10 = parser.ReadColumn< byte >( 10 );
            ExPac = new LazyRow< ExVersion >( gameData, parser.ReadColumn< byte >( 11 ), language );
        }
    }
}