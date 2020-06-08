using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CreditBackImage", columnHash: 0x2b0dbd9a )]
    public class CreditBackImage : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 02 offset: 0000
        public uint BackImage;

        // col: 00 offset: 0004
        public ushort unknown4;

        // col: 01 offset: 0006
        public ushort unknown6;

        // col: 03 offset: 0008
        public byte unknown8;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            BackImage = parser.ReadOffset< uint >( 0x0 );

            // col: 0 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );

            // col: 1 offset: 0006
            unknown6 = parser.ReadOffset< ushort >( 0x6 );

            // col: 3 offset: 0008
            unknown8 = parser.ReadOffset< byte >( 0x8 );


        }
    }
}