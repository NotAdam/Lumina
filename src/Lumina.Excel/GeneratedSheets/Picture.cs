// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Picture", columnHash: 0xfaedad07 )]
    public partial class Picture : ExcelRow
    {
        
        public LazyRow< Item > Item { get; set; }
        public int Image { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 0 ), language );
            Image = parser.ReadColumn< int >( 1 );
        }
    }
}