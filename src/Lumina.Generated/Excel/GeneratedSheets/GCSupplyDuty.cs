using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GCSupplyDuty", columnHash: 0x239ca1bf )]
    public class GCSupplyDuty : IExcelRow
    {
        
        public int[] Unknown0;
        public byte Unknown11;
        public int Unknown12;
        public byte Unknown13;
        public int Unknown14;
        public byte Unknown15;
        public int Unknown16;
        public byte Unknown17;
        public int Unknown18;
        public byte Unknown19;
        public int Unknown20;
        public byte Unknown21;
        public int Unknown22;
        public byte Unknown23;
        public int Unknown24;
        public byte Unknown25;
        public int Unknown26;
        public byte Unknown27;
        public int Unknown28;
        public byte Unknown29;
        public int Unknown30;
        public byte Unknown31;
        public int Unknown32;
        public byte Unknown33;
        public int Unknown34;
        public byte Unknown35;
        public int Unknown36;
        public byte Unknown37;
        public int Unknown38;
        public byte Unknown39;
        public int Unknown40;
        public byte Unknown41;
        public int Unknown42;
        public byte Unknown43;
        public int Unknown44;
        public byte Unknown45;
        public int Unknown46;
        public byte Unknown47;
        public int Unknown48;
        public byte Unknown49;
        public int Unknown50;
        public byte Unknown51;
        public int Unknown52;
        public byte Unknown53;
        public int Unknown54;
        public byte Unknown55;
        public int Unknown56;
        public byte Unknown57;
        public int Unknown58;
        public byte Unknown59;
        public int Unknown60;
        public byte Unknown61;
        public int Unknown62;
        public byte Unknown63;
        public int Unknown64;
        public byte Unknown65;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

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