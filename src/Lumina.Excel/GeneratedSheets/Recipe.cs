// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Recipe", columnHash: 0xf56e5856 )]
    public class Recipe : ExcelRow
    {
        public struct UnkStruct5Struct
        {
            public int ItemIngredient;
            public byte AmountIngredient;
        }
        
        public int Number;
        public LazyRow< CraftType > CraftType;
        public LazyRow< RecipeLevelTable > RecipeLevelTable;
        public LazyRow< Item > ItemResult;
        public byte AmountResult;
        public UnkStruct5Struct[] UnkStruct5;
        public ushort Unknown25;
        public bool IsSecondary;
        public byte MaterialQualityFactor;
        public ushort DifficultyFactor;
        public ushort QualityFactor;
        public ushort DurabilityFactor;
        public ushort Unknown31;
        public ushort RequiredCraftsmanship;
        public ushort RequiredControl;
        public ushort QuickSynthCraftsmanship;
        public ushort QuickSynthControl;
        public LazyRow< SecretRecipeBook > SecretRecipeBook;
        public uint Unknown37;
        public bool CanQuickSynth;
        public bool CanHq;
        public bool ExpRewarded;
        public LazyRow< Status > StatusRequired;
        public LazyRow< Item > ItemRequired;
        public bool IsSpecializationRequired;
        public bool IsExpert;
        public ushort PatchNumber;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Number = parser.ReadColumn< int >( 0 );
            CraftType = new LazyRow< CraftType >( lumina, parser.ReadColumn< int >( 1 ), language );
            RecipeLevelTable = new LazyRow< RecipeLevelTable >( lumina, parser.ReadColumn< ushort >( 2 ), language );
            ItemResult = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 3 ), language );
            AmountResult = parser.ReadColumn< byte >( 4 );
            UnkStruct5 = new UnkStruct5Struct[ 10 ];
            for( var i = 0; i < 10; i++ )
            {
                UnkStruct5[ i ] = new UnkStruct5Struct();
                UnkStruct5[ i ].ItemIngredient = parser.ReadColumn< int >( 5 + ( i * 2 + 0 ) );
                UnkStruct5[ i ].AmountIngredient = parser.ReadColumn< byte >( 5 + ( i * 2 + 1 ) );
            }
            Unknown25 = parser.ReadColumn< ushort >( 25 );
            IsSecondary = parser.ReadColumn< bool >( 26 );
            MaterialQualityFactor = parser.ReadColumn< byte >( 27 );
            DifficultyFactor = parser.ReadColumn< ushort >( 28 );
            QualityFactor = parser.ReadColumn< ushort >( 29 );
            DurabilityFactor = parser.ReadColumn< ushort >( 30 );
            Unknown31 = parser.ReadColumn< ushort >( 31 );
            RequiredCraftsmanship = parser.ReadColumn< ushort >( 32 );
            RequiredControl = parser.ReadColumn< ushort >( 33 );
            QuickSynthCraftsmanship = parser.ReadColumn< ushort >( 34 );
            QuickSynthControl = parser.ReadColumn< ushort >( 35 );
            SecretRecipeBook = new LazyRow< SecretRecipeBook >( lumina, parser.ReadColumn< ushort >( 36 ), language );
            Unknown37 = parser.ReadColumn< uint >( 37 );
            CanQuickSynth = parser.ReadColumn< bool >( 38 );
            CanHq = parser.ReadColumn< bool >( 39 );
            ExpRewarded = parser.ReadColumn< bool >( 40 );
            StatusRequired = new LazyRow< Status >( lumina, parser.ReadColumn< int >( 41 ), language );
            ItemRequired = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 42 ), language );
            IsSpecializationRequired = parser.ReadColumn< bool >( 43 );
            IsExpert = parser.ReadColumn< bool >( 44 );
            PatchNumber = parser.ReadColumn< ushort >( 45 );
        }
    }
}