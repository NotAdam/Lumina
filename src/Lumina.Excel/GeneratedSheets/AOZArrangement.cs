// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AOZArrangement", columnHash: 0x2020acf6 )]
    public partial class AOZArrangement : ExcelRow
    {
        
        public LazyRow< AOZContentBriefingBNpc > AOZContentBriefingBNpc { get; set; }
        public ushort Position { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            AOZContentBriefingBNpc = new LazyRow< AOZContentBriefingBNpc >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            Position = parser.ReadColumn< ushort >( 1 );
        }
    }
}