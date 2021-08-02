// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "NpcEquip", columnHash: 0xe91c87ba )]
    public partial class NpcEquip : ExcelRow
    {
        
        public ulong ModelMainHand { get; set; }
        public LazyRow< Stain > DyeMainHand { get; set; }
        public ulong ModelOffHand { get; set; }
        public LazyRow< Stain > DyeOffHand { get; set; }
        public uint ModelHead { get; set; }
        public LazyRow< Stain > DyeHead { get; set; }
        public bool Visor { get; set; }
        public uint ModelBody { get; set; }
        public LazyRow< Stain > DyeBody { get; set; }
        public uint ModelHands { get; set; }
        public LazyRow< Stain > DyeHands { get; set; }
        public uint ModelLegs { get; set; }
        public LazyRow< Stain > DyeLegs { get; set; }
        public uint ModelFeet { get; set; }
        public LazyRow< Stain > DyeFeet { get; set; }
        public uint ModelEars { get; set; }
        public LazyRow< Stain > DyeEars { get; set; }
        public uint ModelNeck { get; set; }
        public LazyRow< Stain > DyeNeck { get; set; }
        public uint ModelWrists { get; set; }
        public LazyRow< Stain > DyeWrists { get; set; }
        public uint ModelLeftRing { get; set; }
        public LazyRow< Stain > DyeLeftRing { get; set; }
        public uint ModelRightRing { get; set; }
        public LazyRow< Stain > DyeRightRing { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ModelMainHand = parser.ReadColumn< ulong >( 0 );
            DyeMainHand = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 1 ), language );
            ModelOffHand = parser.ReadColumn< ulong >( 2 );
            DyeOffHand = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 3 ), language );
            ModelHead = parser.ReadColumn< uint >( 4 );
            DyeHead = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 5 ), language );
            Visor = parser.ReadColumn< bool >( 6 );
            ModelBody = parser.ReadColumn< uint >( 7 );
            DyeBody = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 8 ), language );
            ModelHands = parser.ReadColumn< uint >( 9 );
            DyeHands = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 10 ), language );
            ModelLegs = parser.ReadColumn< uint >( 11 );
            DyeLegs = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 12 ), language );
            ModelFeet = parser.ReadColumn< uint >( 13 );
            DyeFeet = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 14 ), language );
            ModelEars = parser.ReadColumn< uint >( 15 );
            DyeEars = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 16 ), language );
            ModelNeck = parser.ReadColumn< uint >( 17 );
            DyeNeck = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 18 ), language );
            ModelWrists = parser.ReadColumn< uint >( 19 );
            DyeWrists = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 20 ), language );
            ModelLeftRing = parser.ReadColumn< uint >( 21 );
            DyeLeftRing = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 22 ), language );
            ModelRightRing = parser.ReadColumn< uint >( 23 );
            DyeRightRing = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 24 ), language );
        }
    }
}