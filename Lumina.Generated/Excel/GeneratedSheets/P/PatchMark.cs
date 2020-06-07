using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PatchMark", columnHash: 0x4b87e076 )]
    public class PatchMark : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 04 offset: 0000
        public uint unknown0;

        // col: 05 offset: 0004
        public uint MarkID;

        // col: 02 offset: 0008
        public ushort SubCategory;

        // col: 07 offset: 000a
        public ushort unknowna;

        // col: 01 offset: 000c
        public byte SubCategoryType;

        // col: 03 offset: 000d
        public byte unknownd;

        // col: 06 offset: 000e
        public byte Version;

        // col: 00 offset: 000f
        public sbyte Category;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            unknown0 = parser.ReadOffset< uint >( 0x0 );

            // col: 5 offset: 0004
            MarkID = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            SubCategory = parser.ReadOffset< ushort >( 0x8 );

            // col: 7 offset: 000a
            unknowna = parser.ReadOffset< ushort >( 0xa );

            // col: 1 offset: 000c
            SubCategoryType = parser.ReadOffset< byte >( 0xc );

            // col: 3 offset: 000d
            unknownd = parser.ReadOffset< byte >( 0xd );

            // col: 6 offset: 000e
            Version = parser.ReadOffset< byte >( 0xe );

            // col: 0 offset: 000f
            Category = parser.ReadOffset< sbyte >( 0xf );


        }
    }
}