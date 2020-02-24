using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Adventure", columnHash: 0xf6b785f8 )]
    public class Adventure : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 09 offset: 0000
        public string Name;

        // col: 10 offset: 0004
        public string Impression;

        // col: 11 offset: 0008
        public string Description;

        // col: 00 offset: 000c
        public int Level;

        // col: 01 offset: 0010
        public int MinLevel;

        // col: 06 offset: 0014
        public int PlaceName;

        // col: 07 offset: 0018
        public int IconList;

        // col: 08 offset: 001c
        public int IconDiscovered;

        // col: 12 offset: 0020
        public int IconUndiscovered;

        // col: 03 offset: 0024
        public ushort Emote;

        // col: 04 offset: 0026
        public ushort MinTime;

        // col: 05 offset: 0028
        public ushort MaxTime;

        // col: 02 offset: 002a
        public byte MaxLevel;

        // col: 13 offset: 002b
        private byte packed2b;
        public bool IsInitial => ( packed2b & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 9 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 10 offset: 0004
            Impression = parser.ReadOffset< string >( 0x4 );

            // col: 11 offset: 0008
            Description = parser.ReadOffset< string >( 0x8 );

            // col: 0 offset: 000c
            Level = parser.ReadOffset< int >( 0xc );

            // col: 1 offset: 0010
            MinLevel = parser.ReadOffset< int >( 0x10 );

            // col: 6 offset: 0014
            PlaceName = parser.ReadOffset< int >( 0x14 );

            // col: 7 offset: 0018
            IconList = parser.ReadOffset< int >( 0x18 );

            // col: 8 offset: 001c
            IconDiscovered = parser.ReadOffset< int >( 0x1c );

            // col: 12 offset: 0020
            IconUndiscovered = parser.ReadOffset< int >( 0x20 );

            // col: 3 offset: 0024
            Emote = parser.ReadOffset< ushort >( 0x24 );

            // col: 4 offset: 0026
            MinTime = parser.ReadOffset< ushort >( 0x26 );

            // col: 5 offset: 0028
            MaxTime = parser.ReadOffset< ushort >( 0x28 );

            // col: 2 offset: 002a
            MaxLevel = parser.ReadOffset< byte >( 0x2a );

            // col: 13 offset: 002b
            packed2b = parser.ReadOffset< byte >( 0x2b, ExcelColumnDataType.UInt8 );


        }
    }
}