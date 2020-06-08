using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FCAuthority", columnHash: 0x1ee79c01 )]
    public class FCAuthority : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public int FCAuthorityCategory;

        // col: 02 offset: 0008
        public byte unknown8;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            FCAuthorityCategory = parser.ReadOffset< int >( 0x4 );

            // col: 2 offset: 0008
            unknown8 = parser.ReadOffset< byte >( 0x8 );


        }
    }
}