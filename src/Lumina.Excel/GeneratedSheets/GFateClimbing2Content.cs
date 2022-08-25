// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GFateClimbing2Content", columnHash: 0x5a05613d )]
    public partial class GFateClimbing2Content : ExcelRow
    {
        
        public LazyRow< PublicContentTextData > PublicContentTextData { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            PublicContentTextData = new LazyRow< PublicContentTextData >( gameData, parser.ReadColumn< uint >( 0 ), language );
        }
    }
}