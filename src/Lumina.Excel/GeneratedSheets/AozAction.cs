// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AozAction", columnHash: 0x5a516458 )]
    public partial class AozAction : ExcelRow
    {
        
        public LazyRow< Action > Action { get; set; }
        public byte Rank { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Action = new LazyRow< Action >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Rank = parser.ReadColumn< byte >( 1 );
        }
    }
}