// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringExp", columnHash: 0xda365c51 )]
    public partial class GatheringExp : ExcelRow
    {
        
        public int Exp { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Exp = parser.ReadColumn< int >( 0 );
        }
    }
}