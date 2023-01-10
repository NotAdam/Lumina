// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GCSupplyDuty", columnHash: 0xb3265a92 )]
    public partial class GCSupplyDuty : ExcelRow
    {
        
        public int[] Unknown0 { get; set; }
        public byte Unknown11 { get; set; }
        public int Unknown12 { get; set; }
        public byte Unknown13 { get; set; }
        public int Unknown14 { get; set; }
        public byte Unknown15 { get; set; }
        public int Unknown16 { get; set; }
        public byte Unknown17 { get; set; }
        public int Unknown18 { get; set; }
        public byte Unknown19 { get; set; }
        public int Unknown20 { get; set; }
        public byte Unknown21 { get; set; }
        public int Unknown22 { get; set; }
        public byte Unknown23 { get; set; }
        public int Unknown24 { get; set; }
        public byte Unknown25 { get; set; }
        public int Unknown26 { get; set; }
        public byte Unknown27 { get; set; }
        public int Unknown28 { get; set; }
        public byte Unknown29 { get; set; }
        public int Unknown30 { get; set; }
        public byte Unknown31 { get; set; }
        public int Unknown32 { get; set; }
        public byte Unknown33 { get; set; }
        public int Unknown34 { get; set; }
        public byte Unknown35 { get; set; }
        public int Unknown36 { get; set; }
        public byte Unknown37 { get; set; }
        public int Unknown38 { get; set; }
        public byte Unknown39 { get; set; }
        public int Unknown40 { get; set; }
        public byte Unknown41 { get; set; }
        public int Unknown42 { get; set; }
        public byte Unknown43 { get; set; }
        public int Unknown44 { get; set; }
        public byte Unknown45 { get; set; }
        public int Unknown46 { get; set; }
        public byte Unknown47 { get; set; }
        public int Unknown48 { get; set; }
        public byte Unknown49 { get; set; }
        public int Unknown50 { get; set; }
        public byte Unknown51 { get; set; }
        public int Unknown52 { get; set; }
        public byte Unknown53 { get; set; }
        public int Unknown54 { get; set; }
        public byte Unknown55 { get; set; }
        public int Unknown56 { get; set; }
        public byte Unknown57 { get; set; }
        public int Unknown58 { get; set; }
        public byte Unknown59 { get; set; }
        public int Unknown60 { get; set; }
        public byte Unknown61 { get; set; }
        public int Unknown62 { get; set; }
        public byte Unknown63 { get; set; }
        public int Unknown64 { get; set; }
        public byte Unknown65 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = new int[ 11 ];
            for( var i = 0; i < 11; i++ )
                Unknown0[ i ] = parser.ReadColumn< int >( 0 + i );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< int >( 12 );
            Unknown13 = parser.ReadColumn< byte >( 13 );
            Unknown14 = parser.ReadColumn< int >( 14 );
            Unknown15 = parser.ReadColumn< byte >( 15 );
            Unknown16 = parser.ReadColumn< int >( 16 );
            Unknown17 = parser.ReadColumn< byte >( 17 );
            Unknown18 = parser.ReadColumn< int >( 18 );
            Unknown19 = parser.ReadColumn< byte >( 19 );
            Unknown20 = parser.ReadColumn< int >( 20 );
            Unknown21 = parser.ReadColumn< byte >( 21 );
            Unknown22 = parser.ReadColumn< int >( 22 );
            Unknown23 = parser.ReadColumn< byte >( 23 );
            Unknown24 = parser.ReadColumn< int >( 24 );
            Unknown25 = parser.ReadColumn< byte >( 25 );
            Unknown26 = parser.ReadColumn< int >( 26 );
            Unknown27 = parser.ReadColumn< byte >( 27 );
            Unknown28 = parser.ReadColumn< int >( 28 );
            Unknown29 = parser.ReadColumn< byte >( 29 );
            Unknown30 = parser.ReadColumn< int >( 30 );
            Unknown31 = parser.ReadColumn< byte >( 31 );
            Unknown32 = parser.ReadColumn< int >( 32 );
            Unknown33 = parser.ReadColumn< byte >( 33 );
            Unknown34 = parser.ReadColumn< int >( 34 );
            Unknown35 = parser.ReadColumn< byte >( 35 );
            Unknown36 = parser.ReadColumn< int >( 36 );
            Unknown37 = parser.ReadColumn< byte >( 37 );
            Unknown38 = parser.ReadColumn< int >( 38 );
            Unknown39 = parser.ReadColumn< byte >( 39 );
            Unknown40 = parser.ReadColumn< int >( 40 );
            Unknown41 = parser.ReadColumn< byte >( 41 );
            Unknown42 = parser.ReadColumn< int >( 42 );
            Unknown43 = parser.ReadColumn< byte >( 43 );
            Unknown44 = parser.ReadColumn< int >( 44 );
            Unknown45 = parser.ReadColumn< byte >( 45 );
            Unknown46 = parser.ReadColumn< int >( 46 );
            Unknown47 = parser.ReadColumn< byte >( 47 );
            Unknown48 = parser.ReadColumn< int >( 48 );
            Unknown49 = parser.ReadColumn< byte >( 49 );
            Unknown50 = parser.ReadColumn< int >( 50 );
            Unknown51 = parser.ReadColumn< byte >( 51 );
            Unknown52 = parser.ReadColumn< int >( 52 );
            Unknown53 = parser.ReadColumn< byte >( 53 );
            Unknown54 = parser.ReadColumn< int >( 54 );
            Unknown55 = parser.ReadColumn< byte >( 55 );
            Unknown56 = parser.ReadColumn< int >( 56 );
            Unknown57 = parser.ReadColumn< byte >( 57 );
            Unknown58 = parser.ReadColumn< int >( 58 );
            Unknown59 = parser.ReadColumn< byte >( 59 );
            Unknown60 = parser.ReadColumn< int >( 60 );
            Unknown61 = parser.ReadColumn< byte >( 61 );
            Unknown62 = parser.ReadColumn< int >( 62 );
            Unknown63 = parser.ReadColumn< byte >( 63 );
            Unknown64 = parser.ReadColumn< int >( 64 );
            Unknown65 = parser.ReadColumn< byte >( 65 );
        }
    }
}