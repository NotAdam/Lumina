// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RideShooting", columnHash: 0xad332857 )]
    public class RideShooting : IExcelRow
    {
        
        public LazyRow< GFateRideShooting > GFateRideShooting;
        public short Unknown1;
        public short Unknown2;
        public ushort Unknown3;
        public ushort Unknown4;
        public LazyRow< RideShootingTextData > StartText;
        public uint Unknown6;
        public uint Unknown7;
        public uint Unknown8;
        public uint Unknown9;
        public uint Unknown10;
        public uint Unknown11;
        public uint Unknown12;
        public uint Unknown13;
        public uint[] PopRange;
        public LazyRow< ENpcBase >[] ENpc;
        public byte[] ENpcScale;
        public uint Unknown38;
        public uint Unknown39;
        public uint Unknown40;
        public uint Unknown41;
        public uint Unknown42;
        public uint Unknown43;
        public uint Unknown44;
        public uint Unknown45;
        public byte Unknown46;
        public byte Unknown47;
        public byte Unknown48;
        public byte Unknown49;
        public byte Unknown50;
        public byte Unknown51;
        public byte Unknown52;
        public byte Unknown53;
        public uint Unknown54;
        public uint Unknown55;
        public uint Unknown56;
        public uint Unknown57;
        public uint Unknown58;
        public uint Unknown59;
        public uint Unknown60;
        public uint Unknown61;
        public byte Unknown62;
        public byte Unknown63;
        public byte Unknown64;
        public byte Unknown65;
        public byte Unknown66;
        public byte Unknown67;
        public byte Unknown68;
        public byte Unknown69;
        public uint Unknown70;
        public uint Unknown71;
        public uint Unknown72;
        public uint Unknown73;
        public uint Unknown74;
        public uint Unknown75;
        public uint Unknown76;
        public uint Unknown77;
        public byte Unknown78;
        public byte Unknown79;
        public byte Unknown80;
        public byte Unknown81;
        public byte Unknown82;
        public byte Unknown83;
        public byte Unknown84;
        public byte Unknown85;
        public uint Unknown86;
        public uint Unknown87;
        public uint Unknown88;
        public uint Unknown89;
        public uint Unknown90;
        public uint Unknown91;
        public uint Unknown92;
        public uint Unknown93;
        public byte Unknown94;
        public byte Unknown95;
        public byte Unknown96;
        public byte Unknown97;
        public byte Unknown98;
        public byte Unknown99;
        public byte Unknown100;
        public byte Unknown101;
        public uint Unknown102;
        public uint Unknown103;
        public uint Unknown104;
        public uint Unknown105;
        public uint Unknown106;
        public uint Unknown107;
        public uint Unknown108;
        public uint Unknown109;
        public byte Unknown110;
        public byte Unknown111;
        public byte Unknown112;
        public byte Unknown113;
        public byte Unknown114;
        public byte Unknown115;
        public byte Unknown116;
        public byte Unknown117;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            GFateRideShooting = new LazyRow< GFateRideShooting >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            Unknown1 = parser.ReadColumn< short >( 1 );
            Unknown2 = parser.ReadColumn< short >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
            StartText = new LazyRow< RideShootingTextData >( lumina, parser.ReadColumn< ushort >( 5 ), language );
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
                ENpc[ i ] = new LazyRow< ENpcBase >( lumina, parser.ReadColumn< uint >( 22 + i ), language );
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