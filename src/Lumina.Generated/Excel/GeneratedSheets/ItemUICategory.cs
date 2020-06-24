using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemUICategory", columnHash: 0xdc1f7844 )]
    public class ItemUICategory : IExcelRow
    {
        
        public string Name;
        public int Icon;
        public byte OrderMinor;
        public byte OrderMajor;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            OrderMinor = parser.ReadColumn< byte >( 2 );
            OrderMajor = parser.ReadColumn< byte >( 3 );
        }
    }
}