using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MobHuntOrder", columnHash: 0xa9aa9ab5 )]
    public class MobHuntOrder : IExcelRow
    {
        
        public LazyRow< MobHuntTarget > Target;
        public byte NeededKills;
        public byte Type;
        public byte Rank;
        public LazyRow< MobHuntReward > MobHuntReward;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Target = new LazyRow< MobHuntTarget >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            NeededKills = parser.ReadColumn< byte >( 1 );
            Type = parser.ReadColumn< byte >( 2 );
            Rank = parser.ReadColumn< byte >( 3 );
            MobHuntReward = new LazyRow< MobHuntReward >( lumina, parser.ReadColumn< byte >( 4 ), language );
        }
    }
}