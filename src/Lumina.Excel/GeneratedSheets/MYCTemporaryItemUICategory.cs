// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MYCTemporaryItemUICategory", columnHash: 0x9db0e48f )]
    public partial class MYCTemporaryItemUICategory : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString Unknown1 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< SeString >( 1 );
        }
    }
}