// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FateTokenType", columnHash: 0xdbf43666 )]
    public partial class FateTokenType : ExcelRow
    {
        
        public LazyRow< Item > Currency { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Currency = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 0 ), language );
        }
    }
}