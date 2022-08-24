// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DpsChallengeOfficer", columnHash: 0xef9733d1 )]
    public partial class DpsChallengeOfficer : ExcelRow
    {
        
        public LazyRow< Quest > UnlockQuest { get; set; }
        public LazyRow< DpsChallenge >[] ChallengeName { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            UnlockQuest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 0 ), language );
            ChallengeName = new LazyRow< DpsChallenge >[ 25 ];
            for( var i = 0; i < 25; i++ )
                ChallengeName[ i ] = new LazyRow< DpsChallenge >( gameData, parser.ReadColumn< ushort >( 1 + i ), language );
        }
    }
}