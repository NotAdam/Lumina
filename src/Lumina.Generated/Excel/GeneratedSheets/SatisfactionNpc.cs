using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SatisfactionNpc", columnHash: 0x7a8036fa )]
    public class SatisfactionNpc : IExcelRow
    {
        public struct UnkStruct16Struct
        {
            public int Item;
            public int ItemCount;
            public int IsHQ;
        }
        
        public LazyRow< ENpcResident > Npc;
        public LazyRow< Quest > QuestRequired;
        public byte LevelUnlock;
        public byte DeliveriesPerWeek;
        public int[] SupplyIndex;
        public ushort[] SatisfactionRequired;
        public UnkStruct16Struct[] UnkStruct16;
        public byte Unknown25;
        public byte Unknown26;
        public byte Unknown27;
        public bool Unknown28;
        public bool Unknown29;
        public bool Unknown30;
        public bool Unknown31;
        public bool Unknown32;
        public bool Unknown33;
        public int Unknown34;
        public int Unknown35;
        public int Unknown36;
        public int Unknown37;
        public int Unknown38;
        public int Unknown39;
        public byte Unknown40;
        public byte Unknown41;
        public byte Unknown42;
        public byte Unknown43;
        public byte Unknown44;
        public byte Unknown45;
        public bool Unknown46;
        public bool Unknown47;
        public bool Unknown48;
        public bool Unknown49;
        public bool Unknown50;
        public bool Unknown51;
        public int Unknown52;
        public int Unknown53;
        public int Unknown54;
        public int Unknown55;
        public int Unknown56;
        public int Unknown57;
        public byte Unknown58;
        public byte Unknown59;
        public byte Unknown60;
        public byte Unknown61;
        public byte Unknown62;
        public byte Unknown63;
        public bool Unknown64;
        public bool Unknown65;
        public bool Unknown66;
        public bool Unknown67;
        public bool Unknown68;
        public bool Unknown69;
        public int Icon;
        public byte Unknown71;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Npc = new LazyRow< ENpcResident >( lumina, parser.ReadColumn< int >( 0 ), language );
            QuestRequired = new LazyRow< Quest >( lumina, parser.ReadColumn< int >( 1 ), language );
            LevelUnlock = parser.ReadColumn< byte >( 2 );
            DeliveriesPerWeek = parser.ReadColumn< byte >( 3 );
            SupplyIndex = new int[ 6 ];
            for( var i = 0; i < 6; i++ )
                SupplyIndex[ i ] = parser.ReadColumn< int >( 4 + i );
            SatisfactionRequired = new ushort[ 6 ];
            for( var i = 0; i < 6; i++ )
                SatisfactionRequired[ i ] = parser.ReadColumn< ushort >( 10 + i );
            UnkStruct16 = new UnkStruct16Struct[ 3 ];
            for( var i = 0; i < 3; i++ )
            {
                UnkStruct16[ i ] = new UnkStruct16Struct();
                UnkStruct16[ i ].Item = parser.ReadColumn< int >( 16 + ( i * 3 + 0 ) );
                UnkStruct16[ i ].ItemCount = parser.ReadColumn< int >( 16 + ( i * 3 + 1 ) );
                UnkStruct16[ i ].IsHQ = parser.ReadColumn< int >( 16 + ( i * 3 + 2 ) );
            }
            Unknown25 = parser.ReadColumn< byte >( 25 );
            Unknown26 = parser.ReadColumn< byte >( 26 );
            Unknown27 = parser.ReadColumn< byte >( 27 );
            Unknown28 = parser.ReadColumn< bool >( 28 );
            Unknown29 = parser.ReadColumn< bool >( 29 );
            Unknown30 = parser.ReadColumn< bool >( 30 );
            Unknown31 = parser.ReadColumn< bool >( 31 );
            Unknown32 = parser.ReadColumn< bool >( 32 );
            Unknown33 = parser.ReadColumn< bool >( 33 );
            Unknown34 = parser.ReadColumn< int >( 34 );
            Unknown35 = parser.ReadColumn< int >( 35 );
            Unknown36 = parser.ReadColumn< int >( 36 );
            Unknown37 = parser.ReadColumn< int >( 37 );
            Unknown38 = parser.ReadColumn< int >( 38 );
            Unknown39 = parser.ReadColumn< int >( 39 );
            Unknown40 = parser.ReadColumn< byte >( 40 );
            Unknown41 = parser.ReadColumn< byte >( 41 );
            Unknown42 = parser.ReadColumn< byte >( 42 );
            Unknown43 = parser.ReadColumn< byte >( 43 );
            Unknown44 = parser.ReadColumn< byte >( 44 );
            Unknown45 = parser.ReadColumn< byte >( 45 );
            Unknown46 = parser.ReadColumn< bool >( 46 );
            Unknown47 = parser.ReadColumn< bool >( 47 );
            Unknown48 = parser.ReadColumn< bool >( 48 );
            Unknown49 = parser.ReadColumn< bool >( 49 );
            Unknown50 = parser.ReadColumn< bool >( 50 );
            Unknown51 = parser.ReadColumn< bool >( 51 );
            Unknown52 = parser.ReadColumn< int >( 52 );
            Unknown53 = parser.ReadColumn< int >( 53 );
            Unknown54 = parser.ReadColumn< int >( 54 );
            Unknown55 = parser.ReadColumn< int >( 55 );
            Unknown56 = parser.ReadColumn< int >( 56 );
            Unknown57 = parser.ReadColumn< int >( 57 );
            Unknown58 = parser.ReadColumn< byte >( 58 );
            Unknown59 = parser.ReadColumn< byte >( 59 );
            Unknown60 = parser.ReadColumn< byte >( 60 );
            Unknown61 = parser.ReadColumn< byte >( 61 );
            Unknown62 = parser.ReadColumn< byte >( 62 );
            Unknown63 = parser.ReadColumn< byte >( 63 );
            Unknown64 = parser.ReadColumn< bool >( 64 );
            Unknown65 = parser.ReadColumn< bool >( 65 );
            Unknown66 = parser.ReadColumn< bool >( 66 );
            Unknown67 = parser.ReadColumn< bool >( 67 );
            Unknown68 = parser.ReadColumn< bool >( 68 );
            Unknown69 = parser.ReadColumn< bool >( 69 );
            Icon = parser.ReadColumn< int >( 70 );
            Unknown71 = parser.ReadColumn< byte >( 71 );
        }
    }
}