// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GFATE", columnHash: 0x440a2c22 )]
    public partial class GFATE : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public uint Unknown2 { get; set; }
        public ushort Unknown3 { get; set; }
        public ushort Unknown4 { get; set; }
        public ushort Unknown5 { get; set; }
        public uint Unknown6 { get; set; }
        public LazyRow< Level >[] LGBPopRange { get; set; }
        public uint Unknown22 { get; set; }
        public uint[] Icon { get; set; }
        public uint Unknown38 { get; set; }
        public bool Unknown39 { get; set; }
        public bool Unknown40 { get; set; }
        public bool Unknown41 { get; set; }
        public bool Unknown42 { get; set; }
        public bool Unknown43 { get; set; }
        public bool Unknown44 { get; set; }
        public bool Unknown45 { get; set; }
        public bool Unknown46 { get; set; }
        public bool Unknown47 { get; set; }
        public bool Unknown48 { get; set; }
        public bool Unknown49 { get; set; }
        public bool Unknown50 { get; set; }
        public bool Unknown51 { get; set; }
        public bool Unknown52 { get; set; }
        public bool Unknown53 { get; set; }
        public bool Unknown54 { get; set; }
        public bool Unknown55 { get; set; }
        public bool Unknown56 { get; set; }
        public bool Unknown57 { get; set; }
        public bool Unknown58 { get; set; }
        public bool Unknown59 { get; set; }
        public bool Unknown60 { get; set; }
        public bool Unknown61 { get; set; }
        public bool Unknown62 { get; set; }
        public bool Unknown63 { get; set; }
        public bool Unknown64 { get; set; }
        public bool Unknown65 { get; set; }
        public bool Unknown66 { get; set; }
        public bool Unknown67 { get; set; }
        public bool Unknown68 { get; set; }
        public bool Unknown69 { get; set; }
        public bool Unknown70 { get; set; }
        public bool Unknown71 { get; set; }
        public bool Unknown72 { get; set; }
        public bool Unknown73 { get; set; }
        public bool Unknown74 { get; set; }
        public bool Unknown75 { get; set; }
        public bool Unknown76 { get; set; }
        public bool Unknown77 { get; set; }
        public bool Unknown78 { get; set; }
        public bool Unknown79 { get; set; }
        public bool Unknown80 { get; set; }
        public bool Unknown81 { get; set; }
        public bool Unknown82 { get; set; }
        public bool Unknown83 { get; set; }
        public bool Unknown84 { get; set; }
        public bool Unknown85 { get; set; }
        public bool Unknown86 { get; set; }
        
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
            LGBPopRange = new LazyRow< Level >[ 15 ];
            for( var i = 0; i < 15; i++ )
                LGBPopRange[ i ] = new LazyRow< Level >( gameData, parser.ReadColumn< uint >( 7 + i ), language );
            Unknown22 = parser.ReadColumn< uint >( 22 );
            Icon = new uint[ 15 ];
            for( var i = 0; i < 15; i++ )
                Icon[ i ] = parser.ReadColumn< uint >( 23 + i );
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