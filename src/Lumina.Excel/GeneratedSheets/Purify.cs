// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Purify", columnHash: 0xde74b4c4 )]
    public class Purify : ExcelRow
    {
        
        public LazyRow< ClassJob > Class { get; set; }
        public byte Level { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Class = new LazyRow< ClassJob >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Level = parser.ReadColumn< byte >( 1 );
        }
    }
}