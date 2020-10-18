// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringPointBonus", columnHash: 0xc7bd9244 )]
    public class GatheringPointBonus : IExcelRow
    {
        
        public LazyRow< GatheringCondition > Condition;
        public uint ConditionValue;
        public ushort Unknown2;
        public LazyRow< GatheringPointBonusType > BonusType;
        public ushort BonusValue;
        public ushort Unknown5;
        public bool AddedIn53;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Condition = new LazyRow< GatheringCondition >( lumina, parser.ReadColumn< byte >( 0 ), language );
            ConditionValue = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            BonusType = new LazyRow< GatheringPointBonusType >( lumina, parser.ReadColumn< byte >( 3 ), language );
            BonusValue = parser.ReadColumn< ushort >( 4 );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
            AddedIn53 = parser.ReadColumn< bool >( 6 );
        }
    }
}