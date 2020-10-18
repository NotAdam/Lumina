// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GrandCompany", columnHash: 0x472d6d8c )]
    public class GrandCompany : IExcelRow
    {
        
        public SeString Name;
        public sbyte Unknown1;
        public SeString Unknown2;
        public sbyte Unknown3;
        public sbyte Unknown4;
        public sbyte Unknown5;
        public sbyte Unknown6;
        public sbyte Unknown7;
        public SeString Unknown8;
        public sbyte Unknown9;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< sbyte >( 1 );
            Unknown2 = parser.ReadColumn< SeString >( 2 );
            Unknown3 = parser.ReadColumn< sbyte >( 3 );
            Unknown4 = parser.ReadColumn< sbyte >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
            Unknown6 = parser.ReadColumn< sbyte >( 6 );
            Unknown7 = parser.ReadColumn< sbyte >( 7 );
            Unknown8 = parser.ReadColumn< SeString >( 8 );
            Unknown9 = parser.ReadColumn< sbyte >( 9 );
        }
    }
}