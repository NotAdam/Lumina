// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Channeling", columnHash: 0x23dfe9bd )]
    public class Channeling : IExcelRow
    {
        
        public SeString File;
        public byte WidthScale;
        public bool AddedIn53;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            File = parser.ReadColumn< SeString >( 0 );
            WidthScale = parser.ReadColumn< byte >( 1 );
            AddedIn53 = parser.ReadColumn< bool >( 2 );
        }
    }
}