using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringPointTransient", columnHash: 0x7164626b )]
    public class GatheringPointTransient : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 02 offset: 0000
        public int GatheringRarePopTimeTable;

        // col: 00 offset: 0004
        public ushort EphemeralStartTime;

        // col: 01 offset: 0006
        public ushort EphemeralEndTime;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            GatheringRarePopTimeTable = parser.ReadOffset< int >( 0x0 );

            // col: 0 offset: 0004
            EphemeralStartTime = parser.ReadOffset< ushort >( 0x4 );

            // col: 1 offset: 0006
            EphemeralEndTime = parser.ReadOffset< ushort >( 0x6 );


        }
    }
}