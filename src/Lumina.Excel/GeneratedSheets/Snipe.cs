// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Snipe", columnHash: 0x88d50061 )]
    public partial class Snipe : ExcelRow
    {
        
        public uint LGBTargetMarker { get; set; }
        public ushort Unknown1 { get; set; }
        public bool Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        public byte Unknown4 { get; set; }
        public byte Unknown5 { get; set; }
        public byte Unknown6 { get; set; }
        public byte Unknown7 { get; set; }
        public ushort Unknown8 { get; set; }
        public byte Unknown9 { get; set; }
        public byte Unknown10 { get; set; }
        public SeString VFXFire { get; set; }
        public SeString VFXHit { get; set; }
        public SeString VFXMiss { get; set; }
        public SeString VFXAdditional { get; set; }
        public ushort Unknown15 { get; set; }
        public bool Unknown16 { get; set; }
        public uint[] LGBEventNPC0 { get; set; }
        public ushort Unknown25 { get; set; }
        public ushort Unknown26 { get; set; }
        public ushort Unknown27 { get; set; }
        public ushort Unknown28 { get; set; }
        public ushort Unknown29 { get; set; }
        public ushort Unknown30 { get; set; }
        public ushort Unknown31 { get; set; }
        public ushort Unknown32 { get; set; }
        public ushort Unknown33 { get; set; }
        public ushort Unknown34 { get; set; }
        public ushort Unknown35 { get; set; }
        public ushort Unknown36 { get; set; }
        public ushort Unknown37 { get; set; }
        public ushort Unknown38 { get; set; }
        public ushort Unknown39 { get; set; }
        public ushort Unknown40 { get; set; }
        public byte Unknown41 { get; set; }
        public byte Unknown42 { get; set; }
        public byte Unknown43 { get; set; }
        public byte Unknown44 { get; set; }
        public byte Unknown45 { get; set; }
        public byte Unknown46 { get; set; }
        public byte Unknown47 { get; set; }
        public byte Unknown48 { get; set; }
        public ushort Unknown49 { get; set; }
        public ushort Unknown50 { get; set; }
        public ushort Unknown51 { get; set; }
        public ushort Unknown52 { get; set; }
        public ushort Unknown53 { get; set; }
        public ushort Unknown54 { get; set; }
        public ushort Unknown55 { get; set; }
        public ushort Unknown56 { get; set; }
        public ushort Unknown57 { get; set; }
        public ushort Unknown58 { get; set; }
        public ushort Unknown59 { get; set; }
        public ushort Unknown60 { get; set; }
        public ushort Unknown61 { get; set; }
        public ushort Unknown62 { get; set; }
        public ushort Unknown63 { get; set; }
        public ushort Unknown64 { get; set; }
        public byte Unknown65 { get; set; }
        public byte Unknown66 { get; set; }
        public byte Unknown67 { get; set; }
        public byte Unknown68 { get; set; }
        public byte Unknown69 { get; set; }
        public byte Unknown70 { get; set; }
        public byte Unknown71 { get; set; }
        public byte Unknown72 { get; set; }
        public uint[] LGBEventNPC1 { get; set; }
        public ushort Unknown81 { get; set; }
        public ushort Unknown82 { get; set; }
        public ushort Unknown83 { get; set; }
        public ushort Unknown84 { get; set; }
        public byte Unknown85 { get; set; }
        public byte Unknown86 { get; set; }
        public byte Unknown87 { get; set; }
        public byte Unknown88 { get; set; }
        public uint Unknown89 { get; set; }
        public uint Unknown90 { get; set; }
        public uint Unknown91 { get; set; }
        public uint Unknown92 { get; set; }
        public SeString Objective0 { get; set; }
        public SeString Hint0 { get; set; }
        public SeString Objective1 { get; set; }
        public SeString Hint1 { get; set; }
        public SeString Unknown97 { get; set; }
        public SeString Unknown98 { get; set; }
        public SeString Unknown99 { get; set; }
        public SeString Unknown100 { get; set; }
        public SeString Unknown101 { get; set; }
        public SeString Unknown102 { get; set; }
        public SeString Unknown103 { get; set; }
        public SeString ActionText { get; set; }
        public byte Unknown105 { get; set; }
        public byte Unknown106 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            LGBTargetMarker = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            Unknown8 = parser.ReadColumn< ushort >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
            Unknown10 = parser.ReadColumn< byte >( 10 );
            VFXFire = parser.ReadColumn< SeString >( 11 );
            VFXHit = parser.ReadColumn< SeString >( 12 );
            VFXMiss = parser.ReadColumn< SeString >( 13 );
            VFXAdditional = parser.ReadColumn< SeString >( 14 );
            Unknown15 = parser.ReadColumn< ushort >( 15 );
            Unknown16 = parser.ReadColumn< bool >( 16 );
            LGBEventNPC0 = new uint[ 8 ];
            for( var i = 0; i < 8; i++ )
                LGBEventNPC0[ i ] = parser.ReadColumn< uint >( 17 + i );
            Unknown25 = parser.ReadColumn< ushort >( 25 );
            Unknown26 = parser.ReadColumn< ushort >( 26 );
            Unknown27 = parser.ReadColumn< ushort >( 27 );
            Unknown28 = parser.ReadColumn< ushort >( 28 );
            Unknown29 = parser.ReadColumn< ushort >( 29 );
            Unknown30 = parser.ReadColumn< ushort >( 30 );
            Unknown31 = parser.ReadColumn< ushort >( 31 );
            Unknown32 = parser.ReadColumn< ushort >( 32 );
            Unknown33 = parser.ReadColumn< ushort >( 33 );
            Unknown34 = parser.ReadColumn< ushort >( 34 );
            Unknown35 = parser.ReadColumn< ushort >( 35 );
            Unknown36 = parser.ReadColumn< ushort >( 36 );
            Unknown37 = parser.ReadColumn< ushort >( 37 );
            Unknown38 = parser.ReadColumn< ushort >( 38 );
            Unknown39 = parser.ReadColumn< ushort >( 39 );
            Unknown40 = parser.ReadColumn< ushort >( 40 );
            Unknown41 = parser.ReadColumn< byte >( 41 );
            Unknown42 = parser.ReadColumn< byte >( 42 );
            Unknown43 = parser.ReadColumn< byte >( 43 );
            Unknown44 = parser.ReadColumn< byte >( 44 );
            Unknown45 = parser.ReadColumn< byte >( 45 );
            Unknown46 = parser.ReadColumn< byte >( 46 );
            Unknown47 = parser.ReadColumn< byte >( 47 );
            Unknown48 = parser.ReadColumn< byte >( 48 );
            Unknown49 = parser.ReadColumn< ushort >( 49 );
            Unknown50 = parser.ReadColumn< ushort >( 50 );
            Unknown51 = parser.ReadColumn< ushort >( 51 );
            Unknown52 = parser.ReadColumn< ushort >( 52 );
            Unknown53 = parser.ReadColumn< ushort >( 53 );
            Unknown54 = parser.ReadColumn< ushort >( 54 );
            Unknown55 = parser.ReadColumn< ushort >( 55 );
            Unknown56 = parser.ReadColumn< ushort >( 56 );
            Unknown57 = parser.ReadColumn< ushort >( 57 );
            Unknown58 = parser.ReadColumn< ushort >( 58 );
            Unknown59 = parser.ReadColumn< ushort >( 59 );
            Unknown60 = parser.ReadColumn< ushort >( 60 );
            Unknown61 = parser.ReadColumn< ushort >( 61 );
            Unknown62 = parser.ReadColumn< ushort >( 62 );
            Unknown63 = parser.ReadColumn< ushort >( 63 );
            Unknown64 = parser.ReadColumn< ushort >( 64 );
            Unknown65 = parser.ReadColumn< byte >( 65 );
            Unknown66 = parser.ReadColumn< byte >( 66 );
            Unknown67 = parser.ReadColumn< byte >( 67 );
            Unknown68 = parser.ReadColumn< byte >( 68 );
            Unknown69 = parser.ReadColumn< byte >( 69 );
            Unknown70 = parser.ReadColumn< byte >( 70 );
            Unknown71 = parser.ReadColumn< byte >( 71 );
            Unknown72 = parser.ReadColumn< byte >( 72 );
            LGBEventNPC1 = new uint[ 8 ];
            for( var i = 0; i < 8; i++ )
                LGBEventNPC1[ i ] = parser.ReadColumn< uint >( 73 + i );
            Unknown81 = parser.ReadColumn< ushort >( 81 );
            Unknown82 = parser.ReadColumn< ushort >( 82 );
            Unknown83 = parser.ReadColumn< ushort >( 83 );
            Unknown84 = parser.ReadColumn< ushort >( 84 );
            Unknown85 = parser.ReadColumn< byte >( 85 );
            Unknown86 = parser.ReadColumn< byte >( 86 );
            Unknown87 = parser.ReadColumn< byte >( 87 );
            Unknown88 = parser.ReadColumn< byte >( 88 );
            Unknown89 = parser.ReadColumn< uint >( 89 );
            Unknown90 = parser.ReadColumn< uint >( 90 );
            Unknown91 = parser.ReadColumn< uint >( 91 );
            Unknown92 = parser.ReadColumn< uint >( 92 );
            Objective0 = parser.ReadColumn< SeString >( 93 );
            Hint0 = parser.ReadColumn< SeString >( 94 );
            Objective1 = parser.ReadColumn< SeString >( 95 );
            Hint1 = parser.ReadColumn< SeString >( 96 );
            Unknown97 = parser.ReadColumn< SeString >( 97 );
            Unknown98 = parser.ReadColumn< SeString >( 98 );
            Unknown99 = parser.ReadColumn< SeString >( 99 );
            Unknown100 = parser.ReadColumn< SeString >( 100 );
            Unknown101 = parser.ReadColumn< SeString >( 101 );
            Unknown102 = parser.ReadColumn< SeString >( 102 );
            Unknown103 = parser.ReadColumn< SeString >( 103 );
            ActionText = parser.ReadColumn< SeString >( 104 );
            Unknown105 = parser.ReadColumn< byte >( 105 );
            Unknown106 = parser.ReadColumn< byte >( 106 );
        }
    }
}