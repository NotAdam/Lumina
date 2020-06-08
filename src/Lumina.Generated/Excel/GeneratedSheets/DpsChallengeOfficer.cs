using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DpsChallengeOfficer", columnHash: 0xef9733d1 )]
    public class DpsChallengeOfficer : IExcelRow
    {
        
        public LazyRow< Quest > UnlockQuest;
        public LazyRow< DpsChallenge >[] ChallengeName;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            UnlockQuest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 0 ) );
            for( var i = 0; i < 25; i++ )
                ChallengeName[ i ] = new LazyRow< DpsChallenge >( lumina, parser.ReadColumn< ushort >( 1 + i ) );
        }
    }
}