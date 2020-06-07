using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MountCustomize", columnHash: 0x82bd7e3f )]
    public class MountCustomize : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public ushort HyurMaleScale;

        // col: 02 offset: 0002
        public ushort HyurFemaleScale;

        // col: 03 offset: 0004
        public ushort ElezenMaleScale;

        // col: 04 offset: 0006
        public ushort ElezenFemaleScale;

        // col: 05 offset: 0008
        public ushort LalaMaleScale;

        // col: 06 offset: 000a
        public ushort LalaFemaleScale;

        // col: 07 offset: 000c
        public ushort MiqoMaleScale;

        // col: 08 offset: 000e
        public ushort MiqoFemaleScale;

        // col: 09 offset: 0010
        public ushort RoeMaleScale;

        // col: 10 offset: 0012
        public ushort RoeFemaleScale;

        // col: 11 offset: 0014
        public ushort AuRaMaleScale;

        // col: 12 offset: 0016
        public ushort AuRaFemaleScale;

        // col: 13 offset: 0018
        public ushort HrothgarMaleScale;

        // col: 14 offset: 001a
        public ushort HrothgarFemaleScale;

        // col: 15 offset: 001c
        public ushort VieraMaleScale;

        // col: 16 offset: 001e
        public ushort VieraFemaleScale;

        // col: 17 offset: 0020
        public byte HyurMaleCameraHeight;

        // col: 18 offset: 0021
        public byte HyurFemaleCameraHeight;

        // col: 19 offset: 0022
        public byte ElezenMaleCameraHeight;

        // col: 20 offset: 0023
        public byte ElezenFemaleCameraHeight;

        // col: 21 offset: 0024
        public byte LalaMaleCameraHeight;

        // col: 22 offset: 0025
        public byte LalaFemaleCameraHeight;

        // col: 23 offset: 0026
        public byte MiqoMaleCameraHeight;

        // col: 24 offset: 0027
        public byte MiqoFemaleCameraHeight;

        // col: 25 offset: 0028
        public byte RoeMaleCameraHeight;

        // col: 26 offset: 0029
        public byte RoeFemaleCameraHeight;

        // col: 27 offset: 002a
        public byte AuRaMaleCameraHeight;

        // col: 28 offset: 002b
        public byte AuRaFemaleCameraHeight;

        // col: 29 offset: 002c
        public byte HrothgarMaleCameraHeight;

        // col: 30 offset: 002d
        public byte HrothgarRoeFemaleCameraHeight;

        // col: 31 offset: 002e
        public byte VieraMaleCameraHeight;

        // col: 32 offset: 002f
        public byte VieraFemaleCameraHeight;

        // col: 00 offset: 0030
        public bool packed30_1;
        public byte packed30;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            HyurMaleScale = parser.ReadOffset< ushort >( 0x0 );

            // col: 2 offset: 0002
            HyurFemaleScale = parser.ReadOffset< ushort >( 0x2 );

            // col: 3 offset: 0004
            ElezenMaleScale = parser.ReadOffset< ushort >( 0x4 );

            // col: 4 offset: 0006
            ElezenFemaleScale = parser.ReadOffset< ushort >( 0x6 );

            // col: 5 offset: 0008
            LalaMaleScale = parser.ReadOffset< ushort >( 0x8 );

            // col: 6 offset: 000a
            LalaFemaleScale = parser.ReadOffset< ushort >( 0xa );

            // col: 7 offset: 000c
            MiqoMaleScale = parser.ReadOffset< ushort >( 0xc );

            // col: 8 offset: 000e
            MiqoFemaleScale = parser.ReadOffset< ushort >( 0xe );

            // col: 9 offset: 0010
            RoeMaleScale = parser.ReadOffset< ushort >( 0x10 );

            // col: 10 offset: 0012
            RoeFemaleScale = parser.ReadOffset< ushort >( 0x12 );

            // col: 11 offset: 0014
            AuRaMaleScale = parser.ReadOffset< ushort >( 0x14 );

            // col: 12 offset: 0016
            AuRaFemaleScale = parser.ReadOffset< ushort >( 0x16 );

            // col: 13 offset: 0018
            HrothgarMaleScale = parser.ReadOffset< ushort >( 0x18 );

            // col: 14 offset: 001a
            HrothgarFemaleScale = parser.ReadOffset< ushort >( 0x1a );

            // col: 15 offset: 001c
            VieraMaleScale = parser.ReadOffset< ushort >( 0x1c );

            // col: 16 offset: 001e
            VieraFemaleScale = parser.ReadOffset< ushort >( 0x1e );

            // col: 17 offset: 0020
            HyurMaleCameraHeight = parser.ReadOffset< byte >( 0x20 );

            // col: 18 offset: 0021
            HyurFemaleCameraHeight = parser.ReadOffset< byte >( 0x21 );

            // col: 19 offset: 0022
            ElezenMaleCameraHeight = parser.ReadOffset< byte >( 0x22 );

            // col: 20 offset: 0023
            ElezenFemaleCameraHeight = parser.ReadOffset< byte >( 0x23 );

            // col: 21 offset: 0024
            LalaMaleCameraHeight = parser.ReadOffset< byte >( 0x24 );

            // col: 22 offset: 0025
            LalaFemaleCameraHeight = parser.ReadOffset< byte >( 0x25 );

            // col: 23 offset: 0026
            MiqoMaleCameraHeight = parser.ReadOffset< byte >( 0x26 );

            // col: 24 offset: 0027
            MiqoFemaleCameraHeight = parser.ReadOffset< byte >( 0x27 );

            // col: 25 offset: 0028
            RoeMaleCameraHeight = parser.ReadOffset< byte >( 0x28 );

            // col: 26 offset: 0029
            RoeFemaleCameraHeight = parser.ReadOffset< byte >( 0x29 );

            // col: 27 offset: 002a
            AuRaMaleCameraHeight = parser.ReadOffset< byte >( 0x2a );

            // col: 28 offset: 002b
            AuRaFemaleCameraHeight = parser.ReadOffset< byte >( 0x2b );

            // col: 29 offset: 002c
            HrothgarMaleCameraHeight = parser.ReadOffset< byte >( 0x2c );

            // col: 30 offset: 002d
            HrothgarRoeFemaleCameraHeight = parser.ReadOffset< byte >( 0x2d );

            // col: 31 offset: 002e
            VieraMaleCameraHeight = parser.ReadOffset< byte >( 0x2e );

            // col: 32 offset: 002f
            VieraFemaleCameraHeight = parser.ReadOffset< byte >( 0x2f );

            // col: 0 offset: 0030
            packed30 = parser.ReadOffset< byte >( 0x30, ExcelColumnDataType.UInt8 );

            packed30_1 = ( packed30 & 0x1 ) == 0x1;


        }
    }
}