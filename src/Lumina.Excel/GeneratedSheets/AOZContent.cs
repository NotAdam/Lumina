// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AOZContent", columnHash: 0x615a9876 )]
    public class AOZContent : IExcelRow
    {
        
        public ushort StandardFinishTime;
        public ushort IdealFinishTime;
        public byte Act1FightType;
        public ushort Act1;
        public byte ArenaType1;
        public byte Act2FightType;
        public ushort Act2;
        public byte ArenaType2;
        public byte Act3FightType;
        public ushort Act3;
        public byte ArenaType3;
        public uint ContentEntry;
        public byte Order;
        public ushort GilReward;
        public ushort AlliedSealsReward;
        public ushort TomestonesReward;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

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