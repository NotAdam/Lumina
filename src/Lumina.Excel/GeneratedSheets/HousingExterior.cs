// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingExterior", columnHash: 0xb56595e0 )]
    public class HousingExterior : ExcelRow
    {
        
        public byte Unknown0;
        public byte Unknown1;
        public LazyRow< PlaceName > PlaceName;
        public byte HousingSize;
        public SeString Model;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 2 ), language );
            HousingSize = parser.ReadColumn< byte >( 3 );
            Model = parser.ReadColumn< SeString >( 4 );
        }
    }
}