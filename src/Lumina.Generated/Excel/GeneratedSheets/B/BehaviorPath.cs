using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BehaviorPath", columnHash: 0x96572d0d )]
    public class BehaviorPath : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 05 offset: 0000
        public float Speed;

        // col: 00 offset: 0004
        public bool IsTurnTransition;
        public byte packed4;
        public bool IsFadeOut;
        public bool IsFadeIn;
        public bool IsWalking;
        public bool packed4_10;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 5 offset: 0000
            Speed = parser.ReadOffset< float >( 0x0 );

            // col: 0 offset: 0004
            packed4 = parser.ReadOffset< byte >( 0x4, ExcelColumnDataType.UInt8 );

            IsTurnTransition = ( packed4 & 0x1 ) == 0x1;
            IsFadeOut = ( packed4 & 0x2 ) == 0x2;
            IsFadeIn = ( packed4 & 0x4 ) == 0x4;
            IsWalking = ( packed4 & 0x8 ) == 0x8;
            packed4_10 = ( packed4 & 0x10 ) == 0x10;


        }
    }
}