// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuildleveAssignment", columnHash: 0x129d93fa )]
    public partial class GuildleveAssignment : ExcelRow
    {
        
        public SeString Type { get; set; }
        public byte Unknown1 { get; set; }
        public LazyRow< GuildleveAssignmentTalk > AssignmentTalk { get; set; }
        public LazyRow< Quest >[] Quest { get; set; }
        public bool Unknown5 { get; set; }
        public bool Unknown6 { get; set; }
        public bool Unknown7 { get; set; }
        public bool Unknown8 { get; set; }
        public bool Unknown9 { get; set; }
        public byte Unknown10 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Type = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            AssignmentTalk = new LazyRow< GuildleveAssignmentTalk >( gameData, parser.ReadColumn< uint >( 2 ), language );
            Quest = new LazyRow< Quest >[ 2 ];
            for( var i = 0; i < 2; i++ )
                Quest[ i ] = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 3 + i ), language );
            Unknown5 = parser.ReadColumn< bool >( 5 );
            Unknown6 = parser.ReadColumn< bool >( 6 );
            Unknown7 = parser.ReadColumn< bool >( 7 );
            Unknown8 = parser.ReadColumn< bool >( 8 );
            Unknown9 = parser.ReadColumn< bool >( 9 );
            Unknown10 = parser.ReadColumn< byte >( 10 );
        }
    }
}