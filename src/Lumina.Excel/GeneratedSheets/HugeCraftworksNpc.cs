// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HugeCraftworksNpc", columnHash: 0xb9ae7ade )]
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
        public uint Unknown50 { get; set; }
        public uint Unknown51 { get; set; }
        public LazyRow< Item >[] ItemReward { get; set; }
        public bool Unknown56 { get; set; }
        public bool Unknown57 { get; set; }
        public bool Unknown58 { get; set; }
        public bool Unknown59 { get; set; }
        public bool Unknown60 { get; set; }
        public bool Unknown61 { get; set; }
        public byte Unknown62 { get; set; }
        public byte Unknown63 { get; set; }
        public byte[] QtyItemReward { get; set; }
        public uint Unknown68 { get; set; }
        public uint Unknown69 { get; set; }
        public LazyRow< Item >[] ItemUnkown { get; set; }
        public bool Unknown74 { get; set; }
        public bool Unknown75 { get; set; }
        public bool Unknown76 { get; set; }
        public bool Unknown77 { get; set; }
        public bool Unknown78 { get; set; }
        public bool Unknown79 { get; set; }
        public byte Unknown80 { get; set; }
        public byte Unknown81 { get; set; }
        public byte[] QtyItemUnkown { get; set; }
        public SeString Transient { get; set; }
        
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
            Unknown50 = parser.ReadColumn< uint >( 50 );
            Unknown51 = parser.ReadColumn< uint >( 51 );
            ItemReward = new LazyRow< Item >[ 4 ];
            for( var i = 0; i < 4; i++ )
                ItemReward[ i ] = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 52 + i ), language );
            Unknown56 = parser.ReadColumn< bool >( 56 );
            Unknown57 = parser.ReadColumn< bool >( 57 );
            Unknown58 = parser.ReadColumn< bool >( 58 );
            Unknown59 = parser.ReadColumn< bool >( 59 );
            Unknown60 = parser.ReadColumn< bool >( 60 );
            Unknown61 = parser.ReadColumn< bool >( 61 );
            Unknown62 = parser.ReadColumn< byte >( 62 );
            Unknown63 = parser.ReadColumn< byte >( 63 );
            QtyItemReward = new byte[ 4 ];
            for( var i = 0; i < 4; i++ )
                QtyItemReward[ i ] = parser.ReadColumn< byte >( 64 + i );
            Unknown68 = parser.ReadColumn< uint >( 68 );
            Unknown69 = parser.ReadColumn< uint >( 69 );
            ItemUnkown = new LazyRow< Item >[ 4 ];
            for( var i = 0; i < 4; i++ )
                ItemUnkown[ i ] = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 70 + i ), language );
            Unknown74 = parser.ReadColumn< bool >( 74 );
            Unknown75 = parser.ReadColumn< bool >( 75 );
            Unknown76 = parser.ReadColumn< bool >( 76 );
            Unknown77 = parser.ReadColumn< bool >( 77 );
            Unknown78 = parser.ReadColumn< bool >( 78 );
            Unknown79 = parser.ReadColumn< bool >( 79 );
            Unknown80 = parser.ReadColumn< byte >( 80 );
            Unknown81 = parser.ReadColumn< byte >( 81 );
            QtyItemUnkown = new byte[ 4 ];
            for( var i = 0; i < 4; i++ )
                QtyItemUnkown[ i ] = parser.ReadColumn< byte >( 82 + i );
            Transient = parser.ReadColumn< SeString >( 86 );
        }
    }
}