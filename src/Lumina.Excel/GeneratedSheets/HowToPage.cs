// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HowToPage", columnHash: 0x006e1eac )]
    public partial class HowToPage : ExcelRow
    {
        
        public byte Type { get; set; }
        public byte IconType { get; set; }
        public int Image { get; set; }
        public byte TextType { get; set; }
        public SeString[] Text { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Type = parser.ReadColumn< byte >( 0 );
            IconType = parser.ReadColumn< byte >( 1 );
            Image = parser.ReadColumn< int >( 2 );
            TextType = parser.ReadColumn< byte >( 3 );
            Text = new SeString[ 3 ];
            for( var i = 0; i < 3; i++ )
                Text[ i ] = parser.ReadColumn< SeString >( 4 + i );
        }
    }
}