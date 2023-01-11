// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ENpcBase", columnHash: 0x927347d8 )]
    public partial class ENpcBase : ExcelRow
    {
        
        public ushort EventHandler { get; set; }
        public bool Important { get; set; }
        public uint[] ENpcData { get; set; }
        public float Scale { get; set; }
        public LazyRow< ModelChara > ModelChara { get; set; }
        public LazyRow< Race > Race { get; set; }
        public byte Gender { get; set; }
        public byte BodyType { get; set; }
        public byte Height { get; set; }
        public LazyRow< Tribe > Tribe { get; set; }
        public byte Face { get; set; }
        public byte HairStyle { get; set; }
        public byte HairHighlight { get; set; }
        public byte SkinColor { get; set; }
        public byte EyeHeterochromia { get; set; }
        public byte HairColor { get; set; }
        public byte HairHighlightColor { get; set; }
        public byte FacialFeature { get; set; }
        public byte FacialFeatureColor { get; set; }
        public byte Eyebrows { get; set; }
        public byte EyeColor { get; set; }
        public byte EyeShape { get; set; }
        public byte Nose { get; set; }
        public byte Jaw { get; set; }
        public byte Mouth { get; set; }
        public byte LipColor { get; set; }
        public byte BustOrTone1 { get; set; }
        public byte ExtraFeature1 { get; set; }
        public byte ExtraFeature2OrBust { get; set; }
        public byte FacePaint { get; set; }
        public byte FacePaintColor { get; set; }
        public byte Unknown62 { get; set; }
        public LazyRow< NpcEquip > NpcEquip { get; set; }
        public LazyRow< Behavior > Behavior { get; set; }
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
        public byte Invisibility { get; set; }
        public LazyRow< Balloon > Balloon { get; set; }
        public bool NotRewriteHeight { get; set; }
        public byte DefaultBalloon { get; set; }
        public byte Unknown94 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            EventHandler = parser.ReadColumn< ushort >( 0 );
            Important = parser.ReadColumn< bool >( 1 );
            ENpcData = new uint[ 32 ];
            for( var i = 0; i < 32; i++ )
                ENpcData[ i ] = parser.ReadColumn< uint >( 2 + i );
            Scale = parser.ReadColumn< float >( 34 );
            ModelChara = new LazyRow< ModelChara >( gameData, parser.ReadColumn< ushort >( 35 ), language );
            Race = new LazyRow< Race >( gameData, parser.ReadColumn< byte >( 36 ), language );
            Gender = parser.ReadColumn< byte >( 37 );
            BodyType = parser.ReadColumn< byte >( 38 );
            Height = parser.ReadColumn< byte >( 39 );
            Tribe = new LazyRow< Tribe >( gameData, parser.ReadColumn< byte >( 40 ), language );
            Face = parser.ReadColumn< byte >( 41 );
            HairStyle = parser.ReadColumn< byte >( 42 );
            HairHighlight = parser.ReadColumn< byte >( 43 );
            SkinColor = parser.ReadColumn< byte >( 44 );
            EyeHeterochromia = parser.ReadColumn< byte >( 45 );
            HairColor = parser.ReadColumn< byte >( 46 );
            HairHighlightColor = parser.ReadColumn< byte >( 47 );
            FacialFeature = parser.ReadColumn< byte >( 48 );
            FacialFeatureColor = parser.ReadColumn< byte >( 49 );
            Eyebrows = parser.ReadColumn< byte >( 50 );
            EyeColor = parser.ReadColumn< byte >( 51 );
            EyeShape = parser.ReadColumn< byte >( 52 );
            Nose = parser.ReadColumn< byte >( 53 );
            Jaw = parser.ReadColumn< byte >( 54 );
            Mouth = parser.ReadColumn< byte >( 55 );
            LipColor = parser.ReadColumn< byte >( 56 );
            BustOrTone1 = parser.ReadColumn< byte >( 57 );
            ExtraFeature1 = parser.ReadColumn< byte >( 58 );
            ExtraFeature2OrBust = parser.ReadColumn< byte >( 59 );
            FacePaint = parser.ReadColumn< byte >( 60 );
            FacePaintColor = parser.ReadColumn< byte >( 61 );
            Unknown62 = parser.ReadColumn< byte >( 62 );
            NpcEquip = new LazyRow< NpcEquip >( gameData, parser.ReadColumn< ushort >( 63 ), language );
            Behavior = new LazyRow< Behavior >( gameData, parser.ReadColumn< ushort >( 64 ), language );
            ModelMainHand = parser.ReadColumn< ulong >( 65 );
            DyeMainHand = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 66 ), language );
            ModelOffHand = parser.ReadColumn< ulong >( 67 );
            DyeOffHand = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 68 ), language );
            ModelHead = parser.ReadColumn< uint >( 69 );
            DyeHead = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 70 ), language );
            Visor = parser.ReadColumn< bool >( 71 );
            ModelBody = parser.ReadColumn< uint >( 72 );
            DyeBody = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 73 ), language );
            ModelHands = parser.ReadColumn< uint >( 74 );
            DyeHands = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 75 ), language );
            ModelLegs = parser.ReadColumn< uint >( 76 );
            DyeLegs = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 77 ), language );
            ModelFeet = parser.ReadColumn< uint >( 78 );
            DyeFeet = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 79 ), language );
            ModelEars = parser.ReadColumn< uint >( 80 );
            DyeEars = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 81 ), language );
            ModelNeck = parser.ReadColumn< uint >( 82 );
            DyeNeck = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 83 ), language );
            ModelWrists = parser.ReadColumn< uint >( 84 );
            DyeWrists = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 85 ), language );
            ModelLeftRing = parser.ReadColumn< uint >( 86 );
            DyeLeftRing = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 87 ), language );
            ModelRightRing = parser.ReadColumn< uint >( 88 );
            DyeRightRing = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 89 ), language );
            Invisibility = parser.ReadColumn< byte >( 90 );
            Balloon = new LazyRow< Balloon >( gameData, parser.ReadColumn< ushort >( 91 ), language );
            NotRewriteHeight = parser.ReadColumn< bool >( 92 );
            DefaultBalloon = parser.ReadColumn< byte >( 93 );
            Unknown94 = parser.ReadColumn< byte >( 94 );
        }
    }
}