using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AirshipExplorationPoint", columnHash: 0x307f38a2 )]
    public class AirshipExplorationPoint : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public string NameShort;

        // col: 13 offset: 0008
        public uint ExpReward;

        // col: 06 offset: 000c
        public ushort RequiredFuel;

        // col: 07 offset: 000e
        public ushort Durationmin;

        // col: 08 offset: 0010
        public ushort unknown10;

        // col: 03 offset: 0012
        public short unknown12;

        // col: 04 offset: 0014
        public short unknown14;

        // col: 05 offset: 0016
        public byte RequiredLevel;

        // col: 09 offset: 0017
        public byte unknown17;

        // col: 11 offset: 0018
        public byte unknown18;

        // col: 10 offset: 0019
        public byte RequiredSurveillance;

        // col: 12 offset: 001a
        public byte unknown1a;

        // col: 02 offset: 001b
        public bool packed1b_1;
        public byte packed1b;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            NameShort = parser.ReadOffset< string >( 0x4 );

            // col: 13 offset: 0008
            ExpReward = parser.ReadOffset< uint >( 0x8 );

            // col: 6 offset: 000c
            RequiredFuel = parser.ReadOffset< ushort >( 0xc );

            // col: 7 offset: 000e
            Durationmin = parser.ReadOffset< ushort >( 0xe );

            // col: 8 offset: 0010
            unknown10 = parser.ReadOffset< ushort >( 0x10 );

            // col: 3 offset: 0012
            unknown12 = parser.ReadOffset< short >( 0x12 );

            // col: 4 offset: 0014
            unknown14 = parser.ReadOffset< short >( 0x14 );

            // col: 5 offset: 0016
            RequiredLevel = parser.ReadOffset< byte >( 0x16 );

            // col: 9 offset: 0017
            unknown17 = parser.ReadOffset< byte >( 0x17 );

            // col: 11 offset: 0018
            unknown18 = parser.ReadOffset< byte >( 0x18 );

            // col: 10 offset: 0019
            RequiredSurveillance = parser.ReadOffset< byte >( 0x19 );

            // col: 12 offset: 001a
            unknown1a = parser.ReadOffset< byte >( 0x1a );

            // col: 2 offset: 001b
            packed1b = parser.ReadOffset< byte >( 0x1b, ExcelColumnDataType.UInt8 );

            packed1b_1 = ( packed1b & 0x1 ) == 0x1;


        }
    }
}