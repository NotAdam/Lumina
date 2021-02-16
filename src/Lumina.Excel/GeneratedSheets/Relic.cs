// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Relic", columnHash: 0x8080ef57 )]
    public class Relic : ExcelRow
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
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ItemAtma = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 0 ), language );
            ItemAnimus = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 1 ), language );
            Icon = parser.ReadColumn< int >( 2 );
            Materia0 = new LazyRow< Materia >( gameData, parser.ReadColumn< ushort >( 3 ), language );
            NoteMain0 = new LazyRow< RelicNote >( gameData, parser.ReadColumn< byte >( 4 ), language );
            NoteSub0 = new LazyRow< RelicNote >( gameData, parser.ReadColumn< byte >( 5 ), language );
            NoteSelection10 = new LazyRow< RelicNote >( gameData, parser.ReadColumn< byte >( 6 ), language );
            Materia1 = new LazyRow< Materia >( gameData, parser.ReadColumn< ushort >( 7 ), language );
            NoteMain1 = new LazyRow< RelicNote >( gameData, parser.ReadColumn< byte >( 8 ), language );
            NoteSub1 = new LazyRow< RelicNote >( gameData, parser.ReadColumn< byte >( 9 ), language );
            NoteSelection1 = new LazyRow< RelicNote >( gameData, parser.ReadColumn< byte >( 10 ), language );
            Materia2 = new LazyRow< Materia >( gameData, parser.ReadColumn< ushort >( 11 ), language );
            NoteMain2 = new LazyRow< RelicNote >( gameData, parser.ReadColumn< byte >( 12 ), language );
            NoteSub2 = new LazyRow< RelicNote >( gameData, parser.ReadColumn< byte >( 13 ), language );
            Materia3 = new LazyRow< Materia >( gameData, parser.ReadColumn< ushort >( 14 ), language );
            NoteSelection3 = new LazyRow< RelicNote >( gameData, parser.ReadColumn< byte >( 15 ), language );
        }
    }
}