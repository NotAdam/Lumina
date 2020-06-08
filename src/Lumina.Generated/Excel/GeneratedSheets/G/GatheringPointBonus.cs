using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringPointBonus", columnHash: 0x1f29bd0d )]
    public class GatheringPointBonus : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public ushort ConditionValue;

        // col: 02 offset: 0002
        public ushort unknown2;

        // col: 04 offset: 0004
        public ushort BonusValue;

        // col: 05 offset: 0006
        public ushort unknown6;

        // col: 00 offset: 0008
        public byte Condition;

        // col: 03 offset: 0009
        public byte BonusType;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            ConditionValue = parser.ReadOffset< ushort >( 0x0 );

            // col: 2 offset: 0002
            unknown2 = parser.ReadOffset< ushort >( 0x2 );

            // col: 4 offset: 0004
            BonusValue = parser.ReadOffset< ushort >( 0x4 );

            // col: 5 offset: 0006
            unknown6 = parser.ReadOffset< ushort >( 0x6 );

            // col: 0 offset: 0008
            Condition = parser.ReadOffset< byte >( 0x8 );

            // col: 3 offset: 0009
            BonusType = parser.ReadOffset< byte >( 0x9 );


        }
    }
}