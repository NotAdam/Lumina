// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Recipe", columnHash: 0xb0dc277f )]
    public partial class Recipe : ExcelRow
    {
        public class RecipeUnkData5Obj
        {
            public int ItemIngredient { get; set; }
            public byte AmountIngredient { get; set; }
        }
        
        public int Number { get; set; }
        public LazyRow< CraftType > CraftType { get; set; }
        public LazyRow< RecipeLevelTable > RecipeLevelTable { get; set; }
        public LazyRow< Item > ItemResult { get; set; }
        public byte AmountResult { get; set; }
        public RecipeUnkData5Obj[] UnkData5 { get; set; }
        public LazyRow< RecipeNotebookList > RecipeNotebookList { get; set; }
        public bool IsSecondary { get; set; }
        public byte MaterialQualityFactor { get; set; }
        public ushort DifficultyFactor { get; set; }
        public ushort QualityFactor { get; set; }
        public ushort DurabilityFactor { get; set; }
        public uint RequiredQuality { get; set; }
        public ushort RequiredCraftsmanship { get; set; }
        public ushort RequiredControl { get; set; }
        public ushort QuickSynthCraftsmanship { get; set; }
        public ushort QuickSynthControl { get; set; }
        public LazyRow< SecretRecipeBook > SecretRecipeBook { get; set; }
        public LazyRow< Quest > Quest { get; set; }
        public bool CanQuickSynth { get; set; }
        public bool CanHq { get; set; }
        public bool ExpRewarded { get; set; }
        public LazyRow< Status > StatusRequired { get; set; }
        public LazyRow< Item > ItemRequired { get; set; }
        public bool IsSpecializationRequired { get; set; }
        public bool IsExpert { get; set; }
        public byte Unknown45 { get; set; }
        public ushort Unknown46 { get; set; }
        public ushort PatchNumber { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Number = parser.ReadColumn< int >( 0 );
            CraftType = new LazyRow< CraftType >( gameData, parser.ReadColumn< int >( 1 ), language );
            RecipeLevelTable = new LazyRow< RecipeLevelTable >( gameData, parser.ReadColumn< ushort >( 2 ), language );
            ItemResult = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 3 ), language );
            AmountResult = parser.ReadColumn< byte >( 4 );
            UnkData5 = new RecipeUnkData5Obj[ 10 ];
            for( var i = 0; i < 10; i++ )
            {
                UnkData5[ i ] = new RecipeUnkData5Obj();
                UnkData5[ i ].ItemIngredient = parser.ReadColumn< int >( 5 + ( i * 2 + 0 ) );
                UnkData5[ i ].AmountIngredient = parser.ReadColumn< byte >( 5 + ( i * 2 + 1 ) );
            }
            RecipeNotebookList = new LazyRow< RecipeNotebookList >( gameData, parser.ReadColumn< ushort >( 25 ), language );
            IsSecondary = parser.ReadColumn< bool >( 26 );
            MaterialQualityFactor = parser.ReadColumn< byte >( 27 );
            DifficultyFactor = parser.ReadColumn< ushort >( 28 );
            QualityFactor = parser.ReadColumn< ushort >( 29 );
            DurabilityFactor = parser.ReadColumn< ushort >( 30 );
            RequiredQuality = parser.ReadColumn< uint >( 31 );
            RequiredCraftsmanship = parser.ReadColumn< ushort >( 32 );
            RequiredControl = parser.ReadColumn< ushort >( 33 );
            QuickSynthCraftsmanship = parser.ReadColumn< ushort >( 34 );
            QuickSynthControl = parser.ReadColumn< ushort >( 35 );
            SecretRecipeBook = new LazyRow< SecretRecipeBook >( gameData, parser.ReadColumn< ushort >( 36 ), language );
            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 37 ), language );
            CanQuickSynth = parser.ReadColumn< bool >( 38 );
            CanHq = parser.ReadColumn< bool >( 39 );
            ExpRewarded = parser.ReadColumn< bool >( 40 );
            StatusRequired = new LazyRow< Status >( gameData, parser.ReadColumn< int >( 41 ), language );
            ItemRequired = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 42 ), language );
            IsSpecializationRequired = parser.ReadColumn< bool >( 43 );
            IsExpert = parser.ReadColumn< bool >( 44 );
            Unknown45 = parser.ReadColumn< byte >( 45 );
            Unknown46 = parser.ReadColumn< ushort >( 46 );
            PatchNumber = parser.ReadColumn< ushort >( 47 );
        }
    }
}