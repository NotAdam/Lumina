using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SubmarineExploration", columnHash: 0xff922bb4 )]
    public class SubmarineExploration : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Destination;

        // col: 01 offset: 0004
        public string Location;

        // col: 12 offset: 0008
        public uint ExpReward;

        // col: 10 offset: 000c
        public ushort Durationmin;

        // col: 02 offset: 000e
        public short unknowne;

        // col: 03 offset: 0010
        public short unknown10;

        // col: 04 offset: 0012
        public short unknown12;

        // col: 05 offset: 0014
        public byte unknown14;

        // col: 07 offset: 0015
        public byte unknown15;

        // col: 08 offset: 0016
        public byte RankReq;

        // col: 09 offset: 0017
        public byte CeruleumTankReq;

        // col: 11 offset: 0018
        public byte DistanceForSurvey;

        // col: 06 offset: 0019
        public bool packed19_1;
        public byte packed19;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Destination = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Location = parser.ReadOffset< string >( 0x4 );

            // col: 12 offset: 0008
            ExpReward = parser.ReadOffset< uint >( 0x8 );

            // col: 10 offset: 000c
            Durationmin = parser.ReadOffset< ushort >( 0xc );

            // col: 2 offset: 000e
            unknowne = parser.ReadOffset< short >( 0xe );

            // col: 3 offset: 0010
            unknown10 = parser.ReadOffset< short >( 0x10 );

            // col: 4 offset: 0012
            unknown12 = parser.ReadOffset< short >( 0x12 );

            // col: 5 offset: 0014
            unknown14 = parser.ReadOffset< byte >( 0x14 );

            // col: 7 offset: 0015
            unknown15 = parser.ReadOffset< byte >( 0x15 );

            // col: 8 offset: 0016
            RankReq = parser.ReadOffset< byte >( 0x16 );

            // col: 9 offset: 0017
            CeruleumTankReq = parser.ReadOffset< byte >( 0x17 );

            // col: 11 offset: 0018
            DistanceForSurvey = parser.ReadOffset< byte >( 0x18 );

            // col: 6 offset: 0019
            packed19 = parser.ReadOffset< byte >( 0x19, ExcelColumnDataType.UInt8 );

            packed19_1 = ( packed19 & 0x1 ) == 0x1;


        }
    }
}