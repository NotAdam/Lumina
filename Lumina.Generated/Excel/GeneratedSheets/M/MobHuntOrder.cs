using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MobHuntOrder", columnHash: 0xa9aa9ab5 )]
    public class MobHuntOrder : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public ushort Target;

        // col: 01 offset: 0002
        public byte NeededKills;

        // col: 02 offset: 0003
        public byte Type;

        // col: 03 offset: 0004
        public byte Rank;

        // col: 04 offset: 0005
        public byte MobHuntReward;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Target = parser.ReadOffset< ushort >( 0x0 );

            // col: 1 offset: 0002
            NeededKills = parser.ReadOffset< byte >( 0x2 );

            // col: 2 offset: 0003
            Type = parser.ReadOffset< byte >( 0x3 );

            // col: 3 offset: 0004
            Rank = parser.ReadOffset< byte >( 0x4 );

            // col: 4 offset: 0005
            MobHuntReward = parser.ReadOffset< byte >( 0x5 );


        }
    }
}