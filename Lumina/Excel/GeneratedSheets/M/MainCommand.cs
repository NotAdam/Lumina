using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MainCommand", columnHash: 0x63da0c66 )]
    public class MainCommand : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 04 offset: 0000
        public string Name;

        // col: 05 offset: 0004
        public string Description;

        // col: 00 offset: 0008
        public int Icon;

        // col: 01 offset: 000c
        public byte Category;

        // col: 02 offset: 000d
        public byte MainCommandCategory;

        // col: 03 offset: 000e
        public sbyte SortID;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 5 offset: 0004
            Description = parser.ReadOffset< string >( 0x4 );

            // col: 0 offset: 0008
            Icon = parser.ReadOffset< int >( 0x8 );

            // col: 1 offset: 000c
            Category = parser.ReadOffset< byte >( 0xc );

            // col: 2 offset: 000d
            MainCommandCategory = parser.ReadOffset< byte >( 0xd );

            // col: 3 offset: 000e
            SortID = parser.ReadOffset< sbyte >( 0xe );


        }
    }
}