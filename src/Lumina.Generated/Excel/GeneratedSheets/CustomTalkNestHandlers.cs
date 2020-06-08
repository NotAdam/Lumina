using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CustomTalkNestHandlers", columnHash: 0xdbf43666 )]
    public class CustomTalkNestHandlers : IExcelRow
    {
        
        public uint NestHandler;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            NestHandler = parser.ReadColumn< uint >( 0 );
        }
    }
}