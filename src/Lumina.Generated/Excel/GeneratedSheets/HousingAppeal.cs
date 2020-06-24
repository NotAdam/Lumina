using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingAppeal", columnHash: 0xb89097b5 )]
    public class HousingAppeal : IExcelRow
    {
        
        public string Tag;
        public uint Icon;
        public byte Order;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Tag = parser.ReadColumn< string >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            Order = parser.ReadColumn< byte >( 2 );
        }
    }
}