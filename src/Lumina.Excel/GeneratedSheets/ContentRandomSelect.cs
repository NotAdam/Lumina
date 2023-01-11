// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentRandomSelect", columnHash: 0xd870e208 )]
    public partial class ContentRandomSelect : ExcelRow
    {
        
        public LazyRow< ContentFinderCondition > Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = new LazyRow< ContentFinderCondition >( gameData, parser.ReadColumn< ushort >( 0 ), language );
        }
    }
}