// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringPointBonus", columnHash: 0xcd832c29 )]
    public class GatheringPointBonus : ExcelRow
    {
        
        public LazyRow< GatheringCondition > Condition;
        public uint ConditionValue;
        public ushort Unknown2;
        public LazyRow< GatheringPointBonusType > BonusType;
        public ushort BonusValue;
        public ushort Unknown5;
        public bool Unknown53;
        public uint Unknown54;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Condition = new LazyRow< GatheringCondition >( lumina, parser.ReadColumn< byte >( 0 ), language );
            ConditionValue = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            BonusType = new LazyRow< GatheringPointBonusType >( lumina, parser.ReadColumn< byte >( 3 ), language );
            BonusValue = parser.ReadColumn< ushort >( 4 );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
            Unknown53 = parser.ReadColumn< bool >( 6 );
            Unknown54 = parser.ReadColumn< uint >( 7 );
        }
    }
}