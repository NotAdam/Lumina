// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionProcStatus", columnHash: 0xd870e208 )]
    public class ActionProcStatus : IExcelRow
    {
        
        public LazyRow< Status > Status;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Status = new LazyRow< Status >( lumina, parser.ReadColumn< ushort >( 0 ), language );
        }
    }
}