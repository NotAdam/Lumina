// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AOZContent", columnHash: 0x615a9876 )]
    public partial class AOZContent : ExcelRow
    {
        
        public ushort StandardFinishTime { get; set; }
        public ushort IdealFinishTime { get; set; }
        public byte Act1FightType { get; set; }
        public ushort Act1 { get; set; }
        public byte ArenaType1 { get; set; }
        public byte Act2FightType { get; set; }
        public ushort Act2 { get; set; }
        public byte ArenaType2 { get; set; }
        public byte Act3FightType { get; set; }
        public ushort Act3 { get; set; }
        public byte ArenaType3 { get; set; }
        public uint ContentEntry { get; set; }
        public byte Order { get; set; }
        public ushort GilReward { get; set; }
        public ushort AlliedSealsReward { get; set; }
        public ushort TomestonesReward { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            StandardFinishTime = parser.ReadColumn< ushort >( 0 );
            IdealFinishTime = parser.ReadColumn< ushort >( 1 );
            Act1FightType = parser.ReadColumn< byte >( 2 );
            Act1 = parser.ReadColumn< ushort >( 3 );
            ArenaType1 = parser.ReadColumn< byte >( 4 );
            Act2FightType = parser.ReadColumn< byte >( 5 );
            Act2 = parser.ReadColumn< ushort >( 6 );
            ArenaType2 = parser.ReadColumn< byte >( 7 );
            Act3FightType = parser.ReadColumn< byte >( 8 );
            Act3 = parser.ReadColumn< ushort >( 9 );
            ArenaType3 = parser.ReadColumn< byte >( 10 );
            ContentEntry = parser.ReadColumn< uint >( 11 );
            Order = parser.ReadColumn< byte >( 12 );
            GilReward = parser.ReadColumn< ushort >( 13 );
            AlliedSealsReward = parser.ReadColumn< ushort >( 14 );
            TomestonesReward = parser.ReadColumn< ushort >( 15 );
        }
    }
}