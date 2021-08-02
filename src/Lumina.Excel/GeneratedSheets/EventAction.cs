// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventAction", columnHash: 0x1c60d673 )]
    public partial class EventAction : ExcelRow
    {
        
        public SeString Name { get; set; }
        public ushort Icon { get; set; }
        public byte CastTime { get; set; }
        public LazyRow< ActionTimeline >[] Animation { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Icon = parser.ReadColumn< ushort >( 1 );
            CastTime = parser.ReadColumn< byte >( 2 );
            Animation = new LazyRow< ActionTimeline >[ 3 ];
            for( var i = 0; i < 3; i++ )
                Animation[ i ] = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 3 + i ), language );
        }
    }
}