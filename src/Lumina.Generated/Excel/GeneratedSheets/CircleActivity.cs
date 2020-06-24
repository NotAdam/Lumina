using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CircleActivity", columnHash: 0x1a6ae0b3 )]
    public class CircleActivity : IExcelRow
    {
        
        public string Name;
        public int Icon;
        public ushort Order;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            Order = parser.ReadColumn< ushort >( 2 );
        }
    }
}