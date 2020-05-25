using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestClassJobReward", columnHash: 0x1eed8c67 )]
    public class QuestClassJobReward : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public uint[] RewardItem;

        // col: 09 offset: 0010
        public uint[] RequiredItem;

        // col: 00 offset: 0020
        public byte ClassJobCategory;

        // col: 05 offset: 0021
        public byte[] RewardAmount;

        // col: 13 offset: 0025
        public byte[] RequiredAmount;

        // col: 17 offset: 0029
        public bool unknown29;

        // col: 18 offset: 002a
        public bool unknown2a;

        // col: 19 offset: 002b
        public bool unknown2b;

        // col: 20 offset: 002c
        public bool unknown2c;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            RewardItem = new uint[4];
            RewardItem[0] = parser.ReadOffset< uint >( 0x0 );
            RewardItem[1] = parser.ReadOffset< uint >( 0x4 );
            RewardItem[2] = parser.ReadOffset< uint >( 0x8 );
            RewardItem[3] = parser.ReadOffset< uint >( 0xc );

            // col: 9 offset: 0010
            RequiredItem = new uint[4];
            RequiredItem[0] = parser.ReadOffset< uint >( 0x10 );
            RequiredItem[1] = parser.ReadOffset< uint >( 0x14 );
            RequiredItem[2] = parser.ReadOffset< uint >( 0x18 );
            RequiredItem[3] = parser.ReadOffset< uint >( 0x1c );

            // col: 0 offset: 0020
            ClassJobCategory = parser.ReadOffset< byte >( 0x20 );

            // col: 5 offset: 0021
            RewardAmount = new byte[4];
            RewardAmount[0] = parser.ReadOffset< byte >( 0x21 );
            RewardAmount[1] = parser.ReadOffset< byte >( 0x22 );
            RewardAmount[2] = parser.ReadOffset< byte >( 0x23 );
            RewardAmount[3] = parser.ReadOffset< byte >( 0x24 );

            // col: 13 offset: 0025
            RequiredAmount = new byte[4];
            RequiredAmount[0] = parser.ReadOffset< byte >( 0x25 );
            RequiredAmount[1] = parser.ReadOffset< byte >( 0x26 );
            RequiredAmount[2] = parser.ReadOffset< byte >( 0x27 );
            RequiredAmount[3] = parser.ReadOffset< byte >( 0x28 );

            // col: 17 offset: 0029
            unknown29 = parser.ReadOffset< bool >( 0x29 );

            // col: 18 offset: 002a
            unknown2a = parser.ReadOffset< bool >( 0x2a );

            // col: 19 offset: 002b
            unknown2b = parser.ReadOffset< bool >( 0x2b );

            // col: 20 offset: 002c
            unknown2c = parser.ReadOffset< bool >( 0x2c );


        }
    }
}