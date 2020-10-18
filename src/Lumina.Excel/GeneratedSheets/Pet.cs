// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Pet", columnHash: 0x9c5824d1 )]
    public class Pet : IExcelRow
    {
        
        public SeString Name;
        public ushort Unknown1;
        public ushort Unknown2;
        public ushort Unknown3;
        public ushort Unknown4;
        public ushort Unknown5;
        public bool Unknown6;
        public bool Unknown7;
        public bool Unknown8;
        public sbyte Unknown9;
        public byte Unknown10;
        public byte Unknown11;
        public byte Unknown12;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
            Unknown6 = parser.ReadColumn< bool >( 6 );
            Unknown7 = parser.ReadColumn< bool >( 7 );
            Unknown8 = parser.ReadColumn< bool >( 8 );
            Unknown9 = parser.ReadColumn< sbyte >( 9 );
            Unknown10 = parser.ReadColumn< byte >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
        }
    }
}