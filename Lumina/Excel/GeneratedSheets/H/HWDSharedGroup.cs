using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDSharedGroup", columnHash: 0x5a516458 )]
    public class HWDSharedGroup : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 00 offset: 0000
        public uint LGB;

        // col: 01 offset: 0004
        public byte Param;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            LGB = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            Param = parser.ReadOffset< byte >( 0x4 );


        }
    }
}