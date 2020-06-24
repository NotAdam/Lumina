using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Channeling", columnHash: 0x9ff65ad6 )]
    public class Channeling : IExcelRow
    {
        
        public string File;
        public byte WidthScale;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            File = parser.ReadColumn< string >( 0 );
            WidthScale = parser.ReadColumn< byte >( 1 );
        }
    }
}