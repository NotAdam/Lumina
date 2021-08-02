// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BNpcCustomize", columnHash: 0x18f060d4 )]
    public partial class BNpcCustomize : ExcelRow
    {
        
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
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Race = new LazyRow< Race >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Gender = parser.ReadColumn< byte >( 1 );
            BodyType = parser.ReadColumn< byte >( 2 );
            Height = parser.ReadColumn< byte >( 3 );
            Tribe = new LazyRow< Tribe >( gameData, parser.ReadColumn< byte >( 4 ), language );
            Face = parser.ReadColumn< byte >( 5 );
            HairStyle = parser.ReadColumn< byte >( 6 );
            HairHighlight = parser.ReadColumn< byte >( 7 );
            SkinColor = parser.ReadColumn< byte >( 8 );
            EyeHeterochromia = parser.ReadColumn< byte >( 9 );
            HairColor = parser.ReadColumn< byte >( 10 );
            HairHighlightColor = parser.ReadColumn< byte >( 11 );
            FacialFeature = parser.ReadColumn< byte >( 12 );
            FacialFeatureColor = parser.ReadColumn< byte >( 13 );
            Eyebrows = parser.ReadColumn< byte >( 14 );
            EyeColor = parser.ReadColumn< byte >( 15 );
            EyeShape = parser.ReadColumn< byte >( 16 );
            Nose = parser.ReadColumn< byte >( 17 );
            Jaw = parser.ReadColumn< byte >( 18 );
            Mouth = parser.ReadColumn< byte >( 19 );
            LipColor = parser.ReadColumn< byte >( 20 );
            BustOrTone1 = parser.ReadColumn< byte >( 21 );
            ExtraFeature1 = parser.ReadColumn< byte >( 22 );
            ExtraFeature2OrBust = parser.ReadColumn< byte >( 23 );
            FacePaint = parser.ReadColumn< byte >( 24 );
            FacePaintColor = parser.ReadColumn< byte >( 25 );
        }
    }
}