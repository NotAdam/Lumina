using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Balloon", columnHash: 0x9d1b5f4b )]
    public class Balloon : IExcelRow
    {
        
        public bool Slowly;
        public string Dialogue;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Slowly = parser.ReadColumn< bool >( 0 );
            Dialogue = parser.ReadColumn< string >( 1 );
        }
    }
}