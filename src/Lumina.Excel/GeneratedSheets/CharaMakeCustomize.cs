// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CharaMakeCustomize", columnHash: 0x2ba6bf0f )]
    public class CharaMakeCustomize : ExcelRow
    {
        
        public byte FeatureID { get; set; }
        public uint Icon { get; set; }
        public ushort Data { get; set; }
        public bool IsPurchasable { get; set; }
        public LazyRow< Lobby > Hint { get; set; }
        public LazyRow< Item > HintItem { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            FeatureID = parser.ReadColumn< byte >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            Data = parser.ReadColumn< ushort >( 2 );
            IsPurchasable = parser.ReadColumn< bool >( 3 );
            Hint = new LazyRow< Lobby >( gameData, parser.ReadColumn< uint >( 4 ), language );
            HintItem = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 5 ), language );
        }
    }
}