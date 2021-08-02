// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Marker", columnHash: 0x0c8db36c )]
    public partial class Marker : ExcelRow
    {
        
        public int Icon { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Icon = parser.ReadColumn< int >( 0 );
            Name = parser.ReadColumn< SeString >( 1 );
        }
    }
}