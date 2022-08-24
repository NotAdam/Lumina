// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "OrchestrionUiparam", columnHash: 0xd73eab80 )]
    public partial class OrchestrionUiparam : ExcelRow
    {
        
        public LazyRow< OrchestrionCategory > OrchestrionCategory { get; set; }
        public ushort Order { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            OrchestrionCategory = new LazyRow< OrchestrionCategory >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Order = parser.ReadColumn< ushort >( 1 );
        }
    }
}