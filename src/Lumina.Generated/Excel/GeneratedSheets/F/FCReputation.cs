using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FCReputation", columnHash: 0x3d6be37e )]
    public class FCReputation : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 04 offset: 0000
        public string Name;

        // col: 00 offset: 0004
        public uint PointsToNext;

        // col: 01 offset: 0008
        public uint RequiredPoints;

        // col: 03 offset: 000c
        public uint Color;

        // col: 02 offset: 0010
        public byte DiscountRate;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 0 offset: 0004
            PointsToNext = parser.ReadOffset< uint >( 0x4 );

            // col: 1 offset: 0008
            RequiredPoints = parser.ReadOffset< uint >( 0x8 );

            // col: 3 offset: 000c
            Color = parser.ReadOffset< uint >( 0xc );

            // col: 2 offset: 0010
            DiscountRate = parser.ReadOffset< byte >( 0x10 );


        }
    }
}