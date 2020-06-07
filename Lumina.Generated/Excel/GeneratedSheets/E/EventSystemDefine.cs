using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventSystemDefine", columnHash: 0x98fff20a )]
    public class EventSystemDefine : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Text;

        // col: 01 offset: 0004
        public uint DefineValue;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Text = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            DefineValue = parser.ReadOffset< uint >( 0x4 );


        }
    }
}