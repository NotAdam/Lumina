// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestRedo", columnHash: 0x9e53f329 )]
    public partial class QuestRedo : ExcelRow
    {
        
        public LazyRow< Quest > FinalQuest { get; set; }
        public uint Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public ushort Chapter { get; set; }
        public LazyRow< Quest >[] Quest { get; set; }
        public byte Unknown36 { get; set; }
        public byte Unknown37 { get; set; }
        public byte Unknown38 { get; set; }
        public byte Unknown39 { get; set; }
        public byte Unknown40 { get; set; }
        public byte Unknown41 { get; set; }
        public byte Unknown42 { get; set; }
        public byte Unknown43 { get; set; }
        public byte Unknown44 { get; set; }
        public byte Unknown45 { get; set; }
        public byte Unknown46 { get; set; }
        public byte Unknown47 { get; set; }
        public byte Unknown48 { get; set; }
        public byte Unknown49 { get; set; }
        public byte Unknown50 { get; set; }
        public byte Unknown51 { get; set; }
        public byte Unknown52 { get; set; }
        public byte Unknown53 { get; set; }
        public byte Unknown54 { get; set; }
        public byte Unknown55 { get; set; }
        public byte Unknown56 { get; set; }
        public byte Unknown57 { get; set; }
        public byte Unknown58 { get; set; }
        public byte Unknown59 { get; set; }
        public byte Unknown60 { get; set; }
        public byte Unknown61 { get; set; }
        public byte Unknown62 { get; set; }
        public byte Unknown63 { get; set; }
        public byte Unknown64 { get; set; }
        public byte Unknown65 { get; set; }
        public byte Unknown66 { get; set; }
        public byte Unknown67 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            FinalQuest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Unknown1 = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Chapter = parser.ReadColumn< ushort >( 3 );
            Quest = new LazyRow< Quest >[ 32 ];
            for( var i = 0; i < 32; i++ )
                Quest[ i ] = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 4 + i ), language );
            Unknown36 = parser.ReadColumn< byte >( 36 );
            Unknown37 = parser.ReadColumn< byte >( 37 );
            Unknown38 = parser.ReadColumn< byte >( 38 );
            Unknown39 = parser.ReadColumn< byte >( 39 );
            Unknown40 = parser.ReadColumn< byte >( 40 );
            Unknown41 = parser.ReadColumn< byte >( 41 );
            Unknown42 = parser.ReadColumn< byte >( 42 );
            Unknown43 = parser.ReadColumn< byte >( 43 );
            Unknown44 = parser.ReadColumn< byte >( 44 );
            Unknown45 = parser.ReadColumn< byte >( 45 );
            Unknown46 = parser.ReadColumn< byte >( 46 );
            Unknown47 = parser.ReadColumn< byte >( 47 );
            Unknown48 = parser.ReadColumn< byte >( 48 );
            Unknown49 = parser.ReadColumn< byte >( 49 );
            Unknown50 = parser.ReadColumn< byte >( 50 );
            Unknown51 = parser.ReadColumn< byte >( 51 );
            Unknown52 = parser.ReadColumn< byte >( 52 );
            Unknown53 = parser.ReadColumn< byte >( 53 );
            Unknown54 = parser.ReadColumn< byte >( 54 );
            Unknown55 = parser.ReadColumn< byte >( 55 );
            Unknown56 = parser.ReadColumn< byte >( 56 );
            Unknown57 = parser.ReadColumn< byte >( 57 );
            Unknown58 = parser.ReadColumn< byte >( 58 );
            Unknown59 = parser.ReadColumn< byte >( 59 );
            Unknown60 = parser.ReadColumn< byte >( 60 );
            Unknown61 = parser.ReadColumn< byte >( 61 );
            Unknown62 = parser.ReadColumn< byte >( 62 );
            Unknown63 = parser.ReadColumn< byte >( 63 );
            Unknown64 = parser.ReadColumn< byte >( 64 );
            Unknown65 = parser.ReadColumn< byte >( 65 );
            Unknown66 = parser.ReadColumn< byte >( 66 );
            Unknown67 = parser.ReadColumn< byte >( 67 );
        }
    }
}