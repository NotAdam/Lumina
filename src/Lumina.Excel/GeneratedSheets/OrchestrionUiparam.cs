// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "OrchestrionUiparam", columnHash: 0xd73eab80 )]
    public class OrchestrionUiparam : ExcelRow
    {
        
        public LazyRow< OrchestrionCategory > OrchestrionCategory;
        public ushort Order;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            OrchestrionCategory = new LazyRow< OrchestrionCategory >( lumina, parser.ReadColumn< byte >( 0 ), language );
            Order = parser.ReadColumn< ushort >( 1 );
        }
    }
}