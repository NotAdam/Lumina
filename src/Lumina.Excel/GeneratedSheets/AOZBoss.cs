// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AOZBoss", columnHash: 0x2020acf6 )]
    public partial class AOZBoss : ExcelRow
    {
        
        public LazyRow< AOZContentBriefingBNpc > Boss { get; set; }
        public ushort Position { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Boss = new LazyRow< AOZContentBriefingBNpc >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            Position = parser.ReadColumn< ushort >( 1 );
        }
    }
}