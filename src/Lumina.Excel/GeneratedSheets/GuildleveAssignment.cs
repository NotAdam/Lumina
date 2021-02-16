// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuildleveAssignment", columnHash: 0x129d93fa )]
    public class GuildleveAssignment : ExcelRow
    {
        
        public SeString Unknown0;
        public byte AddedIn53;
        public uint AssignmentTalk;
        public LazyRow< Quest >[] Quest;
        public bool Unknown5;
        public bool Unknown6;
        public bool Unknown7;
        public bool Unknown8;
        public bool Unknown9;
        public byte Unknown10;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< SeString >( 0 );
            AddedIn53 = parser.ReadColumn< byte >( 1 );
            AssignmentTalk = parser.ReadColumn< uint >( 2 );
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