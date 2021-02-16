// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HowTo", columnHash: 0xe4488448 )]
    public class HowTo : ExcelRow
    {
        
        public SeString Unknown0;
        public bool Unknown1;
        public LazyRow< HowToPage >[] Images;
        public LazyRow< HowToCategory > Category;
        public byte Unknown13;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Images = new LazyRow< HowToPage >[ 10 ];
            for( var i = 0; i < 10; i++ )
                Images[ i ] = new LazyRow< HowToPage >( gameData, parser.ReadColumn< short >( 2 + i ), language );
            Category = new LazyRow< HowToCategory >( gameData, parser.ReadColumn< sbyte >( 12 ), language );
            Unknown13 = parser.ReadColumn< byte >( 13 );
        }
    }
}