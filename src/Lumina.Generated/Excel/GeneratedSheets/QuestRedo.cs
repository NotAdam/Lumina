// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestRedo", columnHash: 0x35f497dd )]
    public class QuestRedo : IExcelRow
    {
        
        public LazyRow< Quest > FinalQuest;
        public byte Unknown1;
        public ushort Chapter;
        public LazyRow< Quest >[] Quest;
        public byte Unknown35;
        public byte Unknown36;
        public byte Unknown37;
        public byte Unknown38;
        public byte Unknown39;
        public byte Unknown40;
        public byte Unknown41;
        public byte Unknown42;
        public byte Unknown43;
        public byte Unknown44;
        public byte Unknown45;
        public byte Unknown46;
        public byte Unknown47;
        public byte Unknown48;
        public byte Unknown49;
        public byte Unknown50;
        public byte Unknown51;
        public byte Unknown52;
        public byte Unknown53;
        public byte Unknown54;
        public byte Unknown55;
        public byte Unknown56;
        public byte Unknown57;
        public byte Unknown58;
        public byte Unknown59;
        public byte Unknown60;
        public byte Unknown61;
        public byte Unknown62;
        public byte Unknown63;
        public byte Unknown64;
        public byte Unknown65;
        public byte Unknown66;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            FinalQuest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 0 ), language );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Chapter = parser.ReadColumn< ushort >( 2 );
            Quest = new LazyRow< Quest >[ 32 ];
            for( var i = 0; i < 32; i++ )
                Quest[ i ] = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 3 + i ), language );
            Unknown35 = parser.ReadColumn< byte >( 35 );
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
        }
    }
}