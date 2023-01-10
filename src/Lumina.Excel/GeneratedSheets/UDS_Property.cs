// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "UDS_Property", columnHash: 0x9db0e48f )]
    public partial class UDS_Property : ExcelRow
    {
        
        public SeString Text { get; set; }
        public SeString Type { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Text = parser.ReadColumn< SeString >( 0 );
            Type = parser.ReadColumn< SeString >( 1 );
        }
    }
}