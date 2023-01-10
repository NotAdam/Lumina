// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "McGuffin", columnHash: 0xdcfd9eba )]
    public partial class McGuffin : ExcelRow
    {
        
        public LazyRow< McGuffinUIData > UIData { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            UIData = new LazyRow< McGuffinUIData >( gameData, parser.ReadColumn< byte >( 0 ), language );
        }
    }
}