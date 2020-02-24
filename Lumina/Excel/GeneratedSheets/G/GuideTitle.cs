using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuideTitle", columnHash: 0x9db0e48f )]
    public class GuideTitle : IExcelRow
    {
        // column defs from Wed, 31 Jul 2019 22:24:05 GMT


        // col: 00 offset: 0000
        public string Title;

        // col: 01 offset: 0004
        public string unknown4;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Title = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            unknown4 = parser.ReadOffset< string >( 0x4 );


        }
    }
}