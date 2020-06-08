using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Trait", columnHash: 0x395111c9 )]
    public class Trait : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 04 offset: 0004
        public uint Quest;

        // col: 01 offset: 0008
        public int Icon;

        // col: 05 offset: 000c
        public short Value;

        // col: 02 offset: 000e
        public byte ClassJob;

        // col: 03 offset: 000f
        public byte Level;

        // col: 06 offset: 0010
        public byte ClassJobCategory;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 4 offset: 0004
            Quest = parser.ReadOffset< uint >( 0x4 );

            // col: 1 offset: 0008
            Icon = parser.ReadOffset< int >( 0x8 );

            // col: 5 offset: 000c
            Value = parser.ReadOffset< short >( 0xc );

            // col: 2 offset: 000e
            ClassJob = parser.ReadOffset< byte >( 0xe );

            // col: 3 offset: 000f
            Level = parser.ReadOffset< byte >( 0xf );

            // col: 6 offset: 0010
            ClassJobCategory = parser.ReadOffset< byte >( 0x10 );


        }
    }
}