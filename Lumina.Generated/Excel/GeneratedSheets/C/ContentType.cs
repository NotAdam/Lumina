using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentType", columnHash: 0xf75a9d4b )]
    public class ContentType : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public uint Icon;

        // col: 02 offset: 0008
        public uint IconDutyFinder;

        // col: 03 offset: 000c
        public byte unknownc;

        // col: 04 offset: 000d
        public byte unknownd;

        // col: 05 offset: 000e
        public byte unknowne;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Icon = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            IconDutyFinder = parser.ReadOffset< uint >( 0x8 );

            // col: 3 offset: 000c
            unknownc = parser.ReadOffset< byte >( 0xc );

            // col: 4 offset: 000d
            unknownd = parser.ReadOffset< byte >( 0xd );

            // col: 5 offset: 000e
            unknowne = parser.ReadOffset< byte >( 0xe );


        }
    }
}