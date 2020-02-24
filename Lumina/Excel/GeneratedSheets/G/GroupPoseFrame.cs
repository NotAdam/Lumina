using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GroupPoseFrame", columnHash: 0x6499223f )]
    public class GroupPoseFrame : IExcelRow
    {
        // column defs from Mon, 24 Feb 2020 17:34:06 GMT


        // col: 06 offset: 0000
        public string Text;

        // col: 02 offset: 0004
        public string GridText;

        // col: 04 offset: 0008
        public uint unknown8;

        // col: 00 offset: 000c
        public int unknownc;

        // col: 01 offset: 0010
        public int Image;

        // col: 03 offset: 0014
        public int unknown14;

        // col: 05 offset: 0018
        public byte unknown18;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 6 offset: 0000
            Text = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            GridText = parser.ReadOffset< string >( 0x4 );

            // col: 4 offset: 0008
            unknown8 = parser.ReadOffset< uint >( 0x8 );

            // col: 0 offset: 000c
            unknownc = parser.ReadOffset< int >( 0xc );

            // col: 1 offset: 0010
            Image = parser.ReadOffset< int >( 0x10 );

            // col: 3 offset: 0014
            unknown14 = parser.ReadOffset< int >( 0x14 );

            // col: 5 offset: 0018
            unknown18 = parser.ReadOffset< byte >( 0x18 );


        }
    }
}