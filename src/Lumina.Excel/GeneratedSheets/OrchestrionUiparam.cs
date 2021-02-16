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
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            OrchestrionCategory = new LazyRow< OrchestrionCategory >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Order = parser.ReadColumn< ushort >( 1 );
        }
    }
}