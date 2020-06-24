using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SubmarineMap", columnHash: 0x98fff20a )]
    public class SubmarineMap : IExcelRow
    {
        
        public string Name;
        public uint Image;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Image = parser.ReadColumn< uint >( 1 );
        }
    }
}