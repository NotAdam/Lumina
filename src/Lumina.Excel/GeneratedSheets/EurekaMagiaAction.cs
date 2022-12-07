// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EurekaMagiaAction", columnHash: 0xc5d8a89e )]
    public partial class EurekaMagiaAction : ExcelRow
    {
        
        public LazyRow< Action > Action { get; set; }
        public byte MaxUses { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Action = new LazyRow< Action >( gameData, parser.ReadColumn< uint >( 0 ), language );
            MaxUses = parser.ReadColumn< byte >( 1 );
        }
    }
}