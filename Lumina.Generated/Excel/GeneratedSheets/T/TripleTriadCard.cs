using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TripleTriadCard", columnHash: 0x45c06ae0 )]
    public class TripleTriadCard : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 02 offset: 0004
        public string unknown4;

        // col: 08 offset: 0008
        public string Description;

        // col: 01 offset: 000c
        public sbyte unknownc;

        // col: 03 offset: 000d
        public sbyte unknownd;

        // col: 04 offset: 000e
        public sbyte StartsWithVowel;

        // col: 05 offset: 000f
        public sbyte unknownf;

        // col: 06 offset: 0010
        public sbyte unknown10;

        // col: 07 offset: 0011
        public sbyte unknown11;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            unknown4 = parser.ReadOffset< string >( 0x4 );

            // col: 8 offset: 0008
            Description = parser.ReadOffset< string >( 0x8 );

            // col: 1 offset: 000c
            unknownc = parser.ReadOffset< sbyte >( 0xc );

            // col: 3 offset: 000d
            unknownd = parser.ReadOffset< sbyte >( 0xd );

            // col: 4 offset: 000e
            StartsWithVowel = parser.ReadOffset< sbyte >( 0xe );

            // col: 5 offset: 000f
            unknownf = parser.ReadOffset< sbyte >( 0xf );

            // col: 6 offset: 0010
            unknown10 = parser.ReadOffset< sbyte >( 0x10 );

            // col: 7 offset: 0011
            unknown11 = parser.ReadOffset< sbyte >( 0x11 );


        }
    }
}