using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringExp", columnHash: 0xda365c51 )]
    public class GatheringExp : IExcelRow
    {
        
        public int Exp;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Exp = parser.ReadColumn< int >( 0 );
        }
    }
}