// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SatisfactionNpc", columnHash: 0xd50a940f )]
    public partial class SatisfactionNpc : ExcelRow
    {
        public class SatisfactionNpcUnkData16Obj
        {
            public int Item { get; set; }
            public int ItemCount { get; set; }
            public int IsHQ { get; set; }
        }
        
        public LazyRow< ENpcResident > Npc { get; set; }
        public LazyRow< Quest > QuestRequired { get; set; }
        public byte LevelUnlock { get; set; }
        public byte DeliveriesPerWeek { get; set; }
        public int[] SupplyIndex { get; set; }
        public ushort[] SatisfactionRequired { get; set; }
        public SatisfactionNpcUnkData16Obj[] UnkData16 { get; set; }
        public byte Unknown25 { get; set; }
        public byte Unknown26 { get; set; }
        public byte Unknown27 { get; set; }
        public bool Unknown28 { get; set; }
        public bool Unknown29 { get; set; }
        public bool Unknown30 { get; set; }
        public bool Unknown31 { get; set; }
        public bool Unknown32 { get; set; }
        public bool Unknown33 { get; set; }
        public int Unknown34 { get; set; }
        public int Unknown35 { get; set; }
        public int Unknown36 { get; set; }
        public int Unknown37 { get; set; }
        public int Unknown38 { get; set; }
        public int Unknown39 { get; set; }
        public byte Unknown40 { get; set; }
        public byte Unknown41 { get; set; }
        public byte Unknown42 { get; set; }
        public byte Unknown43 { get; set; }
        public byte Unknown44 { get; set; }
        public byte Unknown45 { get; set; }
        public bool Unknown46 { get; set; }
        public bool Unknown47 { get; set; }
        public bool Unknown48 { get; set; }
        public bool Unknown49 { get; set; }
        public bool Unknown50 { get; set; }
        public bool Unknown51 { get; set; }
        public int Unknown52 { get; set; }
        public int Unknown53 { get; set; }
        public int Unknown54 { get; set; }
        public int Unknown55 { get; set; }
        public int Unknown56 { get; set; }
        public int Unknown57 { get; set; }
        public byte Unknown58 { get; set; }
        public byte Unknown59 { get; set; }
        public byte Unknown60 { get; set; }
        public byte Unknown61 { get; set; }
        public byte Unknown62 { get; set; }
        public byte Unknown63 { get; set; }
        public bool Unknown64 { get; set; }
        public bool Unknown65 { get; set; }
        public bool Unknown66 { get; set; }
        public bool Unknown67 { get; set; }
        public bool Unknown68 { get; set; }
        public bool Unknown69 { get; set; }
        public int Unknown70 { get; set; }
        public int Unknown71 { get; set; }
        public int Unknown72 { get; set; }
        public int Unknown73 { get; set; }
        public int Unknown74 { get; set; }
        public int Unknown75 { get; set; }
        public int Unknown76 { get; set; }
        public int Unknown77 { get; set; }
        public int Unknown78 { get; set; }
        public int Unknown79 { get; set; }
        public int Unknown80 { get; set; }
        public int Unknown81 { get; set; }
        public int Unknown82 { get; set; }
        public int Unknown83 { get; set; }
        public int Unknown84 { get; set; }
        public int Unknown85 { get; set; }
        public int Unknown86 { get; set; }
        public int Unknown87 { get; set; }
        public int Icon { get; set; }
        public byte Unknown89 { get; set; }
        public byte Unknown90 { get; set; }
        public byte Unknown91 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Npc = new LazyRow< ENpcResident >( gameData, parser.ReadColumn< int >( 0 ), language );
            QuestRequired = new LazyRow< Quest >( gameData, parser.ReadColumn< int >( 1 ), language );
            LevelUnlock = parser.ReadColumn< byte >( 2 );
            DeliveriesPerWeek = parser.ReadColumn< byte >( 3 );
            SupplyIndex = new int[ 6 ];
            for( var i = 0; i < 6; i++ )
                SupplyIndex[ i ] = parser.ReadColumn< int >( 4 + i );
            SatisfactionRequired = new ushort[ 6 ];
            for( var i = 0; i < 6; i++ )
                SatisfactionRequired[ i ] = parser.ReadColumn< ushort >( 10 + i );
            UnkData16 = new SatisfactionNpcUnkData16Obj[ 3 ];
            for( var i = 0; i < 3; i++ )
            {
                UnkData16[ i ] = new SatisfactionNpcUnkData16Obj();
                UnkData16[ i ].Item = parser.ReadColumn< int >( 16 + ( i * 3 + 0 ) );
                UnkData16[ i ].ItemCount = parser.ReadColumn< int >( 16 + ( i * 3 + 1 ) );
                UnkData16[ i ].IsHQ = parser.ReadColumn< int >( 16 + ( i * 3 + 2 ) );
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
            Unknown70 = parser.ReadColumn< int >( 70 );
            Unknown71 = parser.ReadColumn< int >( 71 );
            Unknown72 = parser.ReadColumn< int >( 72 );
            Unknown73 = parser.ReadColumn< int >( 73 );
            Unknown74 = parser.ReadColumn< int >( 74 );
            Unknown75 = parser.ReadColumn< int >( 75 );
            Unknown76 = parser.ReadColumn< int >( 76 );
            Unknown77 = parser.ReadColumn< int >( 77 );
            Unknown78 = parser.ReadColumn< int >( 78 );
            Unknown79 = parser.ReadColumn< int >( 79 );
            Unknown80 = parser.ReadColumn< int >( 80 );
            Unknown81 = parser.ReadColumn< int >( 81 );
            Unknown82 = parser.ReadColumn< int >( 82 );
            Unknown83 = parser.ReadColumn< int >( 83 );
            Unknown84 = parser.ReadColumn< int >( 84 );
            Unknown85 = parser.ReadColumn< int >( 85 );
            Unknown86 = parser.ReadColumn< int >( 86 );
            Unknown87 = parser.ReadColumn< int >( 87 );
            Icon = parser.ReadColumn< int >( 88 );
            Unknown89 = parser.ReadColumn< byte >( 89 );
            Unknown90 = parser.ReadColumn< byte >( 90 );
            Unknown91 = parser.ReadColumn< byte >( 91 );
        }
    }
}