using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Race", columnHash: 0x3cc6df2e )]
    public class Race : IExcelRow
    {
        
        public string Masculine;
        public string Feminine;
        public LazyRow< Item > RSEMBody;
        public LazyRow< Item > RSEMHands;
        public LazyRow< Item > RSEMLegs;
        public LazyRow< Item > RSEMFeet;
        public LazyRow< Item > RSEFBody;
        public LazyRow< Item > RSEFHands;
        public LazyRow< Item > RSEFLegs;
        public LazyRow< Item > RSEFFeet;
        public byte Unknown10;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Masculine = parser.ReadColumn< string >( 0 );
            Feminine = parser.ReadColumn< string >( 1 );
            RSEMBody = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 2 ) );
            RSEMHands = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 3 ) );
            RSEMLegs = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 4 ) );
            RSEMFeet = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 5 ) );
            RSEFBody = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 6 ) );
            RSEFHands = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 7 ) );
            RSEFLegs = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 8 ) );
            RSEFFeet = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 9 ) );
            Unknown10 = parser.ReadColumn< byte >( 10 );
        }
    }
}