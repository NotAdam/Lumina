using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnQuestMember", columnHash: 0x6ce9409c )]
    public class DawnQuestMember : IExcelRow
    {
        // column defs from Mon, 15 Jul 2019 14:22:54 GMT


        // col: 00 offset: 0000
        public uint Member;

        // col: 01 offset: 0004
        public uint ImageName;

        // col: 02 offset: 0008
        public uint BigImageOld;

        // col: 03 offset: 000c
        public uint BigImageNew;

        // col: 04 offset: 0010
        public byte Class;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Member = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            ImageName = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            BigImageOld = parser.ReadOffset< uint >( 0x8 );

            // col: 3 offset: 000c
            BigImageNew = parser.ReadOffset< uint >( 0xc );

            // col: 4 offset: 0010
            Class = parser.ReadOffset< byte >( 0x10 );


        }
    }
}