// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ENpcDressUp", columnHash: 0xde74b4c4 )]
    public partial class ENpcDressUp : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public LazyRow< ENpcDressUpDress > ENpcDressUpDress { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            ENpcDressUpDress = new LazyRow< ENpcDressUpDress >( gameData, parser.ReadColumn< byte >( 1 ), language );
        }
    }
}