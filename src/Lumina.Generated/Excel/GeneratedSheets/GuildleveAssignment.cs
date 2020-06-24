using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuildleveAssignment", columnHash: 0x55964b3b )]
    public class GuildleveAssignment : IExcelRow
    {
        
        public string Unknown0;
        public uint AssignmentTalk;
        public LazyRow< Quest >[] Quest;
        public bool Unknown4;
        public bool Unknown5;
        public bool Unknown6;
        public bool Unknown7;
        public bool Unknown8;
        public byte Unknown9;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< string >( 0 );
            AssignmentTalk = parser.ReadColumn< uint >( 1 );
            Quest = new LazyRow< Quest >[ 2 ];
            for( var i = 0; i < 2; i++ )
                Quest[ i ] = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 2 + i ), language );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
            Unknown6 = parser.ReadColumn< bool >( 6 );
            Unknown7 = parser.ReadColumn< bool >( 7 );
            Unknown8 = parser.ReadColumn< bool >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
        }
    }
}