// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MapCondition", columnHash: 0x2064ea88 )]
    public partial class MapCondition : ExcelRow
    {
        
        public ushort Unknown0 { get; set; }
        public LazyRow< Quest > Quest { get; set; }
        public byte Unknown2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< ushort >( 0 );
            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< int >( 1 ), language );
            Unknown2 = parser.ReadColumn< byte >( 2 );
        }
    }
}