using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "OrchestrionUiparam", columnHash: 0xd73eab80 )]
    public class OrchestrionUiparam : IExcelRow
    {
        
        public LazyRow< OrchestrionCategory > OrchestrionCategory;
        public ushort Order;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            OrchestrionCategory = new LazyRow< OrchestrionCategory >( lumina, parser.ReadColumn< byte >( 0 ), language );
            Order = parser.ReadColumn< ushort >( 1 );
        }
    }
}