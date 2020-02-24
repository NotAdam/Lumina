using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GcArmyCaptureTactics", columnHash: 0x62bcfbad )]
    public class GcArmyCaptureTactics : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 04 offset: 0000
        public uint Tactic;

        // col: 05 offset: 0004
        public uint Icon;

        // col: 00 offset: 0008
        public int Name;

        // col: 01 offset: 000c
        public byte HP;

        // col: 02 offset: 000d
        public byte DamageDealt;

        // col: 03 offset: 000e
        public byte DamageReceived;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            Tactic = parser.ReadOffset< uint >( 0x0 );

            // col: 5 offset: 0004
            Icon = parser.ReadOffset< uint >( 0x4 );

            // col: 0 offset: 0008
            Name = parser.ReadOffset< int >( 0x8 );

            // col: 1 offset: 000c
            HP = parser.ReadOffset< byte >( 0xc );

            // col: 2 offset: 000d
            DamageDealt = parser.ReadOffset< byte >( 0xd );

            // col: 3 offset: 000e
            DamageReceived = parser.ReadOffset< byte >( 0xe );


        }
    }
}