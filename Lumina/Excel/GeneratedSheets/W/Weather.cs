using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Weather", columnHash: 0x02cf2541 )]
    public class Weather : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 01 offset: 0000
        public string Name;

        // col: 02 offset: 0004
        public string Description;

        // col: 03 offset: 0008
        public string unknown8;

        // col: 04 offset: 000c
        public string unknownc;

        // col: 05 offset: 0010
        public string unknown10;

        // col: 06 offset: 0014
        public string unknown14;

        // col: 00 offset: 0018
        public int Icon;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            Description = parser.ReadOffset< string >( 0x4 );

            // col: 3 offset: 0008
            unknown8 = parser.ReadOffset< string >( 0x8 );

            // col: 4 offset: 000c
            unknownc = parser.ReadOffset< string >( 0xc );

            // col: 5 offset: 0010
            unknown10 = parser.ReadOffset< string >( 0x10 );

            // col: 6 offset: 0014
            unknown14 = parser.ReadOffset< string >( 0x14 );

            // col: 0 offset: 0018
            Icon = parser.ReadOffset< int >( 0x18 );


        }
    }
}