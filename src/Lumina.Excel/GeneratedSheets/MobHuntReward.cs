// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MobHuntReward", columnHash: 0x4ace707c )]
    public class MobHuntReward : IExcelRow
    {
        
        public uint ExpReward;
        public ushort GilReward;
        public LazyRow< ExVersion > Expansion;
        public ushort CurrencyReward;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ExpReward = parser.ReadColumn< uint >( 0 );
            GilReward = parser.ReadColumn< ushort >( 1 );
            Expansion = new LazyRow< ExVersion >( lumina, parser.ReadColumn< byte >( 2 ), language );
            CurrencyReward = parser.ReadColumn< ushort >( 3 );
        }
    }
}