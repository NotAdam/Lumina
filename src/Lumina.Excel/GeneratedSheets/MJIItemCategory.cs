// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIItemCategory", columnHash: 0x9db0e48f )]
    public partial class MJIItemCategory : ExcelRow
    {
        
        public SeString Singular { get; set; }
        public SeString Plural { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Singular = parser.ReadColumn< SeString >( 0 );
            Plural = parser.ReadColumn< SeString >( 1 );
        }
    }
}