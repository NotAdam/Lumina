// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "StainTransient", columnHash: 0x5d58cc84 )]
    public partial class StainTransient : ExcelRow
    {
        
        public LazyRow< Item > Item1 { get; set; }
        public LazyRow< Item > Item2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item1 = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Item2 = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 1 ), language );
        }
    }
}