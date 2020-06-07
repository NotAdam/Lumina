using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BuddySkill", columnHash: 0xe3220ddc )]
    public class BuddySkill : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 02 offset: 0000
        public ushort Defender;

        // col: 03 offset: 0002
        public ushort Attacker;

        // col: 04 offset: 0004
        public ushort Healer;

        // col: 00 offset: 0006
        public byte BuddyLevel;

        // col: 01 offset: 0007
        public bool IsActive;
        public byte packed7;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            Defender = parser.ReadOffset< ushort >( 0x0 );

            // col: 3 offset: 0002
            Attacker = parser.ReadOffset< ushort >( 0x2 );

            // col: 4 offset: 0004
            Healer = parser.ReadOffset< ushort >( 0x4 );

            // col: 0 offset: 0006
            BuddyLevel = parser.ReadOffset< byte >( 0x6 );

            // col: 1 offset: 0007
            packed7 = parser.ReadOffset< byte >( 0x7, ExcelColumnDataType.UInt8 );

            IsActive = ( packed7 & 0x1 ) == 0x1;


        }
    }
}