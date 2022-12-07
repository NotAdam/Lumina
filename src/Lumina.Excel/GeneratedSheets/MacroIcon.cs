// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MacroIcon", columnHash: 0x83d33be1 )]
    public partial class MacroIcon : ExcelRow
    {
        
        public int Icon { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Icon = parser.ReadColumn< int >( 0 );
        }
    }
}