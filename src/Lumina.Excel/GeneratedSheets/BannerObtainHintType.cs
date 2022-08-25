// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BannerObtainHintType", columnHash: 0x3603f4d0 )]
    public partial class BannerObtainHintType : ExcelRow
    {
        
        public SeString Unknown0 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< SeString >( 0 );
        }
    }
}