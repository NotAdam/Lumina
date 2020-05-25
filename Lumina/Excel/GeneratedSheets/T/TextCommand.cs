using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TextCommand", columnHash: 0x5d4b4e4b )]
    public class TextCommand : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 07 offset: 0000
        public string Description;

        // col: 08 offset: 0004
        public string Alias;

        // col: 09 offset: 0008
        public string ShortAlias;

        // col: 05 offset: 000c
        public string Command;

        // col: 06 offset: 0010
        public string ShortCommand;

        // col: 11 offset: 0014
        public uint unknown14;

        // col: 10 offset: 0018
        public ushort unknown18;

        // col: 00 offset: 001a
        public byte unknown1a;

        // col: 01 offset: 001b
        public byte unknown1b;

        // col: 02 offset: 001c
        public sbyte unknown1c;

        // col: 03 offset: 001d
        public sbyte unknown1d;

        // col: 04 offset: 001e
        public sbyte unknown1e;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 7 offset: 0000
            Description = parser.ReadOffset< string >( 0x0 );

            // col: 8 offset: 0004
            Alias = parser.ReadOffset< string >( 0x4 );

            // col: 9 offset: 0008
            ShortAlias = parser.ReadOffset< string >( 0x8 );

            // col: 5 offset: 000c
            Command = parser.ReadOffset< string >( 0xc );

            // col: 6 offset: 0010
            ShortCommand = parser.ReadOffset< string >( 0x10 );

            // col: 11 offset: 0014
            unknown14 = parser.ReadOffset< uint >( 0x14 );

            // col: 10 offset: 0018
            unknown18 = parser.ReadOffset< ushort >( 0x18 );

            // col: 0 offset: 001a
            unknown1a = parser.ReadOffset< byte >( 0x1a );

            // col: 1 offset: 001b
            unknown1b = parser.ReadOffset< byte >( 0x1b );

            // col: 2 offset: 001c
            unknown1c = parser.ReadOffset< sbyte >( 0x1c );

            // col: 3 offset: 001d
            unknown1d = parser.ReadOffset< sbyte >( 0x1d );

            // col: 4 offset: 001e
            unknown1e = parser.ReadOffset< sbyte >( 0x1e );


        }
    }
}