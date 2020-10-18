// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BNpcParts", columnHash: 0x61961a7d )]
    public class BNpcParts : IExcelRow
    {
        
        public LazyRow< BNpcBase > BNpcBase1;
        public byte PartSlot1;
        public bool Unknown2;
        public bool Unknown3;
        public bool Unknown4;
        public bool Unknown5;
        public float X1;
        public float Y1;
        public float Z1;
        public short Unknown9;
        public float Scale1;
        public LazyRow< BNpcBase > BNpcBase2;
        public byte PartSlot2;
        public bool Unknown13;
        public bool Unknown14;
        public bool Unknown15;
        public bool Unknown16;
        public float X2;
        public float Y2;
        public float Z2;
        public short Unknown20;
        public float Scale2;
        public LazyRow< BNpcBase > BNpcBase3;
        public byte PartSlot3;
        public bool Unknown24;
        public bool Unknown25;
        public bool Unknown26;
        public bool Unknown27;
        public float X3;
        public float Y3;
        public float Z3;
        public short Scale3;
        public float Unknown32;
        public LazyRow< BNpcBase > BNpcBase4;
        public byte PartSlot4;
        public bool Unknown35;
        public bool Unknown36;
        public bool Unknown37;
        public bool Unknown38;
        public float X4;
        public float Y4;
        public float Z4;
        public short Unknown42;
        public float Scale4;
        public LazyRow< BNpcBase > BNpcBase5;
        public byte PartSlot5;
        public bool Unknown46;
        public bool Unknown47;
        public bool Unknown48;
        public bool Unknown49;
        public float X5;
        public float Y5;
        public float Z5;
        public short Unknown53;
        public float Scale5;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            BNpcBase1 = new LazyRow< BNpcBase >( lumina, parser.ReadColumn< ushort >( 0 ), language );
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
            BNpcBase2 = new LazyRow< BNpcBase >( lumina, parser.ReadColumn< ushort >( 11 ), language );
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
            BNpcBase3 = new LazyRow< BNpcBase >( lumina, parser.ReadColumn< ushort >( 22 ), language );
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
            BNpcBase4 = new LazyRow< BNpcBase >( lumina, parser.ReadColumn< ushort >( 33 ), language );
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
            BNpcBase5 = new LazyRow< BNpcBase >( lumina, parser.ReadColumn< ushort >( 44 ), language );
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
        }
    }
}