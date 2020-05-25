using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnGrowMember", columnHash: 0xa0995e80 )]
    public class DawnGrowMember : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public uint Member;

        // col: 01 offset: 0004
        public uint ImageName;

        // col: 02 offset: 0008
        public uint BigImageOld;

        // col: 03 offset: 000c
        public uint BigImageNew;

        // col: 04 offset: 0010
        public uint SmallImageOld;

        // col: 05 offset: 0014
        public uint SmallImageNew;

        // col: 06 offset: 0018
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
            SmallImageOld = parser.ReadOffset< uint >( 0x10 );

            // col: 5 offset: 0014
            SmallImageNew = parser.ReadOffset< uint >( 0x14 );

            // col: 6 offset: 0018
            Class = parser.ReadOffset< byte >( 0x18 );


        }
    }
}