// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDFishParam", columnHash: 0x1b55da98 )]
    public partial class IKDFishParam : ExcelRow
    {
        
        public LazyRow< FishParameter > Fish { get; set; }
        public LazyRow< IKDContentBonus > IKDContentBonus { get; set; }
        public byte Unknown2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Fish = new LazyRow< FishParameter >( gameData, parser.ReadColumn< uint >( 0 ), language );
            IKDContentBonus = new LazyRow< IKDContentBonus >( gameData, parser.ReadColumn< byte >( 1 ), language );
            Unknown2 = parser.ReadColumn< byte >( 2 );
        }
    }
}