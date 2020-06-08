using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SatisfactionSupply", columnHash: 0x2d608ea2 )]
    public class SatisfactionSupply : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 02 offset: 0000
        public int Item;

        // col: 03 offset: 0004
        public ushort CollectabilityLow;

        // col: 04 offset: 0006
        public ushort CollectabilityMid;

        // col: 05 offset: 0008
        public ushort CollectabilityHigh;

        // col: 06 offset: 000a
        public ushort Reward;

        // col: 00 offset: 000c
        public byte Slot;

        // col: 01 offset: 000d
        public byte ProbabilityPct;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            Item = parser.ReadOffset< int >( 0x0 );

            // col: 3 offset: 0004
            CollectabilityLow = parser.ReadOffset< ushort >( 0x4 );

            // col: 4 offset: 0006
            CollectabilityMid = parser.ReadOffset< ushort >( 0x6 );

            // col: 5 offset: 0008
            CollectabilityHigh = parser.ReadOffset< ushort >( 0x8 );

            // col: 6 offset: 000a
            Reward = parser.ReadOffset< ushort >( 0xa );

            // col: 0 offset: 000c
            Slot = parser.ReadOffset< byte >( 0xc );

            // col: 1 offset: 000d
            ProbabilityPct = parser.ReadOffset< byte >( 0xd );


        }
    }
}