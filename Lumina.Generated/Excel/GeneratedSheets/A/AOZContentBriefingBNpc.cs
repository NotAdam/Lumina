using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AOZContentBriefingBNpc", columnHash: 0xfc0810d7 )]
    public class AOZContentBriefingBNpc : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public uint BNpcName;

        // col: 01 offset: 0004
        public uint TargetSmall;

        // col: 02 offset: 0008
        public uint TargetLarge;

        // col: 04 offset: 000c
        public byte Endurance;

        // col: 05 offset: 000d
        public byte Fire;

        // col: 06 offset: 000e
        public byte Ice;

        // col: 07 offset: 000f
        public byte Wind;

        // col: 08 offset: 0010
        public byte Earth;

        // col: 09 offset: 0011
        public byte Thunder;

        // col: 10 offset: 0012
        public byte Water;

        // col: 11 offset: 0013
        public byte Slashing;

        // col: 12 offset: 0014
        public byte Piercing;

        // col: 13 offset: 0015
        public byte Blunt;

        // col: 14 offset: 0016
        public byte Magic;

        // col: 03 offset: 0017
        public bool packed17_1;
        public byte packed17;
        public bool SlowResistance;
        public bool PetrificationResistance;
        public bool ParalysisResistance;
        public bool SilenceResistance;
        public bool BlindResistance;
        public bool StunResistance;
        public bool SleepResistance;

        // col: 22 offset: 0018
        public bool BindResistance;
        public byte packed18;
        public bool HeavyResistance;
        public bool InstaDeathResistance;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            BNpcName = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            TargetSmall = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            TargetLarge = parser.ReadOffset< uint >( 0x8 );

            // col: 4 offset: 000c
            Endurance = parser.ReadOffset< byte >( 0xc );

            // col: 5 offset: 000d
            Fire = parser.ReadOffset< byte >( 0xd );

            // col: 6 offset: 000e
            Ice = parser.ReadOffset< byte >( 0xe );

            // col: 7 offset: 000f
            Wind = parser.ReadOffset< byte >( 0xf );

            // col: 8 offset: 0010
            Earth = parser.ReadOffset< byte >( 0x10 );

            // col: 9 offset: 0011
            Thunder = parser.ReadOffset< byte >( 0x11 );

            // col: 10 offset: 0012
            Water = parser.ReadOffset< byte >( 0x12 );

            // col: 11 offset: 0013
            Slashing = parser.ReadOffset< byte >( 0x13 );

            // col: 12 offset: 0014
            Piercing = parser.ReadOffset< byte >( 0x14 );

            // col: 13 offset: 0015
            Blunt = parser.ReadOffset< byte >( 0x15 );

            // col: 14 offset: 0016
            Magic = parser.ReadOffset< byte >( 0x16 );

            // col: 3 offset: 0017
            packed17 = parser.ReadOffset< byte >( 0x17, ExcelColumnDataType.UInt8 );

            packed17_1 = ( packed17 & 0x1 ) == 0x1;
            SlowResistance = ( packed17 & 0x2 ) == 0x2;
            PetrificationResistance = ( packed17 & 0x4 ) == 0x4;
            ParalysisResistance = ( packed17 & 0x8 ) == 0x8;
            SilenceResistance = ( packed17 & 0x10 ) == 0x10;
            BlindResistance = ( packed17 & 0x20 ) == 0x20;
            StunResistance = ( packed17 & 0x40 ) == 0x40;
            SleepResistance = ( packed17 & 0x80 ) == 0x80;

            // col: 22 offset: 0018
            packed18 = parser.ReadOffset< byte >( 0x18, ExcelColumnDataType.UInt8 );

            BindResistance = ( packed18 & 0x1 ) == 0x1;
            HeavyResistance = ( packed18 & 0x2 ) == 0x2;
            InstaDeathResistance = ( packed18 & 0x4 ) == 0x4;


        }
    }
}