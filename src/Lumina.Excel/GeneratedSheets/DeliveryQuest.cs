// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeliveryQuest", columnHash: 0xda365c51 )]
    public partial class DeliveryQuest : ExcelRow
    {
        
        public LazyRow< Quest > Quest { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< int >( 0 ), language );
        }
    }
}