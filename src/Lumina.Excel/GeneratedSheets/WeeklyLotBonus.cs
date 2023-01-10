// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeeklyLotBonus", columnHash: 0x69ba3687 )]
    public partial class WeeklyLotBonus : ExcelRow
    {
        
        public byte[] WeeklyLotBonusThreshold { get; set; }
        public byte Unknown31 { get; set; }
        public ushort Unknown32 { get; set; }
        public ushort Unknown33 { get; set; }
        public ushort Unknown34 { get; set; }
        public ushort Unknown35 { get; set; }
        public ushort Unknown36 { get; set; }
        public ushort Unknown37 { get; set; }
        public ushort Unknown38 { get; set; }
        public ushort Unknown39 { get; set; }
        public ushort Unknown40 { get; set; }
        public ushort Unknown41 { get; set; }
        public ushort Unknown42 { get; set; }
        public ushort Unknown43 { get; set; }
        public ushort Unknown44 { get; set; }
        public ushort Unknown45 { get; set; }
        public ushort Unknown46 { get; set; }
        public ushort Unknown47 { get; set; }
        public ushort Unknown48 { get; set; }
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
        public byte Unknown64 { get; set; }
        public byte Unknown65 { get; set; }
        public byte Unknown66 { get; set; }
        public byte Unknown67 { get; set; }
        public byte Unknown68 { get; set; }
        public byte Unknown69 { get; set; }
        public byte Unknown70 { get; set; }
        public byte Unknown71 { get; set; }
        public byte Unknown72 { get; set; }
        public byte Unknown73 { get; set; }
        public byte Unknown74 { get; set; }
        public byte Unknown75 { get; set; }
        public byte Unknown76 { get; set; }
        public byte Unknown77 { get; set; }
        public byte Unknown78 { get; set; }
        public byte Unknown79 { get; set; }
        public byte Unknown80 { get; set; }
        public byte Unknown81 { get; set; }
        public byte Unknown82 { get; set; }
        public byte Unknown83 { get; set; }
        public byte Unknown84 { get; set; }
        public byte Unknown85 { get; set; }
        public byte Unknown86 { get; set; }
        public byte Unknown87 { get; set; }
        public byte Unknown88 { get; set; }
        public byte Unknown89 { get; set; }
        public byte Unknown90 { get; set; }
        public byte Unknown91 { get; set; }
        public byte Unknown92 { get; set; }
        public byte Unknown93 { get; set; }
        public byte Unknown94 { get; set; }
        public byte Unknown95 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

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