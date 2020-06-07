using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CustomTalk", columnHash: 0x74541fa8 )]
    public class CustomTalk : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 03 offset: 0000
        public string[] ScriptInstruction;

        // col: 33 offset: 0004
        public uint[] ScriptArg;

        // col: 64 offset: 00f0
        public string unknownf0;

        // col: 65 offset: 00f4
        public string unknownf4;

        // col: 02 offset: 00f8
        public string Name;

        // col: 00 offset: 00fc
        public uint IconActor;

        // col: 01 offset: 0100
        public uint IconMap;

        // col: 75 offset: 0104
        public uint unknown104;

        // col: 76 offset: 0108
        public byte unknown108;

        // col: 63 offset: 0109
        public bool packed109_1;
        public byte packed109;
        public bool Text;
        public bool packed109_4;
        public bool packed109_8;
        public bool packed109_10;
        public bool packed109_20;
        public bool packed109_40;
        public bool packed109_80;

        // col: 73 offset: 010a
        public bool packed10a_1;
        public byte packed10a;
        public bool packed10a_2;
        public bool packed10a_4;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 3 offset: 0000
            ScriptInstruction = new string[30];
            ScriptInstruction[0] = parser.ReadOffset< string >( 0x0 );
            ScriptInstruction[1] = parser.ReadOffset< string >( 0x8 );
            ScriptInstruction[2] = parser.ReadOffset< string >( 0x10 );
            ScriptInstruction[3] = parser.ReadOffset< string >( 0x18 );
            ScriptInstruction[4] = parser.ReadOffset< string >( 0x20 );
            ScriptInstruction[5] = parser.ReadOffset< string >( 0x28 );
            ScriptInstruction[6] = parser.ReadOffset< string >( 0x30 );
            ScriptInstruction[7] = parser.ReadOffset< string >( 0x38 );
            ScriptInstruction[8] = parser.ReadOffset< string >( 0x40 );
            ScriptInstruction[9] = parser.ReadOffset< string >( 0x48 );
            ScriptInstruction[10] = parser.ReadOffset< string >( 0x50 );
            ScriptInstruction[11] = parser.ReadOffset< string >( 0x58 );
            ScriptInstruction[12] = parser.ReadOffset< string >( 0x60 );
            ScriptInstruction[13] = parser.ReadOffset< string >( 0x68 );
            ScriptInstruction[14] = parser.ReadOffset< string >( 0x70 );
            ScriptInstruction[15] = parser.ReadOffset< string >( 0x78 );
            ScriptInstruction[16] = parser.ReadOffset< string >( 0x80 );
            ScriptInstruction[17] = parser.ReadOffset< string >( 0x88 );
            ScriptInstruction[18] = parser.ReadOffset< string >( 0x90 );
            ScriptInstruction[19] = parser.ReadOffset< string >( 0x98 );
            ScriptInstruction[20] = parser.ReadOffset< string >( 0xa0 );
            ScriptInstruction[21] = parser.ReadOffset< string >( 0xa8 );
            ScriptInstruction[22] = parser.ReadOffset< string >( 0xb0 );
            ScriptInstruction[23] = parser.ReadOffset< string >( 0xb8 );
            ScriptInstruction[24] = parser.ReadOffset< string >( 0xc0 );
            ScriptInstruction[25] = parser.ReadOffset< string >( 0xc8 );
            ScriptInstruction[26] = parser.ReadOffset< string >( 0xd0 );
            ScriptInstruction[27] = parser.ReadOffset< string >( 0xd8 );
            ScriptInstruction[28] = parser.ReadOffset< string >( 0xe0 );
            ScriptInstruction[29] = parser.ReadOffset< string >( 0xe8 );

            // col: 33 offset: 0004
            ScriptArg = new uint[30];
            ScriptArg[0] = parser.ReadOffset< uint >( 0x4 );
            ScriptArg[1] = parser.ReadOffset< uint >( 0xc );
            ScriptArg[2] = parser.ReadOffset< uint >( 0x14 );
            ScriptArg[3] = parser.ReadOffset< uint >( 0x1c );
            ScriptArg[4] = parser.ReadOffset< uint >( 0x24 );
            ScriptArg[5] = parser.ReadOffset< uint >( 0x2c );
            ScriptArg[6] = parser.ReadOffset< uint >( 0x34 );
            ScriptArg[7] = parser.ReadOffset< uint >( 0x3c );
            ScriptArg[8] = parser.ReadOffset< uint >( 0x44 );
            ScriptArg[9] = parser.ReadOffset< uint >( 0x4c );
            ScriptArg[10] = parser.ReadOffset< uint >( 0x54 );
            ScriptArg[11] = parser.ReadOffset< uint >( 0x5c );
            ScriptArg[12] = parser.ReadOffset< uint >( 0x64 );
            ScriptArg[13] = parser.ReadOffset< uint >( 0x6c );
            ScriptArg[14] = parser.ReadOffset< uint >( 0x74 );
            ScriptArg[15] = parser.ReadOffset< uint >( 0x7c );
            ScriptArg[16] = parser.ReadOffset< uint >( 0x84 );
            ScriptArg[17] = parser.ReadOffset< uint >( 0x8c );
            ScriptArg[18] = parser.ReadOffset< uint >( 0x94 );
            ScriptArg[19] = parser.ReadOffset< uint >( 0x9c );
            ScriptArg[20] = parser.ReadOffset< uint >( 0xa4 );
            ScriptArg[21] = parser.ReadOffset< uint >( 0xac );
            ScriptArg[22] = parser.ReadOffset< uint >( 0xb4 );
            ScriptArg[23] = parser.ReadOffset< uint >( 0xbc );
            ScriptArg[24] = parser.ReadOffset< uint >( 0xc4 );
            ScriptArg[25] = parser.ReadOffset< uint >( 0xcc );
            ScriptArg[26] = parser.ReadOffset< uint >( 0xd4 );
            ScriptArg[27] = parser.ReadOffset< uint >( 0xdc );
            ScriptArg[28] = parser.ReadOffset< uint >( 0xe4 );
            ScriptArg[29] = parser.ReadOffset< uint >( 0xec );

            // col: 64 offset: 00f0
            unknownf0 = parser.ReadOffset< string >( 0xf0 );

            // col: 65 offset: 00f4
            unknownf4 = parser.ReadOffset< string >( 0xf4 );

            // col: 2 offset: 00f8
            Name = parser.ReadOffset< string >( 0xf8 );

            // col: 0 offset: 00fc
            IconActor = parser.ReadOffset< uint >( 0xfc );

            // col: 1 offset: 0100
            IconMap = parser.ReadOffset< uint >( 0x100 );

            // col: 75 offset: 0104
            unknown104 = parser.ReadOffset< uint >( 0x104 );

            // col: 76 offset: 0108
            unknown108 = parser.ReadOffset< byte >( 0x108 );

            // col: 63 offset: 0109
            packed109 = parser.ReadOffset< byte >( 0x109, ExcelColumnDataType.UInt8 );

            packed109_1 = ( packed109 & 0x1 ) == 0x1;
            Text = ( packed109 & 0x2 ) == 0x2;
            packed109_4 = ( packed109 & 0x4 ) == 0x4;
            packed109_8 = ( packed109 & 0x8 ) == 0x8;
            packed109_10 = ( packed109 & 0x10 ) == 0x10;
            packed109_20 = ( packed109 & 0x20 ) == 0x20;
            packed109_40 = ( packed109 & 0x40 ) == 0x40;
            packed109_80 = ( packed109 & 0x80 ) == 0x80;

            // col: 73 offset: 010a
            packed10a = parser.ReadOffset< byte >( 0x10a, ExcelColumnDataType.UInt8 );

            packed10a_1 = ( packed10a & 0x1 ) == 0x1;
            packed10a_2 = ( packed10a & 0x2 ) == 0x2;
            packed10a_4 = ( packed10a & 0x4 ) == 0x4;


        }
    }
}