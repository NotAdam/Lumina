// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "VVDVariantAction", columnHash: 0xdbf43666 )]
    public partial class VVDVariantAction : ExcelRow
    {
        
        public LazyRow< Action > Action { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Action = new LazyRow< Action >( gameData, parser.ReadColumn< uint >( 0 ), language );
        }
    }
}