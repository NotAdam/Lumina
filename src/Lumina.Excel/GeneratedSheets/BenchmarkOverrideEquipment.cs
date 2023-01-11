// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BenchmarkOverrideEquipment", columnHash: 0xd0ed99de )]
    public partial class BenchmarkOverrideEquipment : ExcelRow
    {
        
        public uint Unknown0 { get; set; }
        public uint Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public sbyte Unknown3 { get; set; }
        public ulong ModelMainHand { get; set; }
        public LazyRow< Stain > DyeMainHand { get; set; }
        public ulong ModelOffHand { get; set; }
        public LazyRow< Stain > DyeOffHand { get; set; }
        public ulong Unknown8 { get; set; }
        public byte Unknown9 { get; set; }
        public uint ModelHead { get; set; }
        public LazyRow< Stain > DyeHead { get; set; }
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

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< sbyte >( 3 );
            ModelMainHand = parser.ReadColumn< ulong >( 4 );
            DyeMainHand = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 5 ), language );
            ModelOffHand = parser.ReadColumn< ulong >( 6 );
            DyeOffHand = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 7 ), language );
            Unknown8 = parser.ReadColumn< ulong >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
            ModelHead = parser.ReadColumn< uint >( 10 );
            DyeHead = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 11 ), language );
            ModelBody = parser.ReadColumn< uint >( 12 );
            DyeBody = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 13 ), language );
            ModelHands = parser.ReadColumn< uint >( 14 );
            DyeHands = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 15 ), language );
            ModelLegs = parser.ReadColumn< uint >( 16 );
            DyeLegs = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 17 ), language );
            ModelFeet = parser.ReadColumn< uint >( 18 );
            DyeFeet = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 19 ), language );
            ModelEars = parser.ReadColumn< uint >( 20 );
            DyeEars = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 21 ), language );
            ModelNeck = parser.ReadColumn< uint >( 22 );
            DyeNeck = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 23 ), language );
            ModelWrists = parser.ReadColumn< uint >( 24 );
            DyeWrists = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 25 ), language );
            ModelLeftRing = parser.ReadColumn< uint >( 26 );
            DyeLeftRing = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 27 ), language );
            ModelRightRing = parser.ReadColumn< uint >( 28 );
            DyeRightRing = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 29 ), language );
        }
    }
}