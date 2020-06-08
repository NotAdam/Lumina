using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HugeCraftworksNpc", columnHash: 0x79685419 )]
    public class HugeCraftworksNpc : IExcelRow
    {
        
        public LazyRow< ENpcResident > ENpcResident;
        public LazyRow< ClassJobCategory > ClassJobCategory;
        public uint Unknown2;
        public LazyRow< Item >[] ItemRequested;
        public uint Unknown7;
        public byte Unknown8;
        public byte[] QtyRequested;
        public byte Unknown13;
        public bool Unknown14;
        public bool Unknown15;
        public bool Unknown16;
        public bool Unknown17;
        public bool Unknown18;
        public bool Unknown19;
        public byte Unknown20;
        public byte Unknown21;
        public byte Unknown22;
        public byte Unknown23;
        public byte Unknown24;
        public byte Unknown25;
        public byte Unknown26;
        public byte Unknown27;
        public byte Unknown28;
        public byte Unknown29;
        public byte Unknown30;
        public byte Unknown31;
        public byte Unknown32;
        public byte Unknown33;
        public byte Unknown34;
        public byte Unknown35;
        public byte Unknown36;
        public byte Unknown37;
        public ushort Unknown38;
        public ushort Unknown39;
        public ushort Unknown40;
        public ushort Unknown41;
        public ushort Unknown42;
        public ushort Unknown43;
        public byte Unknown44;
        public byte Unknown45;
        public byte Unknown46;
        public byte Unknown47;
        public byte Unknown48;
        public byte Unknown49;
        public uint Unknown50;
        public uint Unknown51;
        public LazyRow< Item >[] ItemReward;
        public bool Unknown56;
        public bool Unknown57;
        public bool Unknown58;
        public bool Unknown59;
        public bool Unknown60;
        public bool Unknown61;
        public byte Unknown62;
        public byte Unknown63;
        public byte[] QtyItemReward;
        public uint Unknown68;
        public uint Unknown69;
        public LazyRow< Item >[] ItemUnkown;
        public bool Unknown74;
        public bool Unknown75;
        public bool Unknown76;
        public bool Unknown77;
        public bool Unknown78;
        public bool Unknown79;
        public byte Unknown80;
        public byte Unknown81;
        public byte[] QtyItemUnkown;
        public string Transient;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ENpcResident = new LazyRow< ENpcResident >( lumina, parser.ReadColumn< uint >( 0 ) );
            ClassJobCategory = new LazyRow< ClassJobCategory >( lumina, parser.ReadColumn< ushort >( 1 ) );
            Unknown2 = parser.ReadColumn< uint >( 2 );
            ItemRequested = new LazyRow< Item >[ 4 ];
            for( var i = 0; i < 4; i++ )
                ItemRequested[ i ] = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 3 + i ) );
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
                ItemReward[ i ] = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 52 + i ) );
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
                ItemUnkown[ i ] = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 70 + i ) );
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
            Transient = parser.ReadColumn< string >( 86 );
        }
    }
}