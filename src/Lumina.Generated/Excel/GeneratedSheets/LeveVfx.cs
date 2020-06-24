using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LeveVfx", columnHash: 0x993d983d )]
    public class LeveVfx : IExcelRow
    {
        
        public string Effect;
        public int Icon;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Effect = parser.ReadColumn< string >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
        }
    }
}