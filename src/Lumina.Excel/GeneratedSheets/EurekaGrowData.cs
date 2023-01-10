// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EurekaGrowData", columnHash: 0xd870e208 )]
    public partial class EurekaGrowData : ExcelRow
    {
        
        public ushort BaseResistance { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            BaseResistance = parser.ReadColumn< ushort >( 0 );
        }
    }
}