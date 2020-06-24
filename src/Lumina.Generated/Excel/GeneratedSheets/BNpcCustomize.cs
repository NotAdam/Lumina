using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BNpcCustomize", columnHash: 0x18f060d4 )]
    public class BNpcCustomize : IExcelRow
    {
        
        public LazyRow< Race > Race;
        public byte Gender;
        public byte BodyType;
        public byte Height;
        public LazyRow< Tribe > Tribe;
        public byte Face;
        public byte HairStyle;
        public byte HairHighlight;
        public byte SkinColor;
        public byte EyeHeterochromia;
        public byte HairColor;
        public byte HairHighlightColor;
        public byte FacialFeature;
        public byte FacialFeatureColor;
        public byte Eyebrows;
        public byte EyeColor;
        public byte EyeShape;
        public byte Nose;
        public byte Jaw;
        public byte Mouth;
        public byte LipColor;
        public byte BustOrTone1;
        public byte ExtraFeature1;
        public byte ExtraFeature2OrBust;
        public byte FacePaint;
        public byte FacePaintColor;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Race = new LazyRow< Race >( lumina, parser.ReadColumn< byte >( 0 ), language );
            Gender = parser.ReadColumn< byte >( 1 );
            BodyType = parser.ReadColumn< byte >( 2 );
            Height = parser.ReadColumn< byte >( 3 );
            Tribe = new LazyRow< Tribe >( lumina, parser.ReadColumn< byte >( 4 ), language );
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