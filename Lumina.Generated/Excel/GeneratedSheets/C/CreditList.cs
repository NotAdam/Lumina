using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CreditList", columnHash: 0x089033fa )]
    public class CreditList : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public uint Icon;

        // col: 02 offset: 0004
        public uint Font;

        // col: 05 offset: 0008
        public uint Cast;

        // col: 00 offset: 000c
        public ushort Scale;

        // col: 03 offset: 000e
        public byte unknowne;

        // col: 04 offset: 000f
        public byte unknownf;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Icon = parser.ReadOffset< uint >( 0x0 );

            // col: 2 offset: 0004
            Font = parser.ReadOffset< uint >( 0x4 );

            // col: 5 offset: 0008
            Cast = parser.ReadOffset< uint >( 0x8 );

            // col: 0 offset: 000c
            Scale = parser.ReadOffset< ushort >( 0xc );

            // col: 3 offset: 000e
            unknowne = parser.ReadOffset< byte >( 0xe );

            // col: 4 offset: 000f
            unknownf = parser.ReadOffset< byte >( 0xf );


        }
    }
}