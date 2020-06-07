using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SkyIsland2MissionDetail", columnHash: 0x62246edb )]
    public class SkyIsland2MissionDetail : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 07 offset: 0000
        public string Objective;

        // col: 08 offset: 0004
        public string unknown4;

        // col: 09 offset: 0008
        public string unknown8;

        // col: 10 offset: 000c
        public string unknownc;

        // col: 04 offset: 0010
        public uint EObj;

        // col: 05 offset: 0014
        public uint unknown14;

        // col: 06 offset: 0018
        public uint unknown18;

        // col: 00 offset: 001c
        public byte Type;

        // col: 01 offset: 001d
        public byte unknown1d;

        // col: 02 offset: 001e
        public byte Range;

        // col: 03 offset: 001f
        public sbyte unknown1f;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 7 offset: 0000
            Objective = parser.ReadOffset< string >( 0x0 );

            // col: 8 offset: 0004
            unknown4 = parser.ReadOffset< string >( 0x4 );

            // col: 9 offset: 0008
            unknown8 = parser.ReadOffset< string >( 0x8 );

            // col: 10 offset: 000c
            unknownc = parser.ReadOffset< string >( 0xc );

            // col: 4 offset: 0010
            EObj = parser.ReadOffset< uint >( 0x10 );

            // col: 5 offset: 0014
            unknown14 = parser.ReadOffset< uint >( 0x14 );

            // col: 6 offset: 0018
            unknown18 = parser.ReadOffset< uint >( 0x18 );

            // col: 0 offset: 001c
            Type = parser.ReadOffset< byte >( 0x1c );

            // col: 1 offset: 001d
            unknown1d = parser.ReadOffset< byte >( 0x1d );

            // col: 2 offset: 001e
            Range = parser.ReadOffset< byte >( 0x1e );

            // col: 3 offset: 001f
            unknown1f = parser.ReadOffset< sbyte >( 0x1f );


        }
    }
}