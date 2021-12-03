// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HugeCraftworksNpc", columnHash: 0xc1d2986a )]
    public partial class HugeCraftworksNpc : ExcelRow
    {
        
        public LazyRow< ENpcResident > ENpcResident { get; set; }
        public LazyRow< ClassJobCategory > ClassJobCategory { get; set; }
        public uint Unknown2 { get; set; }
        public LazyRow< Item >[] ItemRequested { get; set; }
        public uint Unknown7 { get; set; }
        public byte Unknown8 { get; set; }
        public byte[] QtyRequested { get; set; }
        public byte Unknown13 { get; set; }
        public bool Unknown14 { get; set; }
        public bool Unknown15 { get; set; }
        public bool Unknown16 { get; set; }
        public bool Unknown17 { get; set; }
        public bool Unknown18 { get; set; }
        public bool Unknown19 { get; set; }
        public byte Unknown20 { get; set; }
        public byte Unknown21 { get; set; }
        public byte Unknown22 { get; set; }
        public byte Unknown23 { get; set; }
        public byte Unknown24 { get; set; }
        public byte Unknown25 { get; set; }
        public byte Unknown26 { get; set; }
        public byte Unknown27 { get; set; }
        public byte Unknown28 { get; set; }
        public byte Unknown29 { get; set; }
        public byte Unknown30 { get; set; }
        public byte Unknown31 { get; set; }
        public byte Unknown32 { get; set; }
        public byte Unknown33 { get; set; }
        public byte Unknown34 { get; set; }
        public byte Unknown35 { get; set; }
        public byte Unknown36 { get; set; }
        public byte Unknown37 { get; set; }
        public ushort Unknown38 { get; set; }
        public ushort Unknown39 { get; set; }
        public ushort Unknown40 { get; set; }
        public ushort Unknown41 { get; set; }
        public ushort Unknown42 { get; set; }
        public ushort Unknown43 { get; set; }
        public byte Unknown44 { get; set; }
        public byte Unknown45 { get; set; }
        public byte Unknown46 { get; set; }
        public byte Unknown47 { get; set; }
        public byte Unknown48 { get; set; }
        public byte Unknown49 { get; set; }
        public byte Unknown50 { get; set; }
        public byte Unknown51 { get; set; }
        public LazyRow< Item >[] ItemReward { get; set; }
        public uint Unknown56 { get; set; }
        public uint Unknown57 { get; set; }
        public uint Unknown58 { get; set; }
        public uint Unknown59 { get; set; }
        public uint Unknown60 { get; set; }
        public uint Unknown61 { get; set; }
        public bool Unknown62 { get; set; }
        public bool Unknown63 { get; set; }
        public bool[] QtyItemReward { get; set; }
        public byte Unknown68 { get; set; }
        public byte Unknown69 { get; set; }
        public LazyRow< Item >[] ItemUnkown { get; set; }
        public uint Unknown74 { get; set; }
        public uint Unknown75 { get; set; }
        public uint Unknown76 { get; set; }
        public uint Unknown77 { get; set; }
        public uint Unknown78 { get; set; }
        public uint Unknown79 { get; set; }
        public bool Unknown80 { get; set; }
        public bool Unknown81 { get; set; }
        public bool[] QtyItemUnkown { get; set; }
        public byte Transient { get; set; }
        public byte Unknown87 { get; set; }
        public byte Unknown88 { get; set; }
        public byte Unknown89 { get; set; }
        public byte Unknown90 { get; set; }
        public byte Unknown91 { get; set; }
        public SeString Unknown92 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ENpcResident = new LazyRow< ENpcResident >( gameData, parser.ReadColumn< uint >( 0 ), language );
            ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            Unknown2 = parser.ReadColumn< uint >( 2 );
            ItemRequested = new LazyRow< Item >[ 4 ];
            for( var i = 0; i < 4; i++ )
                ItemRequested[ i ] = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 3 + i ), language );
            Unknown7 = parser.ReadColumn< uint >( 7 );
            Unknown8 = parser.ReadColumn< byte >( 8 );
            QtyRequested = new byte[ 4 ];
            for( var i = 0; i < 4; i++ )
                QtyRequested[ i ] = parser.ReadColumn< byte >( 9 + i );
            Unknown13 = parser.ReadColumn< byte >( 13 );
            Unknown14 = parser.ReadColumn< bool >( 14 );
            Unknown15 = parser.ReadColumn< bool >( 15 );
            Unknown16 = parser.ReadColumn< bool >( 16 );
            Unknown17 = parser.ReadColumn< bool >( 17 );
            Unknown18 = parser.ReadColumn< bool >( 18 );
            Unknown19 = parser.ReadColumn< bool >( 19 );
            Unknown20 = parser.ReadColumn< byte >( 20 );
            Unknown21 = parser.ReadColumn< byte >( 21 );
            Unknown22 = parser.ReadColumn< byte >( 22 );
            Unknown23 = parser.ReadColumn< byte >( 23 );
            Unknown24 = parser.ReadColumn< byte >( 24 );
            Unknown25 = parser.ReadColumn< byte >( 25 );
            Unknown26 = parser.ReadColumn< byte >( 26 );
            Unknown27 = parser.ReadColumn< byte >( 27 );
            Unknown28 = parser.ReadColumn< byte >( 28 );
            Unknown29 = parser.ReadColumn< byte >( 29 );
            Unknown30 = parser.ReadColumn< byte >( 30 );
            Unknown31 = parser.ReadColumn< byte >( 31 );
            Unknown32 = parser.ReadColumn< byte >( 32 );
            Unknown33 = parser.ReadColumn< byte >( 33 );
            Unknown34 = parser.ReadColumn< byte >( 34 );
            Unknown35 = parser.ReadColumn< byte >( 35 );
            Unknown36 = parser.ReadColumn< byte >( 36 );
            Unknown37 = parser.ReadColumn< byte >( 37 );
            Unknown38 = parser.ReadColumn< ushort >( 38 );
            Unknown39 = parser.ReadColumn< ushort >( 39 );
            Unknown40 = parser.ReadColumn< ushort >( 40 );
            Unknown41 = parser.ReadColumn< ushort >( 41 );
            Unknown42 = parser.ReadColumn< ushort >( 42 );
            Unknown43 = parser.ReadColumn< ushort >( 43 );
            Unknown44 = parser.ReadColumn< byte >( 44 );
            Unknown45 = parser.ReadColumn< byte >( 45 );
            Unknown46 = parser.ReadColumn< byte >( 46 );
            Unknown47 = parser.ReadColumn< byte >( 47 );
            Unknown48 = parser.ReadColumn< byte >( 48 );
            Unknown49 = parser.ReadColumn< byte >( 49 );
            Unknown50 = parser.ReadColumn< byte >( 50 );
            Unknown51 = parser.ReadColumn< byte >( 51 );
            ItemReward = new LazyRow< Item >[ 4 ];
            for( var i = 0; i < 4; i++ )
                ItemReward[ i ] = new LazyRow< Item >( gameData, parser.ReadColumn< byte >( 52 + i ), language );
            Unknown56 = parser.ReadColumn< uint >( 56 );
            Unknown57 = parser.ReadColumn< uint >( 57 );
            Unknown58 = parser.ReadColumn< uint >( 58 );
            Unknown59 = parser.ReadColumn< uint >( 59 );
            Unknown60 = parser.ReadColumn< uint >( 60 );
            Unknown61 = parser.ReadColumn< uint >( 61 );
            Unknown62 = parser.ReadColumn< bool >( 62 );
            Unknown63 = parser.ReadColumn< bool >( 63 );
            QtyItemReward = new bool[ 4 ];
            for( var i = 0; i < 4; i++ )
                QtyItemReward[ i ] = parser.ReadColumn< bool >( 64 + i );
            Unknown68 = parser.ReadColumn< byte >( 68 );
            Unknown69 = parser.ReadColumn< byte >( 69 );
            ItemUnkown = new LazyRow< Item >[ 4 ];
            for( var i = 0; i < 4; i++ )
                ItemUnkown[ i ] = new LazyRow< Item >( gameData, parser.ReadColumn< byte >( 70 + i ), language );
            Unknown74 = parser.ReadColumn< uint >( 74 );
            Unknown75 = parser.ReadColumn< uint >( 75 );
            Unknown76 = parser.ReadColumn< uint >( 76 );
            Unknown77 = parser.ReadColumn< uint >( 77 );
            Unknown78 = parser.ReadColumn< uint >( 78 );
            Unknown79 = parser.ReadColumn< uint >( 79 );
            Unknown80 = parser.ReadColumn< bool >( 80 );
            Unknown81 = parser.ReadColumn< bool >( 81 );
            QtyItemUnkown = new bool[ 4 ];
            for( var i = 0; i < 4; i++ )
                QtyItemUnkown[ i ] = parser.ReadColumn< bool >( 82 + i );
            Transient = parser.ReadColumn< byte >( 86 );
            Unknown87 = parser.ReadColumn< byte >( 87 );
            Unknown88 = parser.ReadColumn< byte >( 88 );
            Unknown89 = parser.ReadColumn< byte >( 89 );
            Unknown90 = parser.ReadColumn< byte >( 90 );
            Unknown91 = parser.ReadColumn< byte >( 91 );
            Unknown92 = parser.ReadColumn< SeString >( 92 );
        }
    }
}