// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MateriaTomestoneRate", columnHash: 0xdbf43666 )]
    public class MateriaTomestoneRate : IExcelRow
    {
        
        public uint Rate;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Rate = parser.ReadColumn< uint >( 0 );
        }
    }
}