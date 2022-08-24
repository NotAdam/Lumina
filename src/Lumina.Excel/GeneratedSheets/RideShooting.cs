// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RideShooting", columnHash: 0xdd593ecd )]
    public partial class RideShooting : ExcelRow
    {
        
        public LazyRow< GFateRideShooting > GFateRideShooting { get; set; }
        public short Unknown1 { get; set; }
        public short Unknown2 { get; set; }
        public ushort Unknown3 { get; set; }
        public ushort Unknown4 { get; set; }
        public LazyRow< RideShootingTextData > StartText { get; set; }
        public uint Unknown6 { get; set; }
        public uint Unknown7 { get; set; }
        public uint Unknown8 { get; set; }
        public uint Unknown9 { get; set; }
        public uint Unknown10 { get; set; }
        public uint Unknown11 { get; set; }
        public uint Unknown12 { get; set; }
        public uint Unknown13 { get; set; }
        public uint[] PopRange { get; set; }
        public LazyRow< ENpcBase >[] ENpc { get; set; }
        public byte[] ENpcScale { get; set; }
        public uint Unknown38 { get; set; }
        public uint Unknown39 { get; set; }
        public uint Unknown40 { get; set; }
        public uint Unknown41 { get; set; }
        public uint Unknown42 { get; set; }
        public uint Unknown43 { get; set; }
        public uint Unknown44 { get; set; }
        public uint Unknown45 { get; set; }
        public byte Unknown46 { get; set; }
        public byte Unknown47 { get; set; }
        public byte Unknown48 { get; set; }
        public byte Unknown49 { get; set; }
        public byte Unknown50 { get; set; }
        public byte Unknown51 { get; set; }
        public byte Unknown52 { get; set; }
        public byte Unknown53 { get; set; }
        public uint Unknown54 { get; set; }
        public uint Unknown55 { get; set; }
        public uint Unknown56 { get; set; }
        public uint Unknown57 { get; set; }
        public uint Unknown58 { get; set; }
        public uint Unknown59 { get; set; }
        public uint Unknown60 { get; set; }
        public uint Unknown61 { get; set; }
        public byte Unknown62 { get; set; }
        public byte Unknown63 { get; set; }
        public byte Unknown64 { get; set; }
        public byte Unknown65 { get; set; }
        public byte Unknown66 { get; set; }
        public byte Unknown67 { get; set; }
        public byte Unknown68 { get; set; }
        public byte Unknown69 { get; set; }
        public uint Unknown70 { get; set; }
        public uint Unknown71 { get; set; }
        public uint Unknown72 { get; set; }
        public uint Unknown73 { get; set; }
        public uint Unknown74 { get; set; }
        public uint Unknown75 { get; set; }
        public uint Unknown76 { get; set; }
        public uint Unknown77 { get; set; }
        public byte Unknown78 { get; set; }
        public byte Unknown79 { get; set; }
        public byte Unknown80 { get; set; }
        public byte Unknown81 { get; set; }
        public byte Unknown82 { get; set; }
        public byte Unknown83 { get; set; }
        public byte Unknown84 { get; set; }
        public byte Unknown85 { get; set; }
        public uint Unknown86 { get; set; }
        public uint Unknown87 { get; set; }
        public uint Unknown88 { get; set; }
        public uint Unknown89 { get; set; }
        public uint Unknown90 { get; set; }
        public uint Unknown91 { get; set; }
        public uint Unknown92 { get; set; }
        public uint Unknown93 { get; set; }
        public byte Unknown94 { get; set; }
        public byte Unknown95 { get; set; }
        public byte Unknown96 { get; set; }
        public byte Unknown97 { get; set; }
        public byte Unknown98 { get; set; }
        public byte Unknown99 { get; set; }
        public byte Unknown100 { get; set; }
        public byte Unknown101 { get; set; }
        public uint Unknown102 { get; set; }
        public uint Unknown103 { get; set; }
        public uint Unknown104 { get; set; }
        public uint Unknown105 { get; set; }
        public uint Unknown106 { get; set; }
        public uint Unknown107 { get; set; }
        public uint Unknown108 { get; set; }
        public uint Unknown109 { get; set; }
        public byte Unknown110 { get; set; }
        public byte Unknown111 { get; set; }
        public byte Unknown112 { get; set; }
        public byte Unknown113 { get; set; }
        public byte Unknown114 { get; set; }
        public byte Unknown115 { get; set; }
        public byte Unknown116 { get; set; }
        public byte Unknown117 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            GFateRideShooting = new LazyRow< GFateRideShooting >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            Unknown1 = parser.ReadColumn< short >( 1 );
            Unknown2 = parser.ReadColumn< short >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
            StartText = new LazyRow< RideShootingTextData >( gameData, parser.ReadColumn< ushort >( 5 ), language );
            Unknown6 = parser.ReadColumn< uint >( 6 );
            Unknown7 = parser.ReadColumn< uint >( 7 );
            Unknown8 = parser.ReadColumn< uint >( 8 );
            Unknown9 = parser.ReadColumn< uint >( 9 );
            Unknown10 = parser.ReadColumn< uint >( 10 );
            Unknown11 = parser.ReadColumn< uint >( 11 );
            Unknown12 = parser.ReadColumn< uint >( 12 );
            Unknown13 = parser.ReadColumn< uint >( 13 );
            PopRange = new uint[ 8 ];
            for( var i = 0; i < 8; i++ )
                PopRange[ i ] = parser.ReadColumn< uint >( 14 + i );
            ENpc = new LazyRow< ENpcBase >[ 8 ];
            for( var i = 0; i < 8; i++ )
                ENpc[ i ] = new LazyRow< ENpcBase >( gameData, parser.ReadColumn< uint >( 22 + i ), language );
            ENpcScale = new byte[ 8 ];
            for( var i = 0; i < 8; i++ )
                ENpcScale[ i ] = parser.ReadColumn< byte >( 30 + i );
            Unknown38 = parser.ReadColumn< uint >( 38 );
            Unknown39 = parser.ReadColumn< uint >( 39 );
            Unknown40 = parser.ReadColumn< uint >( 40 );
            Unknown41 = parser.ReadColumn< uint >( 41 );
            Unknown42 = parser.ReadColumn< uint >( 42 );
            Unknown43 = parser.ReadColumn< uint >( 43 );
            Unknown44 = parser.ReadColumn< uint >( 44 );
            Unknown45 = parser.ReadColumn< uint >( 45 );
            Unknown46 = parser.ReadColumn< byte >( 46 );
            Unknown47 = parser.ReadColumn< byte >( 47 );
            Unknown48 = parser.ReadColumn< byte >( 48 );
            Unknown49 = parser.ReadColumn< byte >( 49 );
            Unknown50 = parser.ReadColumn< byte >( 50 );
            Unknown51 = parser.ReadColumn< byte >( 51 );
            Unknown52 = parser.ReadColumn< byte >( 52 );
            Unknown53 = parser.ReadColumn< byte >( 53 );
            Unknown54 = parser.ReadColumn< uint >( 54 );
            Unknown55 = parser.ReadColumn< uint >( 55 );
            Unknown56 = parser.ReadColumn< uint >( 56 );
            Unknown57 = parser.ReadColumn< uint >( 57 );
            Unknown58 = parser.ReadColumn< uint >( 58 );
            Unknown59 = parser.ReadColumn< uint >( 59 );
            Unknown60 = parser.ReadColumn< uint >( 60 );
            Unknown61 = parser.ReadColumn< uint >( 61 );
            Unknown62 = parser.ReadColumn< byte >( 62 );
            Unknown63 = parser.ReadColumn< byte >( 63 );
            Unknown64 = parser.ReadColumn< byte >( 64 );
            Unknown65 = parser.ReadColumn< byte >( 65 );
            Unknown66 = parser.ReadColumn< byte >( 66 );
            Unknown67 = parser.ReadColumn< byte >( 67 );
            Unknown68 = parser.ReadColumn< byte >( 68 );
            Unknown69 = parser.ReadColumn< byte >( 69 );
            Unknown70 = parser.ReadColumn< uint >( 70 );
            Unknown71 = parser.ReadColumn< uint >( 71 );
            Unknown72 = parser.ReadColumn< uint >( 72 );
            Unknown73 = parser.ReadColumn< uint >( 73 );
            Unknown74 = parser.ReadColumn< uint >( 74 );
            Unknown75 = parser.ReadColumn< uint >( 75 );
            Unknown76 = parser.ReadColumn< uint >( 76 );
            Unknown77 = parser.ReadColumn< uint >( 77 );
            Unknown78 = parser.ReadColumn< byte >( 78 );
            Unknown79 = parser.ReadColumn< byte >( 79 );
            Unknown80 = parser.ReadColumn< byte >( 80 );
            Unknown81 = parser.ReadColumn< byte >( 81 );
            Unknown82 = parser.ReadColumn< byte >( 82 );
            Unknown83 = parser.ReadColumn< byte >( 83 );
            Unknown84 = parser.ReadColumn< byte >( 84 );
            Unknown85 = parser.ReadColumn< byte >( 85 );
            Unknown86 = parser.ReadColumn< uint >( 86 );
            Unknown87 = parser.ReadColumn< uint >( 87 );
            Unknown88 = parser.ReadColumn< uint >( 88 );
            Unknown89 = parser.ReadColumn< uint >( 89 );
            Unknown90 = parser.ReadColumn< uint >( 90 );
            Unknown91 = parser.ReadColumn< uint >( 91 );
            Unknown92 = parser.ReadColumn< uint >( 92 );
            Unknown93 = parser.ReadColumn< uint >( 93 );
            Unknown94 = parser.ReadColumn< byte >( 94 );
            Unknown95 = parser.ReadColumn< byte >( 95 );
            Unknown96 = parser.ReadColumn< byte >( 96 );
            Unknown97 = parser.ReadColumn< byte >( 97 );
            Unknown98 = parser.ReadColumn< byte >( 98 );
            Unknown99 = parser.ReadColumn< byte >( 99 );
            Unknown100 = parser.ReadColumn< byte >( 100 );
            Unknown101 = parser.ReadColumn< byte >( 101 );
            Unknown102 = parser.ReadColumn< uint >( 102 );
            Unknown103 = parser.ReadColumn< uint >( 103 );
            Unknown104 = parser.ReadColumn< uint >( 104 );
            Unknown105 = parser.ReadColumn< uint >( 105 );
            Unknown106 = parser.ReadColumn< uint >( 106 );
            Unknown107 = parser.ReadColumn< uint >( 107 );
            Unknown108 = parser.ReadColumn< uint >( 108 );
            Unknown109 = parser.ReadColumn< uint >( 109 );
            Unknown110 = parser.ReadColumn< byte >( 110 );
            Unknown111 = parser.ReadColumn< byte >( 111 );
            Unknown112 = parser.ReadColumn< byte >( 112 );
            Unknown113 = parser.ReadColumn< byte >( 113 );
            Unknown114 = parser.ReadColumn< byte >( 114 );
            Unknown115 = parser.ReadColumn< byte >( 115 );
            Unknown116 = parser.ReadColumn< byte >( 116 );
            Unknown117 = parser.ReadColumn< byte >( 117 );
        }
    }
}