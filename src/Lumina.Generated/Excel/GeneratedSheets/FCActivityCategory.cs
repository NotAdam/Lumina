using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FCActivityCategory", columnHash: 0x5eb59ccb )]
    public class FCActivityCategory : IExcelRow
    {
        
        public byte Priority;
        public string Name;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Priority = parser.ReadColumn< byte >( 0 );
            Name = parser.ReadColumn< string >( 1 );
        }
    }
}