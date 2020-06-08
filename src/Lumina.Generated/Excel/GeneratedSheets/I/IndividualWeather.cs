using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IndividualWeather", columnHash: 0x1012bc70 )]
    public class IndividualWeather : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 10 offset: 0000
        public uint[] Quest;

        // col: 15 offset: 0004
        public uint unknown4;

        // col: 00 offset: 0008
        public byte[] Weather;

        // col: 05 offset: 0009
        public byte unknown9;

        // col: 16 offset: 0010
        public uint unknown10;

        // col: 06 offset: 0015
        public byte unknown15;

        // col: 17 offset: 001c
        public uint unknown1c;

        // col: 07 offset: 0021
        public byte unknown21;

        // col: 18 offset: 0028
        public uint unknown28;

        // col: 08 offset: 002d
        public byte unknown2d;

        // col: 19 offset: 0034
        public uint unknown34;

        // col: 09 offset: 0039
        public byte unknown39;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 10 offset: 0000
            Quest = new uint[5];
            Quest[0] = parser.ReadOffset< uint >( 0x0 );
            Quest[1] = parser.ReadOffset< uint >( 0xc );
            Quest[2] = parser.ReadOffset< uint >( 0x18 );
            Quest[3] = parser.ReadOffset< uint >( 0x24 );
            Quest[4] = parser.ReadOffset< uint >( 0x30 );

            // col: 15 offset: 0004
            unknown4 = parser.ReadOffset< uint >( 0x4 );

            // col: 0 offset: 0008
            Weather = new byte[5];
            Weather[0] = parser.ReadOffset< byte >( 0x8 );
            Weather[1] = parser.ReadOffset< byte >( 0x14 );
            Weather[2] = parser.ReadOffset< byte >( 0x20 );
            Weather[3] = parser.ReadOffset< byte >( 0x2c );
            Weather[4] = parser.ReadOffset< byte >( 0x38 );

            // col: 5 offset: 0009
            unknown9 = parser.ReadOffset< byte >( 0x9 );

            // col: 16 offset: 0010
            unknown10 = parser.ReadOffset< uint >( 0x10 );

            // col: 6 offset: 0015
            unknown15 = parser.ReadOffset< byte >( 0x15 );

            // col: 17 offset: 001c
            unknown1c = parser.ReadOffset< uint >( 0x1c );

            // col: 7 offset: 0021
            unknown21 = parser.ReadOffset< byte >( 0x21 );

            // col: 18 offset: 0028
            unknown28 = parser.ReadOffset< uint >( 0x28 );

            // col: 8 offset: 002d
            unknown2d = parser.ReadOffset< byte >( 0x2d );

            // col: 19 offset: 0034
            unknown34 = parser.ReadOffset< uint >( 0x34 );

            // col: 9 offset: 0039
            unknown39 = parser.ReadOffset< byte >( 0x39 );


        }
    }
}