// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Tomestones", columnHash: 0xd870e208 )]
    public partial class Tomestones : ExcelRow
    {
        
        public ushort WeeklyLimit { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            WeeklyLimit = parser.ReadColumn< ushort >( 0 );
        }
    }
}