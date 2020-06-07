using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Knockback", columnHash: 0x6876beaf )]
    public class Knockback : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public byte Distance;

        // col: 01 offset: 0001
        public byte Speed;

        // col: 03 offset: 0002
        public byte NearDistance;

        // col: 04 offset: 0003
        public byte Direction;

        // col: 05 offset: 0004
        public byte DirectionArg;

        // col: 02 offset: 0005
        public bool Motion;
        public byte packed5;
        public bool CancelMove;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Distance = parser.ReadOffset< byte >( 0x0 );

            // col: 1 offset: 0001
            Speed = parser.ReadOffset< byte >( 0x1 );

            // col: 3 offset: 0002
            NearDistance = parser.ReadOffset< byte >( 0x2 );

            // col: 4 offset: 0003
            Direction = parser.ReadOffset< byte >( 0x3 );

            // col: 5 offset: 0004
            DirectionArg = parser.ReadOffset< byte >( 0x4 );

            // col: 2 offset: 0005
            packed5 = parser.ReadOffset< byte >( 0x5, ExcelColumnDataType.UInt8 );

            Motion = ( packed5 & 0x1 ) == 0x1;
            CancelMove = ( packed5 & 0x2 ) == 0x2;


        }
    }
}