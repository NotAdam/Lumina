using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ClassJobCategory", columnHash: 0xd6e993c1 )]
    public class ClassJobCategory : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public bool ADV;

        // col: 02 offset: 0005
        public bool GLA;

        // col: 03 offset: 0006
        public bool PGL;

        // col: 04 offset: 0007
        public bool MRD;

        // col: 05 offset: 0008
        public bool LNC;

        // col: 06 offset: 0009
        public bool ARC;

        // col: 07 offset: 000a
        public bool CNJ;

        // col: 08 offset: 000b
        public bool THM;

        // col: 09 offset: 000c
        public bool CRP;

        // col: 10 offset: 000d
        public bool BSM;

        // col: 11 offset: 000e
        public bool ARM;

        // col: 12 offset: 000f
        public bool GSM;

        // col: 13 offset: 0010
        public bool LTW;

        // col: 14 offset: 0011
        public bool WVR;

        // col: 15 offset: 0012
        public bool ALC;

        // col: 16 offset: 0013
        public bool CUL;

        // col: 17 offset: 0014
        public bool MIN;

        // col: 18 offset: 0015
        public bool BTN;

        // col: 19 offset: 0016
        public bool FSH;

        // col: 20 offset: 0017
        public bool PLD;

        // col: 21 offset: 0018
        public bool MNK;

        // col: 22 offset: 0019
        public bool WAR;

        // col: 23 offset: 001a
        public bool DRG;

        // col: 24 offset: 001b
        public bool BRD;

        // col: 25 offset: 001c
        public bool WHM;

        // col: 26 offset: 001d
        public bool BLM;

        // col: 27 offset: 001e
        public bool ACN;

        // col: 28 offset: 001f
        public bool SMN;

        // col: 29 offset: 0020
        public bool SCH;

        // col: 30 offset: 0021
        public bool ROG;

        // col: 31 offset: 0022
        public bool NIN;

        // col: 32 offset: 0023
        public bool MCH;

        // col: 33 offset: 0024
        public bool DRK;

        // col: 34 offset: 0025
        public bool AST;

        // col: 35 offset: 0026
        public bool SAM;

        // col: 36 offset: 0027
        public bool RDM;

        // col: 37 offset: 0028
        public bool BLU;

        // col: 38 offset: 0029
        public bool GNB;

        // col: 39 offset: 002a
        public bool DNC;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            ADV = parser.ReadOffset< bool >( 0x4 );

            // col: 2 offset: 0005
            GLA = parser.ReadOffset< bool >( 0x5 );

            // col: 3 offset: 0006
            PGL = parser.ReadOffset< bool >( 0x6 );

            // col: 4 offset: 0007
            MRD = parser.ReadOffset< bool >( 0x7 );

            // col: 5 offset: 0008
            LNC = parser.ReadOffset< bool >( 0x8 );

            // col: 6 offset: 0009
            ARC = parser.ReadOffset< bool >( 0x9 );

            // col: 7 offset: 000a
            CNJ = parser.ReadOffset< bool >( 0xa );

            // col: 8 offset: 000b
            THM = parser.ReadOffset< bool >( 0xb );

            // col: 9 offset: 000c
            CRP = parser.ReadOffset< bool >( 0xc );

            // col: 10 offset: 000d
            BSM = parser.ReadOffset< bool >( 0xd );

            // col: 11 offset: 000e
            ARM = parser.ReadOffset< bool >( 0xe );

            // col: 12 offset: 000f
            GSM = parser.ReadOffset< bool >( 0xf );

            // col: 13 offset: 0010
            LTW = parser.ReadOffset< bool >( 0x10 );

            // col: 14 offset: 0011
            WVR = parser.ReadOffset< bool >( 0x11 );

            // col: 15 offset: 0012
            ALC = parser.ReadOffset< bool >( 0x12 );

            // col: 16 offset: 0013
            CUL = parser.ReadOffset< bool >( 0x13 );

            // col: 17 offset: 0014
            MIN = parser.ReadOffset< bool >( 0x14 );

            // col: 18 offset: 0015
            BTN = parser.ReadOffset< bool >( 0x15 );

            // col: 19 offset: 0016
            FSH = parser.ReadOffset< bool >( 0x16 );

            // col: 20 offset: 0017
            PLD = parser.ReadOffset< bool >( 0x17 );

            // col: 21 offset: 0018
            MNK = parser.ReadOffset< bool >( 0x18 );

            // col: 22 offset: 0019
            WAR = parser.ReadOffset< bool >( 0x19 );

            // col: 23 offset: 001a
            DRG = parser.ReadOffset< bool >( 0x1a );

            // col: 24 offset: 001b
            BRD = parser.ReadOffset< bool >( 0x1b );

            // col: 25 offset: 001c
            WHM = parser.ReadOffset< bool >( 0x1c );

            // col: 26 offset: 001d
            BLM = parser.ReadOffset< bool >( 0x1d );

            // col: 27 offset: 001e
            ACN = parser.ReadOffset< bool >( 0x1e );

            // col: 28 offset: 001f
            SMN = parser.ReadOffset< bool >( 0x1f );

            // col: 29 offset: 0020
            SCH = parser.ReadOffset< bool >( 0x20 );

            // col: 30 offset: 0021
            ROG = parser.ReadOffset< bool >( 0x21 );

            // col: 31 offset: 0022
            NIN = parser.ReadOffset< bool >( 0x22 );

            // col: 32 offset: 0023
            MCH = parser.ReadOffset< bool >( 0x23 );

            // col: 33 offset: 0024
            DRK = parser.ReadOffset< bool >( 0x24 );

            // col: 34 offset: 0025
            AST = parser.ReadOffset< bool >( 0x25 );

            // col: 35 offset: 0026
            SAM = parser.ReadOffset< bool >( 0x26 );

            // col: 36 offset: 0027
            RDM = parser.ReadOffset< bool >( 0x27 );

            // col: 37 offset: 0028
            BLU = parser.ReadOffset< bool >( 0x28 );

            // col: 38 offset: 0029
            GNB = parser.ReadOffset< bool >( 0x29 );

            // col: 39 offset: 002a
            DNC = parser.ReadOffset< bool >( 0x2a );


        }
    }
}