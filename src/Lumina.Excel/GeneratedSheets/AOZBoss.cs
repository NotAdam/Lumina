// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AOZBoss", columnHash: 0x2020acf6 )]
    public class AOZBoss : ExcelRow
    {
        
        public LazyRow< AOZContentBriefingBNpc > Boss;
        public ushort Position;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Boss = new LazyRow< AOZContentBriefingBNpc >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            Position = parser.ReadColumn< ushort >( 1 );
        }
    }
}