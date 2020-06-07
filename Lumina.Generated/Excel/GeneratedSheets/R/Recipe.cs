using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Recipe", columnHash: 0x4c219369 )]
    public class Recipe : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public int Number;

        // col: 01 offset: 0004
        public int CraftType;

        // col: 03 offset: 0008
        public int ItemResult;

        // col: 05 offset: 000c
        public int[] unknownc;

        // col: 15 offset: 0020
        public int unknown20;

        // col: 17 offset: 0024
        public int unknown24;

        // col: 19 offset: 0028
        public int unknown28;

        // col: 21 offset: 002c
        public int unknown2c;

        // col: 23 offset: 0030
        public int unknown30;

        // col: 40 offset: 0034
        public int StatusRequired;

        // col: 41 offset: 0038
        public int ItemRequired;

        // col: 02 offset: 003c
        public ushort RecipeLevelTable;

        // col: 25 offset: 003e
        public ushort unknown3e;

        // col: 28 offset: 0040
        public ushort DifficultyFactor;

        // col: 29 offset: 0042
        public ushort QualityFactor;

        // col: 30 offset: 0044
        public ushort DurabilityFactor;

        // col: 31 offset: 0046
        public ushort unknown46;

        // col: 32 offset: 0048
        public ushort RequiredCraftsmanship;

        // col: 33 offset: 004a
        public ushort RequiredControl;

        // col: 34 offset: 004c
        public ushort QuickSynthCraftsmanship;

        // col: 35 offset: 004e
        public ushort QuickSynthControl;

        // col: 36 offset: 0050
        public ushort SecretRecipeBook;

        // col: 44 offset: 0052
        public ushort PatchNumber;

        // col: 04 offset: 0054
        public byte AmountResult;

        // col: 16 offset: 005a
        public byte unknown5a;

        // col: 18 offset: 005b
        public byte unknown5b;

        // col: 20 offset: 005c
        public byte unknown5c;

        // col: 22 offset: 005d
        public byte unknown5d;

        // col: 24 offset: 005e
        public byte unknown5e;

        // col: 27 offset: 005f
        public byte MaterialQualityFactor;

        // col: 26 offset: 0060
        public bool IsSecondary;
        public byte packed60;
        public bool CanQuickSynth;
        public bool CanHq;
        public bool ExpRewarded;
        public bool IsSpecializationRequired;
        public bool IsExpert;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Number = parser.ReadOffset< int >( 0x0 );

            // col: 1 offset: 0004
            CraftType = parser.ReadOffset< int >( 0x4 );

            // col: 3 offset: 0008
            ItemResult = parser.ReadOffset< int >( 0x8 );

            // col: 5 offset: 000c
            unknownc = new int[10];
            unknownc[0] = parser.ReadOffset< int >( 0xc );
            unknownc[1] = parser.ReadOffset< int >( 0x55 );
            unknownc[2] = parser.ReadOffset< int >( 0x10 );
            unknownc[3] = parser.ReadOffset< int >( 0x56 );
            unknownc[4] = parser.ReadOffset< int >( 0x14 );
            unknownc[5] = parser.ReadOffset< int >( 0x57 );
            unknownc[6] = parser.ReadOffset< int >( 0x18 );
            unknownc[7] = parser.ReadOffset< int >( 0x58 );
            unknownc[8] = parser.ReadOffset< int >( 0x1c );
            unknownc[9] = parser.ReadOffset< int >( 0x59 );

            // col: 15 offset: 0020
            unknown20 = parser.ReadOffset< int >( 0x20 );

            // col: 17 offset: 0024
            unknown24 = parser.ReadOffset< int >( 0x24 );

            // col: 19 offset: 0028
            unknown28 = parser.ReadOffset< int >( 0x28 );

            // col: 21 offset: 002c
            unknown2c = parser.ReadOffset< int >( 0x2c );

            // col: 23 offset: 0030
            unknown30 = parser.ReadOffset< int >( 0x30 );

            // col: 40 offset: 0034
            StatusRequired = parser.ReadOffset< int >( 0x34 );

            // col: 41 offset: 0038
            ItemRequired = parser.ReadOffset< int >( 0x38 );

            // col: 2 offset: 003c
            RecipeLevelTable = parser.ReadOffset< ushort >( 0x3c );

            // col: 25 offset: 003e
            unknown3e = parser.ReadOffset< ushort >( 0x3e );

            // col: 28 offset: 0040
            DifficultyFactor = parser.ReadOffset< ushort >( 0x40 );

            // col: 29 offset: 0042
            QualityFactor = parser.ReadOffset< ushort >( 0x42 );

            // col: 30 offset: 0044
            DurabilityFactor = parser.ReadOffset< ushort >( 0x44 );

            // col: 31 offset: 0046
            unknown46 = parser.ReadOffset< ushort >( 0x46 );

            // col: 32 offset: 0048
            RequiredCraftsmanship = parser.ReadOffset< ushort >( 0x48 );

            // col: 33 offset: 004a
            RequiredControl = parser.ReadOffset< ushort >( 0x4a );

            // col: 34 offset: 004c
            QuickSynthCraftsmanship = parser.ReadOffset< ushort >( 0x4c );

            // col: 35 offset: 004e
            QuickSynthControl = parser.ReadOffset< ushort >( 0x4e );

            // col: 36 offset: 0050
            SecretRecipeBook = parser.ReadOffset< ushort >( 0x50 );

            // col: 44 offset: 0052
            PatchNumber = parser.ReadOffset< ushort >( 0x52 );

            // col: 4 offset: 0054
            AmountResult = parser.ReadOffset< byte >( 0x54 );

            // col: 16 offset: 005a
            unknown5a = parser.ReadOffset< byte >( 0x5a );

            // col: 18 offset: 005b
            unknown5b = parser.ReadOffset< byte >( 0x5b );

            // col: 20 offset: 005c
            unknown5c = parser.ReadOffset< byte >( 0x5c );

            // col: 22 offset: 005d
            unknown5d = parser.ReadOffset< byte >( 0x5d );

            // col: 24 offset: 005e
            unknown5e = parser.ReadOffset< byte >( 0x5e );

            // col: 27 offset: 005f
            MaterialQualityFactor = parser.ReadOffset< byte >( 0x5f );

            // col: 26 offset: 0060
            packed60 = parser.ReadOffset< byte >( 0x60, ExcelColumnDataType.UInt8 );

            IsSecondary = ( packed60 & 0x1 ) == 0x1;
            CanQuickSynth = ( packed60 & 0x2 ) == 0x2;
            CanHq = ( packed60 & 0x4 ) == 0x4;
            ExpRewarded = ( packed60 & 0x8 ) == 0x8;
            IsSpecializationRequired = ( packed60 & 0x10 ) == 0x10;
            IsExpert = ( packed60 & 0x20 ) == 0x20;


        }
    }
}