using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Relic", columnHash: 0x8080ef57 )]
    public class Relic : IExcelRow
    {
        
        public LazyRow< Item > ItemAtma;
        public LazyRow< Item > ItemAnimus;
        public int Icon;
        public LazyRow< Materia > Materia0;
        public LazyRow< RelicNote > NoteMain0;
        public LazyRow< RelicNote > NoteSub0;
        public LazyRow< RelicNote > NoteSelection10;
        public LazyRow< Materia > Materia1;
        public LazyRow< RelicNote > NoteMain1;
        public LazyRow< RelicNote > NoteSub1;
        public LazyRow< RelicNote > NoteSelection1;
        public LazyRow< Materia > Materia2;
        public LazyRow< RelicNote > NoteMain2;
        public LazyRow< RelicNote > NoteSub2;
        public LazyRow< Materia > Materia3;
        public LazyRow< RelicNote > NoteSelection3;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ItemAtma = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 0 ) );
            ItemAnimus = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 1 ) );
            Icon = parser.ReadColumn< int >( 2 );
            Materia0 = new LazyRow< Materia >( lumina, parser.ReadColumn< ushort >( 3 ) );
            NoteMain0 = new LazyRow< RelicNote >( lumina, parser.ReadColumn< byte >( 4 ) );
            NoteSub0 = new LazyRow< RelicNote >( lumina, parser.ReadColumn< byte >( 5 ) );
            NoteSelection10 = new LazyRow< RelicNote >( lumina, parser.ReadColumn< byte >( 6 ) );
            Materia1 = new LazyRow< Materia >( lumina, parser.ReadColumn< ushort >( 7 ) );
            NoteMain1 = new LazyRow< RelicNote >( lumina, parser.ReadColumn< byte >( 8 ) );
            NoteSub1 = new LazyRow< RelicNote >( lumina, parser.ReadColumn< byte >( 9 ) );
            NoteSelection1 = new LazyRow< RelicNote >( lumina, parser.ReadColumn< byte >( 10 ) );
            Materia2 = new LazyRow< Materia >( lumina, parser.ReadColumn< ushort >( 11 ) );
            NoteMain2 = new LazyRow< RelicNote >( lumina, parser.ReadColumn< byte >( 12 ) );
            NoteSub2 = new LazyRow< RelicNote >( lumina, parser.ReadColumn< byte >( 13 ) );
            Materia3 = new LazyRow< Materia >( lumina, parser.ReadColumn< ushort >( 14 ) );
            NoteSelection3 = new LazyRow< RelicNote >( lumina, parser.ReadColumn< byte >( 15 ) );
        }
    }
}