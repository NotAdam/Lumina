using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BenchmarkOverrideEquipment", columnHash: 0xdbb462d8 )]
    public class BenchmarkOverrideEquipment : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 04 offset: 0000
        public ulong ModelMainHand;

        // col: 06 offset: 0008
        public ulong ModelOffHand;

        // col: 08 offset: 0010
        public ulong unknown10;

        // col: 00 offset: 0018
        public uint unknown18;

        // col: 01 offset: 001c
        public uint unknown1c;

        // col: 10 offset: 0020
        public uint ModelHead;

        // col: 12 offset: 0024
        public uint ModelBody;

        // col: 14 offset: 0028
        public uint ModelHands;

        // col: 16 offset: 002c
        public uint ModelLegs;

        // col: 18 offset: 0030
        public uint ModelFeet;

        // col: 20 offset: 0034
        public uint ModelEars;

        // col: 22 offset: 0038
        public uint ModelNeck;

        // col: 24 offset: 003c
        public uint ModelWrists;

        // col: 26 offset: 0040
        public uint ModelLeftRing;

        // col: 28 offset: 0044
        public uint ModelRightRing;

        // col: 02 offset: 0048
        public byte unknown48;

        // col: 05 offset: 0049
        public byte DyeMainHand;

        // col: 07 offset: 004a
        public byte DyeOffHand;

        // col: 09 offset: 004b
        public byte unknown4b;

        // col: 11 offset: 004c
        public byte DyeHead;

        // col: 13 offset: 004d
        public byte DyeBody;

        // col: 15 offset: 004e
        public byte DyeHands;

        // col: 17 offset: 004f
        public byte DyeLegs;

        // col: 19 offset: 0050
        public byte DyeFeet;

        // col: 21 offset: 0051
        public byte DyeEars;

        // col: 23 offset: 0052
        public byte DyeNeck;

        // col: 25 offset: 0053
        public byte DyeWrists;

        // col: 27 offset: 0054
        public byte DyeLeftRing;

        // col: 29 offset: 0055
        public byte DyeRightRing;

        // col: 03 offset: 0056
        public sbyte unknown56;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            ModelMainHand = parser.ReadOffset< ulong >( 0x0 );

            // col: 6 offset: 0008
            ModelOffHand = parser.ReadOffset< ulong >( 0x8 );

            // col: 8 offset: 0010
            unknown10 = parser.ReadOffset< ulong >( 0x10 );

            // col: 0 offset: 0018
            unknown18 = parser.ReadOffset< uint >( 0x18 );

            // col: 1 offset: 001c
            unknown1c = parser.ReadOffset< uint >( 0x1c );

            // col: 10 offset: 0020
            ModelHead = parser.ReadOffset< uint >( 0x20 );

            // col: 12 offset: 0024
            ModelBody = parser.ReadOffset< uint >( 0x24 );

            // col: 14 offset: 0028
            ModelHands = parser.ReadOffset< uint >( 0x28 );

            // col: 16 offset: 002c
            ModelLegs = parser.ReadOffset< uint >( 0x2c );

            // col: 18 offset: 0030
            ModelFeet = parser.ReadOffset< uint >( 0x30 );

            // col: 20 offset: 0034
            ModelEars = parser.ReadOffset< uint >( 0x34 );

            // col: 22 offset: 0038
            ModelNeck = parser.ReadOffset< uint >( 0x38 );

            // col: 24 offset: 003c
            ModelWrists = parser.ReadOffset< uint >( 0x3c );

            // col: 26 offset: 0040
            ModelLeftRing = parser.ReadOffset< uint >( 0x40 );

            // col: 28 offset: 0044
            ModelRightRing = parser.ReadOffset< uint >( 0x44 );

            // col: 2 offset: 0048
            unknown48 = parser.ReadOffset< byte >( 0x48 );

            // col: 5 offset: 0049
            DyeMainHand = parser.ReadOffset< byte >( 0x49 );

            // col: 7 offset: 004a
            DyeOffHand = parser.ReadOffset< byte >( 0x4a );

            // col: 9 offset: 004b
            unknown4b = parser.ReadOffset< byte >( 0x4b );

            // col: 11 offset: 004c
            DyeHead = parser.ReadOffset< byte >( 0x4c );

            // col: 13 offset: 004d
            DyeBody = parser.ReadOffset< byte >( 0x4d );

            // col: 15 offset: 004e
            DyeHands = parser.ReadOffset< byte >( 0x4e );

            // col: 17 offset: 004f
            DyeLegs = parser.ReadOffset< byte >( 0x4f );

            // col: 19 offset: 0050
            DyeFeet = parser.ReadOffset< byte >( 0x50 );

            // col: 21 offset: 0051
            DyeEars = parser.ReadOffset< byte >( 0x51 );

            // col: 23 offset: 0052
            DyeNeck = parser.ReadOffset< byte >( 0x52 );

            // col: 25 offset: 0053
            DyeWrists = parser.ReadOffset< byte >( 0x53 );

            // col: 27 offset: 0054
            DyeLeftRing = parser.ReadOffset< byte >( 0x54 );

            // col: 29 offset: 0055
            DyeRightRing = parser.ReadOffset< byte >( 0x55 );

            // col: 3 offset: 0056
            unknown56 = parser.ReadOffset< sbyte >( 0x56 );


        }
    }
}