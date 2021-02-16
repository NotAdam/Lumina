// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GFATE", columnHash: 0x440a2c22 )]
    public class GFATE : ExcelRow
    {
        
        public byte Unknown0;
        public byte Unknown1;
        public uint Unknown2;
        public ushort Unknown3;
        public ushort Unknown4;
        public ushort Unknown5;
        public uint Unknown6;
        public uint Unknown7;
        public uint Unknown8;
        public uint Unknown9;
        public uint Unknown10;
        public uint Unknown11;
        public uint Unknown12;
        public uint Unknown13;
        public uint Unknown14;
        public uint Unknown15;
        public uint Unknown16;
        public uint Unknown17;
        public uint Unknown18;
        public uint Unknown19;
        public uint Unknown20;
        public uint Unknown21;
        public uint[] Icon;
        public uint Unknown38;
        public bool Unknown39;
        public bool Unknown40;
        public bool Unknown41;
        public bool Unknown42;
        public bool Unknown43;
        public bool Unknown44;
        public bool Unknown45;
        public bool Unknown46;
        public bool Unknown47;
        public bool Unknown48;
        public bool Unknown49;
        public bool Unknown50;
        public bool Unknown51;
        public bool Unknown52;
        public bool Unknown53;
        public bool Unknown54;
        public bool Unknown55;
        public bool Unknown56;
        public bool Unknown57;
        public bool Unknown58;
        public bool Unknown59;
        public bool Unknown60;
        public bool Unknown61;
        public bool Unknown62;
        public bool Unknown63;
        public bool Unknown64;
        public bool Unknown65;
        public bool Unknown66;
        public bool Unknown67;
        public bool Unknown68;
        public bool Unknown69;
        public bool Unknown70;
        public bool Unknown71;
        public bool Unknown72;
        public bool Unknown73;
        public bool Unknown74;
        public bool Unknown75;
        public bool Unknown76;
        public bool Unknown77;
        public bool Unknown78;
        public bool Unknown79;
        public bool Unknown80;
        public bool Unknown81;
        public bool Unknown82;
        public bool Unknown83;
        public bool Unknown84;
        public bool Unknown85;
        public bool Unknown86;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< uint >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
            Unknown6 = parser.ReadColumn< uint >( 6 );
            Unknown7 = parser.ReadColumn< uint >( 7 );
            Unknown8 = parser.ReadColumn< uint >( 8 );
            Unknown9 = parser.ReadColumn< uint >( 9 );
            Unknown10 = parser.ReadColumn< uint >( 10 );
            Unknown11 = parser.ReadColumn< uint >( 11 );
            Unknown12 = parser.ReadColumn< uint >( 12 );
            Unknown13 = parser.ReadColumn< uint >( 13 );
            Unknown14 = parser.ReadColumn< uint >( 14 );
            Unknown15 = parser.ReadColumn< uint >( 15 );
            Unknown16 = parser.ReadColumn< uint >( 16 );
            Unknown17 = parser.ReadColumn< uint >( 17 );
            Unknown18 = parser.ReadColumn< uint >( 18 );
            Unknown19 = parser.ReadColumn< uint >( 19 );
            Unknown20 = parser.ReadColumn< uint >( 20 );
            Unknown21 = parser.ReadColumn< uint >( 21 );
            Icon = new uint[ 16 ];
            for( var i = 0; i < 16; i++ )
                Icon[ i ] = parser.ReadColumn< uint >( 22 + i );
            Unknown38 = parser.ReadColumn< uint >( 38 );
            Unknown39 = parser.ReadColumn< bool >( 39 );
            Unknown40 = parser.ReadColumn< bool >( 40 );
            Unknown41 = parser.ReadColumn< bool >( 41 );
            Unknown42 = parser.ReadColumn< bool >( 42 );
            Unknown43 = parser.ReadColumn< bool >( 43 );
            Unknown44 = parser.ReadColumn< bool >( 44 );
            Unknown45 = parser.ReadColumn< bool >( 45 );
            Unknown46 = parser.ReadColumn< bool >( 46 );
            Unknown47 = parser.ReadColumn< bool >( 47 );
            Unknown48 = parser.ReadColumn< bool >( 48 );
            Unknown49 = parser.ReadColumn< bool >( 49 );
            Unknown50 = parser.ReadColumn< bool >( 50 );
            Unknown51 = parser.ReadColumn< bool >( 51 );
            Unknown52 = parser.ReadColumn< bool >( 52 );
            Unknown53 = parser.ReadColumn< bool >( 53 );
            Unknown54 = parser.ReadColumn< bool >( 54 );
            Unknown55 = parser.ReadColumn< bool >( 55 );
            Unknown56 = parser.ReadColumn< bool >( 56 );
            Unknown57 = parser.ReadColumn< bool >( 57 );
            Unknown58 = parser.ReadColumn< bool >( 58 );
            Unknown59 = parser.ReadColumn< bool >( 59 );
            Unknown60 = parser.ReadColumn< bool >( 60 );
            Unknown61 = parser.ReadColumn< bool >( 61 );
            Unknown62 = parser.ReadColumn< bool >( 62 );
            Unknown63 = parser.ReadColumn< bool >( 63 );
            Unknown64 = parser.ReadColumn< bool >( 64 );
            Unknown65 = parser.ReadColumn< bool >( 65 );
            Unknown66 = parser.ReadColumn< bool >( 66 );
            Unknown67 = parser.ReadColumn< bool >( 67 );
            Unknown68 = parser.ReadColumn< bool >( 68 );
            Unknown69 = parser.ReadColumn< bool >( 69 );
            Unknown70 = parser.ReadColumn< bool >( 70 );
            Unknown71 = parser.ReadColumn< bool >( 71 );
            Unknown72 = parser.ReadColumn< bool >( 72 );
            Unknown73 = parser.ReadColumn< bool >( 73 );
            Unknown74 = parser.ReadColumn< bool >( 74 );
            Unknown75 = parser.ReadColumn< bool >( 75 );
            Unknown76 = parser.ReadColumn< bool >( 76 );
            Unknown77 = parser.ReadColumn< bool >( 77 );
            Unknown78 = parser.ReadColumn< bool >( 78 );
            Unknown79 = parser.ReadColumn< bool >( 79 );
            Unknown80 = parser.ReadColumn< bool >( 80 );
            Unknown81 = parser.ReadColumn< bool >( 81 );
            Unknown82 = parser.ReadColumn< bool >( 82 );
            Unknown83 = parser.ReadColumn< bool >( 83 );
            Unknown84 = parser.ReadColumn< bool >( 84 );
            Unknown85 = parser.ReadColumn< bool >( 85 );
            Unknown86 = parser.ReadColumn< bool >( 86 );
        }
    }
}