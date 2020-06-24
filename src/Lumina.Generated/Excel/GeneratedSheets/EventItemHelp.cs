using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventItemHelp", columnHash: 0x8e477c70 )]
    public class EventItemHelp : IExcelRow
    {
        
        public string Description;
        public bool Unknown1;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Description = parser.ReadColumn< string >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
        }
    }
}