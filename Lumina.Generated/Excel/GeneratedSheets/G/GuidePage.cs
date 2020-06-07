using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuidePage", columnHash: 0x5bfa8a4e )]
    public class GuidePage : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public uint Output;

        // col: 00 offset: 0004
        public byte Key;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Output = parser.ReadOffset< uint >( 0x0 );

            // col: 0 offset: 0004
            Key = parser.ReadOffset< byte >( 0x4 );


        }
    }
}