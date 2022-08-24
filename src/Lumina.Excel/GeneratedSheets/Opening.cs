// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Opening", columnHash: 0xfe684a57 )]
    public partial class Opening : ExcelRow
    {
        
        public SeString Name { get; set; }
        public LazyRow< Quest > Quest { get; set; }
        public SeString Unknown2 { get; set; }
        public SeString Unknown3 { get; set; }
        public SeString Unknown4 { get; set; }
        public SeString Unknown5 { get; set; }
        public SeString Unknown6 { get; set; }
        public SeString Unknown7 { get; set; }
        public SeString Unknown8 { get; set; }
        public SeString Unknown9 { get; set; }
        public SeString Unknown10 { get; set; }
        public SeString Unknown11 { get; set; }
        public SeString Unknown12 { get; set; }
        public SeString Unknown13 { get; set; }
        public SeString Unknown14 { get; set; }
        public SeString Unknown15 { get; set; }
        public SeString Unknown16 { get; set; }
        public SeString Unknown17 { get; set; }
        public SeString Unknown18 { get; set; }
        public SeString Unknown19 { get; set; }
        public SeString Unknown20 { get; set; }
        public SeString Unknown21 { get; set; }
        public SeString Unknown22 { get; set; }
        public SeString Unknown23 { get; set; }
        public SeString Unknown24 { get; set; }
        public SeString Unknown25 { get; set; }
        public SeString Unknown26 { get; set; }
        public SeString Unknown27 { get; set; }
        public SeString Unknown28 { get; set; }
        public SeString Unknown29 { get; set; }
        public SeString Unknown30 { get; set; }
        public SeString Unknown31 { get; set; }
        public SeString Unknown32 { get; set; }
        public SeString Unknown33 { get; set; }
        public SeString Unknown34 { get; set; }
        public SeString Unknown35 { get; set; }
        public SeString Unknown36 { get; set; }
        public SeString Unknown37 { get; set; }
        public SeString Unknown38 { get; set; }
        public SeString Unknown39 { get; set; }
        public SeString Unknown40 { get; set; }
        public SeString Unknown41 { get; set; }
        public uint Unknown42 { get; set; }
        public uint Unknown43 { get; set; }
        public uint Unknown44 { get; set; }
        public uint Unknown45 { get; set; }
        public uint Unknown46 { get; set; }
        public uint Unknown47 { get; set; }
        public uint Unknown48 { get; set; }
        public uint Unknown49 { get; set; }
        public uint Unknown50 { get; set; }
        public uint Unknown51 { get; set; }
        public uint Unknown52 { get; set; }
        public uint Unknown53 { get; set; }
        public uint Unknown54 { get; set; }
        public uint Unknown55 { get; set; }
        public uint Unknown56 { get; set; }
        public uint Unknown57 { get; set; }
        public uint Unknown58 { get; set; }
        public uint Unknown59 { get; set; }
        public uint Unknown60 { get; set; }
        public uint Unknown61 { get; set; }
        public uint Unknown62 { get; set; }
        public uint Unknown63 { get; set; }
        public uint Unknown64 { get; set; }
        public uint Unknown65 { get; set; }
        public uint Unknown66 { get; set; }
        public uint Unknown67 { get; set; }
        public uint Unknown68 { get; set; }
        public uint Unknown69 { get; set; }
        public uint Unknown70 { get; set; }
        public uint Unknown71 { get; set; }
        public uint Unknown72 { get; set; }
        public uint Unknown73 { get; set; }
        public uint Unknown74 { get; set; }
        public uint Unknown75 { get; set; }
        public uint Unknown76 { get; set; }
        public uint Unknown77 { get; set; }
        public uint Unknown78 { get; set; }
        public uint Unknown79 { get; set; }
        public uint Unknown80 { get; set; }
        public uint Unknown81 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 1 ), language );
            Unknown2 = parser.ReadColumn< SeString >( 2 );
            Unknown3 = parser.ReadColumn< SeString >( 3 );
            Unknown4 = parser.ReadColumn< SeString >( 4 );
            Unknown5 = parser.ReadColumn< SeString >( 5 );
            Unknown6 = parser.ReadColumn< SeString >( 6 );
            Unknown7 = parser.ReadColumn< SeString >( 7 );
            Unknown8 = parser.ReadColumn< SeString >( 8 );
            Unknown9 = parser.ReadColumn< SeString >( 9 );
            Unknown10 = parser.ReadColumn< SeString >( 10 );
            Unknown11 = parser.ReadColumn< SeString >( 11 );
            Unknown12 = parser.ReadColumn< SeString >( 12 );
            Unknown13 = parser.ReadColumn< SeString >( 13 );
            Unknown14 = parser.ReadColumn< SeString >( 14 );
            Unknown15 = parser.ReadColumn< SeString >( 15 );
            Unknown16 = parser.ReadColumn< SeString >( 16 );
            Unknown17 = parser.ReadColumn< SeString >( 17 );
            Unknown18 = parser.ReadColumn< SeString >( 18 );
            Unknown19 = parser.ReadColumn< SeString >( 19 );
            Unknown20 = parser.ReadColumn< SeString >( 20 );
            Unknown21 = parser.ReadColumn< SeString >( 21 );
            Unknown22 = parser.ReadColumn< SeString >( 22 );
            Unknown23 = parser.ReadColumn< SeString >( 23 );
            Unknown24 = parser.ReadColumn< SeString >( 24 );
            Unknown25 = parser.ReadColumn< SeString >( 25 );
            Unknown26 = parser.ReadColumn< SeString >( 26 );
            Unknown27 = parser.ReadColumn< SeString >( 27 );
            Unknown28 = parser.ReadColumn< SeString >( 28 );
            Unknown29 = parser.ReadColumn< SeString >( 29 );
            Unknown30 = parser.ReadColumn< SeString >( 30 );
            Unknown31 = parser.ReadColumn< SeString >( 31 );
            Unknown32 = parser.ReadColumn< SeString >( 32 );
            Unknown33 = parser.ReadColumn< SeString >( 33 );
            Unknown34 = parser.ReadColumn< SeString >( 34 );
            Unknown35 = parser.ReadColumn< SeString >( 35 );
            Unknown36 = parser.ReadColumn< SeString >( 36 );
            Unknown37 = parser.ReadColumn< SeString >( 37 );
            Unknown38 = parser.ReadColumn< SeString >( 38 );
            Unknown39 = parser.ReadColumn< SeString >( 39 );
            Unknown40 = parser.ReadColumn< SeString >( 40 );
            Unknown41 = parser.ReadColumn< SeString >( 41 );
            Unknown42 = parser.ReadColumn< uint >( 42 );
            Unknown43 = parser.ReadColumn< uint >( 43 );
            Unknown44 = parser.ReadColumn< uint >( 44 );
            Unknown45 = parser.ReadColumn< uint >( 45 );
            Unknown46 = parser.ReadColumn< uint >( 46 );
            Unknown47 = parser.ReadColumn< uint >( 47 );
            Unknown48 = parser.ReadColumn< uint >( 48 );
            Unknown49 = parser.ReadColumn< uint >( 49 );
            Unknown50 = parser.ReadColumn< uint >( 50 );
            Unknown51 = parser.ReadColumn< uint >( 51 );
            Unknown52 = parser.ReadColumn< uint >( 52 );
            Unknown53 = parser.ReadColumn< uint >( 53 );
            Unknown54 = parser.ReadColumn< uint >( 54 );
            Unknown55 = parser.ReadColumn< uint >( 55 );
            Unknown56 = parser.ReadColumn< uint >( 56 );
            Unknown57 = parser.ReadColumn< uint >( 57 );
            Unknown58 = parser.ReadColumn< uint >( 58 );
            Unknown59 = parser.ReadColumn< uint >( 59 );
            Unknown60 = parser.ReadColumn< uint >( 60 );
            Unknown61 = parser.ReadColumn< uint >( 61 );
            Unknown62 = parser.ReadColumn< uint >( 62 );
            Unknown63 = parser.ReadColumn< uint >( 63 );
            Unknown64 = parser.ReadColumn< uint >( 64 );
            Unknown65 = parser.ReadColumn< uint >( 65 );
            Unknown66 = parser.ReadColumn< uint >( 66 );
            Unknown67 = parser.ReadColumn< uint >( 67 );
            Unknown68 = parser.ReadColumn< uint >( 68 );
            Unknown69 = parser.ReadColumn< uint >( 69 );
            Unknown70 = parser.ReadColumn< uint >( 70 );
            Unknown71 = parser.ReadColumn< uint >( 71 );
            Unknown72 = parser.ReadColumn< uint >( 72 );
            Unknown73 = parser.ReadColumn< uint >( 73 );
            Unknown74 = parser.ReadColumn< uint >( 74 );
            Unknown75 = parser.ReadColumn< uint >( 75 );
            Unknown76 = parser.ReadColumn< uint >( 76 );
            Unknown77 = parser.ReadColumn< uint >( 77 );
            Unknown78 = parser.ReadColumn< uint >( 78 );
            Unknown79 = parser.ReadColumn< uint >( 79 );
            Unknown80 = parser.ReadColumn< uint >( 80 );
            Unknown81 = parser.ReadColumn< uint >( 81 );
        }
    }
}