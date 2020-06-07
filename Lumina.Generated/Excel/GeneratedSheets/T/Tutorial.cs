using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Tutorial", columnHash: 0x871b8a1c )]
    public class Tutorial : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 04 offset: 0000
        public uint Exp;

        // col: 05 offset: 0004
        public uint Gil;

        // col: 06 offset: 0008
        public uint RewardTank;

        // col: 07 offset: 000c
        public uint RewardMelee;

        // col: 08 offset: 0010
        public uint RewardRanged;

        // col: 09 offset: 0014
        public uint Objective;

        // col: 00 offset: 0018
        public byte unknown18;

        // col: 01 offset: 0019
        public byte unknown19;

        // col: 02 offset: 001a
        public byte unknown1a;

        // col: 03 offset: 001b
        public byte unknown1b;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            Exp = parser.ReadOffset< uint >( 0x0 );

            // col: 5 offset: 0004
            Gil = parser.ReadOffset< uint >( 0x4 );

            // col: 6 offset: 0008
            RewardTank = parser.ReadOffset< uint >( 0x8 );

            // col: 7 offset: 000c
            RewardMelee = parser.ReadOffset< uint >( 0xc );

            // col: 8 offset: 0010
            RewardRanged = parser.ReadOffset< uint >( 0x10 );

            // col: 9 offset: 0014
            Objective = parser.ReadOffset< uint >( 0x14 );

            // col: 0 offset: 0018
            unknown18 = parser.ReadOffset< byte >( 0x18 );

            // col: 1 offset: 0019
            unknown19 = parser.ReadOffset< byte >( 0x19 );

            // col: 2 offset: 001a
            unknown1a = parser.ReadOffset< byte >( 0x1a );

            // col: 3 offset: 001b
            unknown1b = parser.ReadOffset< byte >( 0x1b );


        }
    }
}