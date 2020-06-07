using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "NpcEquip", columnHash: 0x8659fe79 )]
    public class NpcEquip : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public ulong ModelMainHand;

        // col: 02 offset: 0008
        public ulong ModelOffHand;

        // col: 04 offset: 0010
        public uint ModelHead;

        // col: 07 offset: 0014
        public uint ModelBody;

        // col: 09 offset: 0018
        public uint ModelHands;

        // col: 11 offset: 001c
        public uint ModelLegs;

        // col: 13 offset: 0020
        public uint ModelFeet;

        // col: 15 offset: 0024
        public uint ModelEars;

        // col: 17 offset: 0028
        public uint ModelNeck;

        // col: 19 offset: 002c
        public uint ModelWrists;

        // col: 21 offset: 0030
        public uint ModelLeftRing;

        // col: 23 offset: 0034
        public uint ModelRightRing;

        // col: 01 offset: 0038
        public byte DyeMainHand;

        // col: 03 offset: 0039
        public byte DyeOffHand;

        // col: 05 offset: 003a
        public byte DyeHead;

        // col: 08 offset: 003b
        public byte DyeBody;

        // col: 10 offset: 003c
        public byte DyeHands;

        // col: 12 offset: 003d
        public byte DyeLegs;

        // col: 14 offset: 003e
        public byte DyeFeet;

        // col: 16 offset: 003f
        public byte DyeEars;

        // col: 18 offset: 0040
        public byte DyeNeck;

        // col: 20 offset: 0041
        public byte DyeWrists;

        // col: 22 offset: 0042
        public byte DyeLeftRing;

        // col: 24 offset: 0043
        public byte DyeRightRing;

        // col: 06 offset: 0044
        public bool Visor;
        public byte packed44;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            ModelMainHand = parser.ReadOffset< ulong >( 0x0 );

            // col: 2 offset: 0008
            ModelOffHand = parser.ReadOffset< ulong >( 0x8 );

            // col: 4 offset: 0010
            ModelHead = parser.ReadOffset< uint >( 0x10 );

            // col: 7 offset: 0014
            ModelBody = parser.ReadOffset< uint >( 0x14 );

            // col: 9 offset: 0018
            ModelHands = parser.ReadOffset< uint >( 0x18 );

            // col: 11 offset: 001c
            ModelLegs = parser.ReadOffset< uint >( 0x1c );

            // col: 13 offset: 0020
            ModelFeet = parser.ReadOffset< uint >( 0x20 );

            // col: 15 offset: 0024
            ModelEars = parser.ReadOffset< uint >( 0x24 );

            // col: 17 offset: 0028
            ModelNeck = parser.ReadOffset< uint >( 0x28 );

            // col: 19 offset: 002c
            ModelWrists = parser.ReadOffset< uint >( 0x2c );

            // col: 21 offset: 0030
            ModelLeftRing = parser.ReadOffset< uint >( 0x30 );

            // col: 23 offset: 0034
            ModelRightRing = parser.ReadOffset< uint >( 0x34 );

            // col: 1 offset: 0038
            DyeMainHand = parser.ReadOffset< byte >( 0x38 );

            // col: 3 offset: 0039
            DyeOffHand = parser.ReadOffset< byte >( 0x39 );

            // col: 5 offset: 003a
            DyeHead = parser.ReadOffset< byte >( 0x3a );

            // col: 8 offset: 003b
            DyeBody = parser.ReadOffset< byte >( 0x3b );

            // col: 10 offset: 003c
            DyeHands = parser.ReadOffset< byte >( 0x3c );

            // col: 12 offset: 003d
            DyeLegs = parser.ReadOffset< byte >( 0x3d );

            // col: 14 offset: 003e
            DyeFeet = parser.ReadOffset< byte >( 0x3e );

            // col: 16 offset: 003f
            DyeEars = parser.ReadOffset< byte >( 0x3f );

            // col: 18 offset: 0040
            DyeNeck = parser.ReadOffset< byte >( 0x40 );

            // col: 20 offset: 0041
            DyeWrists = parser.ReadOffset< byte >( 0x41 );

            // col: 22 offset: 0042
            DyeLeftRing = parser.ReadOffset< byte >( 0x42 );

            // col: 24 offset: 0043
            DyeRightRing = parser.ReadOffset< byte >( 0x43 );

            // col: 6 offset: 0044
            packed44 = parser.ReadOffset< byte >( 0x44, ExcelColumnDataType.UInt8 );

            Visor = ( packed44 & 0x1 ) == 0x1;


        }
    }
}