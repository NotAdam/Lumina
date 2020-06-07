using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EObj", columnHash: 0x9335c666 )]
    public class EObj : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 09 offset: 0000
        public uint Data;

        // col: 11 offset: 0004
        public ushort SgbPath;

        // col: 08 offset: 0006
        public byte PopType;

        // col: 10 offset: 0007
        public byte Invisibility;

        // col: 15 offset: 0008
        public byte EventHighAddition;

        // col: 17 offset: 0009
        public byte unknown9;

        // col: 00 offset: 000a
        public bool unknowna;

        // col: 01 offset: 000b
        public bool unknownb;

        // col: 02 offset: 000c
        public bool unknownc;

        // col: 03 offset: 000d
        public bool unknownd;

        // col: 04 offset: 000e
        public bool unknowne;

        // col: 05 offset: 000f
        public bool unknownf;

        // col: 06 offset: 0010
        public bool unknown10;

        // col: 07 offset: 0011
        public bool unknown11;

        // col: 12 offset: 0012
        public bool EyeCollision;
        public byte packed12;
        public bool DirectorControl;
        public bool Target;
        public bool packed12_8;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 9 offset: 0000
            Data = parser.ReadOffset< uint >( 0x0 );

            // col: 11 offset: 0004
            SgbPath = parser.ReadOffset< ushort >( 0x4 );

            // col: 8 offset: 0006
            PopType = parser.ReadOffset< byte >( 0x6 );

            // col: 10 offset: 0007
            Invisibility = parser.ReadOffset< byte >( 0x7 );

            // col: 15 offset: 0008
            EventHighAddition = parser.ReadOffset< byte >( 0x8 );

            // col: 17 offset: 0009
            unknown9 = parser.ReadOffset< byte >( 0x9 );

            // col: 0 offset: 000a
            unknowna = parser.ReadOffset< bool >( 0xa );

            // col: 1 offset: 000b
            unknownb = parser.ReadOffset< bool >( 0xb );

            // col: 2 offset: 000c
            unknownc = parser.ReadOffset< bool >( 0xc );

            // col: 3 offset: 000d
            unknownd = parser.ReadOffset< bool >( 0xd );

            // col: 4 offset: 000e
            unknowne = parser.ReadOffset< bool >( 0xe );

            // col: 5 offset: 000f
            unknownf = parser.ReadOffset< bool >( 0xf );

            // col: 6 offset: 0010
            unknown10 = parser.ReadOffset< bool >( 0x10 );

            // col: 7 offset: 0011
            unknown11 = parser.ReadOffset< bool >( 0x11 );

            // col: 12 offset: 0012
            packed12 = parser.ReadOffset< byte >( 0x12, ExcelColumnDataType.UInt8 );

            EyeCollision = ( packed12 & 0x1 ) == 0x1;
            DirectorControl = ( packed12 & 0x2 ) == 0x2;
            Target = ( packed12 & 0x4 ) == 0x4;
            packed12_8 = ( packed12 & 0x8 ) == 0x8;


        }
    }
}