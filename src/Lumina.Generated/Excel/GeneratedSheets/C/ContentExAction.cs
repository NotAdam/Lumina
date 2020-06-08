using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentExAction", columnHash: 0x8690a89e )]
    public class ContentExAction : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public uint Name;

        // col: 01 offset: 0004
        public uint unknown4;

        // col: 02 offset: 0008
        public byte Charges;

        // col: 03 offset: 0009
        public byte unknown9;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            unknown4 = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            Charges = parser.ReadOffset< byte >( 0x8 );

            // col: 3 offset: 0009
            unknown9 = parser.ReadOffset< byte >( 0x9 );


        }
    }
}