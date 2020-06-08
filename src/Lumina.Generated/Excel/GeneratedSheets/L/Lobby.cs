using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Lobby", columnHash: 0x54075f2e )]
    public class Lobby : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 03 offset: 0000
        public string Text;

        // col: 04 offset: 0004
        public string unknown4;

        // col: 05 offset: 0008
        public string unknown8;

        // col: 00 offset: 000c
        public uint TYPE;

        // col: 01 offset: 0010
        public uint PARAM;

        // col: 02 offset: 0014
        public uint LINK;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 3 offset: 0000
            Text = parser.ReadOffset< string >( 0x0 );

            // col: 4 offset: 0004
            unknown4 = parser.ReadOffset< string >( 0x4 );

            // col: 5 offset: 0008
            unknown8 = parser.ReadOffset< string >( 0x8 );

            // col: 0 offset: 000c
            TYPE = parser.ReadOffset< uint >( 0xc );

            // col: 1 offset: 0010
            PARAM = parser.ReadOffset< uint >( 0x10 );

            // col: 2 offset: 0014
            LINK = parser.ReadOffset< uint >( 0x14 );


        }
    }
}