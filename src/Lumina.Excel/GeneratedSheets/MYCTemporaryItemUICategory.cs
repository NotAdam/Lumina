// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MYCTemporaryItemUICategory", columnHash: 0x9db0e48f )]
    public class MYCTemporaryItemUICategory : IExcelRow
    {
        
        public SeString Name;
        public SeString Unknown1;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< SeString >( 1 );
        }
    }
}