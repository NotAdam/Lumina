using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LegacyQuest", columnHash: 0x6624322e )]
    public class LegacyQuest : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public string Text;

        // col: 02 offset: 0004
        public string String;

        // col: 00 offset: 0008
        public ushort LegacyQuestID;

        // col: 03 offset: 000a
        public ushort SortKey;

        // col: 04 offset: 000c
        public byte Genre;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Text = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            String = parser.ReadOffset< string >( 0x4 );

            // col: 0 offset: 0008
            LegacyQuestID = parser.ReadOffset< ushort >( 0x8 );

            // col: 3 offset: 000a
            SortKey = parser.ReadOffset< ushort >( 0xa );

            // col: 4 offset: 000c
            Genre = parser.ReadOffset< byte >( 0xc );


        }
    }
}