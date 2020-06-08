using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringPointBonus", columnHash: 0x1f29bd0d )]
    public class GatheringPointBonus : IExcelRow
    {
        
        public LazyRow< GatheringCondition > Condition;
        public ushort ConditionValue;
        public ushort Unknown2;
        public LazyRow< GatheringPointBonusType > BonusType;
        public ushort BonusValue;
        public ushort Unknown5;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Condition = new LazyRow< GatheringCondition >( lumina, parser.ReadColumn< byte >( 0 ) );
            ConditionValue = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            BonusType = new LazyRow< GatheringPointBonusType >( lumina, parser.ReadColumn< byte >( 3 ) );
            BonusValue = parser.ReadColumn< ushort >( 4 );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
        }
    }
}