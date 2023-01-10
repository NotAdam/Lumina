// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringPointBonus", columnHash: 0xcd832c29 )]
    public partial class GatheringPointBonus : ExcelRow
    {
        
        public LazyRow< GatheringCondition > Condition { get; set; }
        public uint ConditionValue { get; set; }
        public ushort Unknown2 { get; set; }
        public LazyRow< GatheringPointBonusType > BonusType { get; set; }
        public ushort BonusValue { get; set; }
        public ushort Unknown5 { get; set; }
        public bool Unknown6 { get; set; }
        public uint Unknown7 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Condition = new LazyRow< GatheringCondition >( gameData, parser.ReadColumn< byte >( 0 ), language );
            ConditionValue = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            BonusType = new LazyRow< GatheringPointBonusType >( gameData, parser.ReadColumn< byte >( 3 ), language );
            BonusValue = parser.ReadColumn< ushort >( 4 );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
            Unknown6 = parser.ReadColumn< bool >( 6 );
            Unknown7 = parser.ReadColumn< uint >( 7 );
        }
    }
}