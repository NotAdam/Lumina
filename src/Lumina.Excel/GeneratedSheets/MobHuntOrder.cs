// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MobHuntOrder", columnHash: 0xa9aa9ab5 )]
    public class MobHuntOrder : ExcelRow
    {
        
        public LazyRow< MobHuntTarget > Target;
        public byte NeededKills;
        public byte Type;
        public byte Rank;
        public LazyRow< MobHuntReward > MobHuntReward;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Target = new LazyRow< MobHuntTarget >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            NeededKills = parser.ReadColumn< byte >( 1 );
            Type = parser.ReadColumn< byte >( 2 );
            Rank = parser.ReadColumn< byte >( 3 );
            MobHuntReward = new LazyRow< MobHuntReward >( gameData, parser.ReadColumn< byte >( 4 ), language );
        }
    }
}