// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MiniGameRA", columnHash: 0x89c987f3 )]
    public class MiniGameRA : IExcelRow
    {
        
        public int Unknown0;
        public int Icon;
        public LazyRow< BGM > BGM;
        public int Unknown3;
        public uint Unknown4;
        public bool Unknown5;
        public bool Unknown6;
        public ushort Unknown7;
        public ushort Unknown8;
        public short Unknown9;
        public short Unknown10;
        public short Unknown11;
        public short Unknown12;
        public byte Unknown13;
        public byte Unknown14;
        public byte Unknown15;
        public byte Unknown16;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< int >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            BGM = new LazyRow< BGM >( lumina, parser.ReadColumn< int >( 2 ), language );
            Unknown3 = parser.ReadColumn< int >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
            Unknown6 = parser.ReadColumn< bool >( 6 );
            Unknown7 = parser.ReadColumn< ushort >( 7 );
            Unknown8 = parser.ReadColumn< ushort >( 8 );
            Unknown9 = parser.ReadColumn< short >( 9 );
            Unknown10 = parser.ReadColumn< short >( 10 );
            Unknown11 = parser.ReadColumn< short >( 11 );
            Unknown12 = parser.ReadColumn< short >( 12 );
            Unknown13 = parser.ReadColumn< byte >( 13 );
            Unknown14 = parser.ReadColumn< byte >( 14 );
            Unknown15 = parser.ReadColumn< byte >( 15 );
            Unknown16 = parser.ReadColumn< byte >( 16 );
        }
    }
}