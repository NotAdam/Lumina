using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "JournalCategory", columnHash: 0xc5670d26 )]
    public class JournalCategory : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public byte SeparateType;

        // col: 02 offset: 0005
        public byte DataType;

        // col: 03 offset: 0006
        public byte JournalSection;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            SeparateType = parser.ReadOffset< byte >( 0x4 );

            // col: 2 offset: 0005
            DataType = parser.ReadOffset< byte >( 0x5 );

            // col: 3 offset: 0006
            JournalSection = parser.ReadOffset< byte >( 0x6 );


        }
    }
}