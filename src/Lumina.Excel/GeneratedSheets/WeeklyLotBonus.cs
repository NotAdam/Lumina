// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeeklyLotBonus", columnHash: 0x69ba3687 )]
    public class WeeklyLotBonus : IExcelRow
    {
        
        public byte[] WeeklyLotBonusThreshold;
        public byte Unknown31;
        public ushort Unknown32;
        public ushort Unknown33;
        public ushort Unknown34;
        public ushort Unknown35;
        public ushort Unknown36;
        public ushort Unknown37;
        public ushort Unknown38;
        public ushort Unknown39;
        public ushort Unknown40;
        public ushort Unknown41;
        public ushort Unknown42;
        public ushort Unknown43;
        public ushort Unknown44;
        public ushort Unknown45;
        public ushort Unknown46;
        public ushort Unknown47;
        public ushort Unknown48;
        public ushort Unknown49;
        public ushort Unknown50;
        public ushort Unknown51;
        public ushort Unknown52;
        public ushort Unknown53;
        public ushort Unknown54;
        public ushort Unknown55;
        public ushort Unknown56;
        public ushort Unknown57;
        public ushort Unknown58;
        public ushort Unknown59;
        public ushort Unknown60;
        public ushort Unknown61;
        public ushort Unknown62;
        public ushort Unknown63;
        public byte Unknown64;
        public byte Unknown65;
        public byte Unknown66;
        public byte Unknown67;
        public byte Unknown68;
        public byte Unknown69;
        public byte Unknown70;
        public byte Unknown71;
        public byte Unknown72;
        public byte Unknown73;
        public byte Unknown74;
        public byte Unknown75;
        public byte Unknown76;
        public byte Unknown77;
        public byte Unknown78;
        public byte Unknown79;
        public byte Unknown80;
        public byte Unknown81;
        public byte Unknown82;
        public byte Unknown83;
        public byte Unknown84;
        public byte Unknown85;
        public byte Unknown86;
        public byte Unknown87;
        public byte Unknown88;
        public byte Unknown89;
        public byte Unknown90;
        public byte Unknown91;
        public byte Unknown92;
        public byte Unknown93;
        public byte Unknown94;
        public byte Unknown95;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            WeeklyLotBonusThreshold = new byte[ 31 ];
            for( var i = 0; i < 31; i++ )
                WeeklyLotBonusThreshold[ i ] = parser.ReadColumn< byte >( 0 + i );
            Unknown31 = parser.ReadColumn< byte >( 31 );
            Unknown32 = parser.ReadColumn< ushort >( 32 );
            Unknown33 = parser.ReadColumn< ushort >( 33 );
            Unknown34 = parser.ReadColumn< ushort >( 34 );
            Unknown35 = parser.ReadColumn< ushort >( 35 );
            Unknown36 = parser.ReadColumn< ushort >( 36 );
            Unknown37 = parser.ReadColumn< ushort >( 37 );
            Unknown38 = parser.ReadColumn< ushort >( 38 );
            Unknown39 = parser.ReadColumn< ushort >( 39 );
            Unknown40 = parser.ReadColumn< ushort >( 40 );
            Unknown41 = parser.ReadColumn< ushort >( 41 );
            Unknown42 = parser.ReadColumn< ushort >( 42 );
            Unknown43 = parser.ReadColumn< ushort >( 43 );
            Unknown44 = parser.ReadColumn< ushort >( 44 );
            Unknown45 = parser.ReadColumn< ushort >( 45 );
            Unknown46 = parser.ReadColumn< ushort >( 46 );
            Unknown47 = parser.ReadColumn< ushort >( 47 );
            Unknown48 = parser.ReadColumn< ushort >( 48 );
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
            Unknown64 = parser.ReadColumn< byte >( 64 );
            Unknown65 = parser.ReadColumn< byte >( 65 );
            Unknown66 = parser.ReadColumn< byte >( 66 );
            Unknown67 = parser.ReadColumn< byte >( 67 );
            Unknown68 = parser.ReadColumn< byte >( 68 );
            Unknown69 = parser.ReadColumn< byte >( 69 );
            Unknown70 = parser.ReadColumn< byte >( 70 );
            Unknown71 = parser.ReadColumn< byte >( 71 );
            Unknown72 = parser.ReadColumn< byte >( 72 );
            Unknown73 = parser.ReadColumn< byte >( 73 );
            Unknown74 = parser.ReadColumn< byte >( 74 );
            Unknown75 = parser.ReadColumn< byte >( 75 );
            Unknown76 = parser.ReadColumn< byte >( 76 );
            Unknown77 = parser.ReadColumn< byte >( 77 );
            Unknown78 = parser.ReadColumn< byte >( 78 );
            Unknown79 = parser.ReadColumn< byte >( 79 );
            Unknown80 = parser.ReadColumn< byte >( 80 );
            Unknown81 = parser.ReadColumn< byte >( 81 );
            Unknown82 = parser.ReadColumn< byte >( 82 );
            Unknown83 = parser.ReadColumn< byte >( 83 );
            Unknown84 = parser.ReadColumn< byte >( 84 );
            Unknown85 = parser.ReadColumn< byte >( 85 );
            Unknown86 = parser.ReadColumn< byte >( 86 );
            Unknown87 = parser.ReadColumn< byte >( 87 );
            Unknown88 = parser.ReadColumn< byte >( 88 );
            Unknown89 = parser.ReadColumn< byte >( 89 );
            Unknown90 = parser.ReadColumn< byte >( 90 );
            Unknown91 = parser.ReadColumn< byte >( 91 );
            Unknown92 = parser.ReadColumn< byte >( 92 );
            Unknown93 = parser.ReadColumn< byte >( 93 );
            Unknown94 = parser.ReadColumn< byte >( 94 );
            Unknown95 = parser.ReadColumn< byte >( 95 );
        }
    }
}