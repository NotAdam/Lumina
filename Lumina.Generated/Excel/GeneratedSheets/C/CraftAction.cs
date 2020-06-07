using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CraftAction", columnHash: 0x6057073b )]
    public class CraftAction : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public string Description;

        // col: 08 offset: 0008
        public uint QuestRequirement;

        // col: 12 offset: 000c
        public int CRP;

        // col: 13 offset: 0010
        public int BSM;

        // col: 14 offset: 0014
        public int ARM;

        // col: 15 offset: 0018
        public int GSM;

        // col: 16 offset: 001c
        public int LTW;

        // col: 17 offset: 0020
        public int WVR;

        // col: 18 offset: 0024
        public int ALC;

        // col: 19 offset: 0028
        public int CUL;

        // col: 02 offset: 002c
        public ushort AnimationStart;

        // col: 03 offset: 002e
        public ushort AnimationEnd;

        // col: 04 offset: 0030
        public ushort Icon;

        // col: 10 offset: 0032
        public ushort unknown32;

        // col: 06 offset: 0034
        public byte ClassJobCategory;

        // col: 07 offset: 0035
        public byte ClassJobLevel;

        // col: 11 offset: 0036
        public byte Cost;

        // col: 05 offset: 0037
        public sbyte ClassJob;

        // col: 09 offset: 0038
        public bool Specialist;
        public byte packed38;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Description = parser.ReadOffset< string >( 0x4 );

            // col: 8 offset: 0008
            QuestRequirement = parser.ReadOffset< uint >( 0x8 );

            // col: 12 offset: 000c
            CRP = parser.ReadOffset< int >( 0xc );

            // col: 13 offset: 0010
            BSM = parser.ReadOffset< int >( 0x10 );

            // col: 14 offset: 0014
            ARM = parser.ReadOffset< int >( 0x14 );

            // col: 15 offset: 0018
            GSM = parser.ReadOffset< int >( 0x18 );

            // col: 16 offset: 001c
            LTW = parser.ReadOffset< int >( 0x1c );

            // col: 17 offset: 0020
            WVR = parser.ReadOffset< int >( 0x20 );

            // col: 18 offset: 0024
            ALC = parser.ReadOffset< int >( 0x24 );

            // col: 19 offset: 0028
            CUL = parser.ReadOffset< int >( 0x28 );

            // col: 2 offset: 002c
            AnimationStart = parser.ReadOffset< ushort >( 0x2c );

            // col: 3 offset: 002e
            AnimationEnd = parser.ReadOffset< ushort >( 0x2e );

            // col: 4 offset: 0030
            Icon = parser.ReadOffset< ushort >( 0x30 );

            // col: 10 offset: 0032
            unknown32 = parser.ReadOffset< ushort >( 0x32 );

            // col: 6 offset: 0034
            ClassJobCategory = parser.ReadOffset< byte >( 0x34 );

            // col: 7 offset: 0035
            ClassJobLevel = parser.ReadOffset< byte >( 0x35 );

            // col: 11 offset: 0036
            Cost = parser.ReadOffset< byte >( 0x36 );

            // col: 5 offset: 0037
            ClassJob = parser.ReadOffset< sbyte >( 0x37 );

            // col: 9 offset: 0038
            packed38 = parser.ReadOffset< byte >( 0x38, ExcelColumnDataType.UInt8 );

            Specialist = ( packed38 & 0x1 ) == 0x1;


        }
    }
}