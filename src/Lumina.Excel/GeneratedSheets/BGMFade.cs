// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGMFade", columnHash: 0xf09994a9 )]
    public class BGMFade : ExcelRow
    {
        
        public int SceneOut;
        public int SceneIn;
        public LazyRow< BGMFadeType > BGMFadeType;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            SceneOut = parser.ReadColumn< int >( 0 );
            SceneIn = parser.ReadColumn< int >( 1 );
            BGMFadeType = new LazyRow< BGMFadeType >( gameData, parser.ReadColumn< int >( 2 ), language );
        }
    }
}