using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DpsChallengeOfficer", columnHash: 0xef9733d1 )]
    public class DpsChallengeOfficer : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public ushort[] ChallengeName;

        // col: 00 offset: 0034
        public uint UnlockQuest;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            ChallengeName = new ushort[25];
            ChallengeName[0] = parser.ReadOffset< ushort >( 0x0 );
            ChallengeName[1] = parser.ReadOffset< ushort >( 0x2 );
            ChallengeName[2] = parser.ReadOffset< ushort >( 0x4 );
            ChallengeName[3] = parser.ReadOffset< ushort >( 0x6 );
            ChallengeName[4] = parser.ReadOffset< ushort >( 0x8 );
            ChallengeName[5] = parser.ReadOffset< ushort >( 0xa );
            ChallengeName[6] = parser.ReadOffset< ushort >( 0xc );
            ChallengeName[7] = parser.ReadOffset< ushort >( 0xe );
            ChallengeName[8] = parser.ReadOffset< ushort >( 0x10 );
            ChallengeName[9] = parser.ReadOffset< ushort >( 0x12 );
            ChallengeName[10] = parser.ReadOffset< ushort >( 0x14 );
            ChallengeName[11] = parser.ReadOffset< ushort >( 0x16 );
            ChallengeName[12] = parser.ReadOffset< ushort >( 0x18 );
            ChallengeName[13] = parser.ReadOffset< ushort >( 0x1a );
            ChallengeName[14] = parser.ReadOffset< ushort >( 0x1c );
            ChallengeName[15] = parser.ReadOffset< ushort >( 0x1e );
            ChallengeName[16] = parser.ReadOffset< ushort >( 0x20 );
            ChallengeName[17] = parser.ReadOffset< ushort >( 0x22 );
            ChallengeName[18] = parser.ReadOffset< ushort >( 0x24 );
            ChallengeName[19] = parser.ReadOffset< ushort >( 0x26 );
            ChallengeName[20] = parser.ReadOffset< ushort >( 0x28 );
            ChallengeName[21] = parser.ReadOffset< ushort >( 0x2a );
            ChallengeName[22] = parser.ReadOffset< ushort >( 0x2c );
            ChallengeName[23] = parser.ReadOffset< ushort >( 0x2e );
            ChallengeName[24] = parser.ReadOffset< ushort >( 0x30 );

            // col: 0 offset: 0034
            UnlockQuest = parser.ReadOffset< uint >( 0x34 );


        }
    }
}