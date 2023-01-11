// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HowTo", columnHash: 0xe4488448 )]
    public partial class HowTo : ExcelRow
    {
        
        public SeString Name { get; set; }
        public bool Announce { get; set; }
        public LazyRow< HowToPage >[] HowToPagePC { get; set; }
        public LazyRow< HowToPage >[] HowToPageController { get; set; }
        public LazyRow< HowToCategory > Category { get; set; }
        public byte Sort { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Announce = parser.ReadColumn< bool >( 1 );
            HowToPagePC = new LazyRow< HowToPage >[ 5 ];
            for( var i = 0; i < 5; i++ )
                HowToPagePC[ i ] = new LazyRow< HowToPage >( gameData, parser.ReadColumn< short >( 2 + i ), language );
            HowToPageController = new LazyRow< HowToPage >[ 5 ];
            for( var i = 0; i < 5; i++ )
                HowToPageController[ i ] = new LazyRow< HowToPage >( gameData, parser.ReadColumn< short >( 7 + i ), language );
            Category = new LazyRow< HowToCategory >( gameData, parser.ReadColumn< sbyte >( 12 ), language );
            Sort = parser.ReadColumn< byte >( 13 );
        }
    }
}