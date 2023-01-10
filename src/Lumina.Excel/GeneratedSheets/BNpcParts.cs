// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BNpcParts", columnHash: 0x4cf06d08 )]
    public partial class BNpcParts : ExcelRow
    {
        
        public LazyRow< BNpcBase > BNpcBase1 { get; set; }
        public byte PartSlot1 { get; set; }
        public bool Unknown2 { get; set; }
        public bool Unknown3 { get; set; }
        public bool Unknown4 { get; set; }
        public bool Unknown5 { get; set; }
        public float X1 { get; set; }
        public float Y1 { get; set; }
        public float Z1 { get; set; }
        public short Unknown9 { get; set; }
        public float Scale1 { get; set; }
        public LazyRow< BNpcBase > BNpcBase2 { get; set; }
        public byte PartSlot2 { get; set; }
        public bool Unknown13 { get; set; }
        public bool Unknown14 { get; set; }
        public bool Unknown15 { get; set; }
        public bool Unknown16 { get; set; }
        public float X2 { get; set; }
        public float Y2 { get; set; }
        public float Z2 { get; set; }
        public short Unknown20 { get; set; }
        public float Scale2 { get; set; }
        public LazyRow< BNpcBase > BNpcBase3 { get; set; }
        public byte PartSlot3 { get; set; }
        public bool Unknown24 { get; set; }
        public bool Unknown25 { get; set; }
        public bool Unknown26 { get; set; }
        public bool Unknown27 { get; set; }
        public float X3 { get; set; }
        public float Y3 { get; set; }
        public float Z3 { get; set; }
        public short Scale3 { get; set; }
        public float Unknown32 { get; set; }
        public LazyRow< BNpcBase > BNpcBase4 { get; set; }
        public byte PartSlot4 { get; set; }
        public bool Unknown35 { get; set; }
        public bool Unknown36 { get; set; }
        public bool Unknown37 { get; set; }
        public bool Unknown38 { get; set; }
        public float X4 { get; set; }
        public float Y4 { get; set; }
        public float Z4 { get; set; }
        public short Unknown42 { get; set; }
        public float Scale4 { get; set; }
        public LazyRow< BNpcBase > BNpcBase5 { get; set; }
        public byte PartSlot5 { get; set; }
        public bool Unknown46 { get; set; }
        public bool Unknown47 { get; set; }
        public bool Unknown48 { get; set; }
        public bool Unknown49 { get; set; }
        public float X5 { get; set; }
        public float Y5 { get; set; }
        public float Z5 { get; set; }
        public short Unknown53 { get; set; }
        public float Scale5 { get; set; }
        public ushort Unknown55 { get; set; }
        public byte Unknown56 { get; set; }
        public bool Unknown57 { get; set; }
        public bool Unknown58 { get; set; }
        public bool Unknown59 { get; set; }
        public bool Unknown60 { get; set; }
        public float Unknown61 { get; set; }
        public float Unknown62 { get; set; }
        public float Unknown63 { get; set; }
        public short Unknown64 { get; set; }
        public float Unknown65 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            BNpcBase1 = new LazyRow< BNpcBase >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            PartSlot1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
            X1 = parser.ReadColumn< float >( 6 );
            Y1 = parser.ReadColumn< float >( 7 );
            Z1 = parser.ReadColumn< float >( 8 );
            Unknown9 = parser.ReadColumn< short >( 9 );
            Scale1 = parser.ReadColumn< float >( 10 );
            BNpcBase2 = new LazyRow< BNpcBase >( gameData, parser.ReadColumn< ushort >( 11 ), language );
            PartSlot2 = parser.ReadColumn< byte >( 12 );
            Unknown13 = parser.ReadColumn< bool >( 13 );
            Unknown14 = parser.ReadColumn< bool >( 14 );
            Unknown15 = parser.ReadColumn< bool >( 15 );
            Unknown16 = parser.ReadColumn< bool >( 16 );
            X2 = parser.ReadColumn< float >( 17 );
            Y2 = parser.ReadColumn< float >( 18 );
            Z2 = parser.ReadColumn< float >( 19 );
            Unknown20 = parser.ReadColumn< short >( 20 );
            Scale2 = parser.ReadColumn< float >( 21 );
            BNpcBase3 = new LazyRow< BNpcBase >( gameData, parser.ReadColumn< ushort >( 22 ), language );
            PartSlot3 = parser.ReadColumn< byte >( 23 );
            Unknown24 = parser.ReadColumn< bool >( 24 );
            Unknown25 = parser.ReadColumn< bool >( 25 );
            Unknown26 = parser.ReadColumn< bool >( 26 );
            Unknown27 = parser.ReadColumn< bool >( 27 );
            X3 = parser.ReadColumn< float >( 28 );
            Y3 = parser.ReadColumn< float >( 29 );
            Z3 = parser.ReadColumn< float >( 30 );
            Scale3 = parser.ReadColumn< short >( 31 );
            Unknown32 = parser.ReadColumn< float >( 32 );
            BNpcBase4 = new LazyRow< BNpcBase >( gameData, parser.ReadColumn< ushort >( 33 ), language );
            PartSlot4 = parser.ReadColumn< byte >( 34 );
            Unknown35 = parser.ReadColumn< bool >( 35 );
            Unknown36 = parser.ReadColumn< bool >( 36 );
            Unknown37 = parser.ReadColumn< bool >( 37 );
            Unknown38 = parser.ReadColumn< bool >( 38 );
            X4 = parser.ReadColumn< float >( 39 );
            Y4 = parser.ReadColumn< float >( 40 );
            Z4 = parser.ReadColumn< float >( 41 );
            Unknown42 = parser.ReadColumn< short >( 42 );
            Scale4 = parser.ReadColumn< float >( 43 );
            BNpcBase5 = new LazyRow< BNpcBase >( gameData, parser.ReadColumn< ushort >( 44 ), language );
            PartSlot5 = parser.ReadColumn< byte >( 45 );
            Unknown46 = parser.ReadColumn< bool >( 46 );
            Unknown47 = parser.ReadColumn< bool >( 47 );
            Unknown48 = parser.ReadColumn< bool >( 48 );
            Unknown49 = parser.ReadColumn< bool >( 49 );
            X5 = parser.ReadColumn< float >( 50 );
            Y5 = parser.ReadColumn< float >( 51 );
            Z5 = parser.ReadColumn< float >( 52 );
            Unknown53 = parser.ReadColumn< short >( 53 );
            Scale5 = parser.ReadColumn< float >( 54 );
            Unknown55 = parser.ReadColumn< ushort >( 55 );
            Unknown56 = parser.ReadColumn< byte >( 56 );
            Unknown57 = parser.ReadColumn< bool >( 57 );
            Unknown58 = parser.ReadColumn< bool >( 58 );
            Unknown59 = parser.ReadColumn< bool >( 59 );
            Unknown60 = parser.ReadColumn< bool >( 60 );
            Unknown61 = parser.ReadColumn< float >( 61 );
            Unknown62 = parser.ReadColumn< float >( 62 );
            Unknown63 = parser.ReadColumn< float >( 63 );
            Unknown64 = parser.ReadColumn< short >( 64 );
            Unknown65 = parser.ReadColumn< float >( 65 );
        }
    }
}