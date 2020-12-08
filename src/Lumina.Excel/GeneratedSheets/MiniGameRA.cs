// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MiniGameRA", columnHash: 0xf22d339e )]
    public class MiniGameRA : IExcelRow
    {
        
        public int Unknown0;
        public int Icon;
        public int Image;
        public LazyRow< BGM > BGM;
        public int Unknown4;
        public bool Unknown5;
        public uint Unknown6;
        public bool Unknown7;
        public bool Unknown8;
        public bool Unknown9;
        public ushort Unknown10;
        public ushort Unknown11;
        public ushort Unknown12;
        public short Unknown13;
        public short Unknown14;
        public short Unknown15;
        public short Unknown16;
        public byte Unknown17;
        public byte Unknown18;
        public byte Unknown19;
        public byte Unknown20;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< int >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            Image = parser.ReadColumn< int >( 2 );
            BGM = new LazyRow< BGM >( lumina, parser.ReadColumn< int >( 3 ), language );
            Unknown4 = parser.ReadColumn< int >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
            Unknown6 = parser.ReadColumn< uint >( 6 );
            Unknown7 = parser.ReadColumn< bool >( 7 );
            Unknown8 = parser.ReadColumn< bool >( 8 );
            Unknown9 = parser.ReadColumn< bool >( 9 );
            Unknown10 = parser.ReadColumn< ushort >( 10 );
            Unknown11 = parser.ReadColumn< ushort >( 11 );
            Unknown12 = parser.ReadColumn< ushort >( 12 );
            Unknown13 = parser.ReadColumn< short >( 13 );
            Unknown14 = parser.ReadColumn< short >( 14 );
            Unknown15 = parser.ReadColumn< short >( 15 );
            Unknown16 = parser.ReadColumn< short >( 16 );
            Unknown17 = parser.ReadColumn< byte >( 17 );
            Unknown18 = parser.ReadColumn< byte >( 18 );
            Unknown19 = parser.ReadColumn< byte >( 19 );
            Unknown20 = parser.ReadColumn< byte >( 20 );
        }
    }
}