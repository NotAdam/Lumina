using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BNpcCustomize", columnHash: 0x18f060d4 )]
    public class BNpcCustomize : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public byte Race;

        // col: 01 offset: 0001
        public byte Gender;

        // col: 02 offset: 0002
        public byte BodyType;

        // col: 03 offset: 0003
        public byte Height;

        // col: 04 offset: 0004
        public byte Tribe;

        // col: 05 offset: 0005
        public byte Face;

        // col: 06 offset: 0006
        public byte HairStyle;

        // col: 07 offset: 0007
        public byte HairHighlight;

        // col: 08 offset: 0008
        public byte SkinColor;

        // col: 09 offset: 0009
        public byte EyeHeterochromia;

        // col: 10 offset: 000a
        public byte HairColor;

        // col: 11 offset: 000b
        public byte HairHighlightColor;

        // col: 12 offset: 000c
        public byte FacialFeature;

        // col: 13 offset: 000d
        public byte FacialFeatureColor;

        // col: 14 offset: 000e
        public byte Eyebrows;

        // col: 15 offset: 000f
        public byte EyeColor;

        // col: 16 offset: 0010
        public byte EyeShape;

        // col: 17 offset: 0011
        public byte Nose;

        // col: 18 offset: 0012
        public byte Jaw;

        // col: 19 offset: 0013
        public byte Mouth;

        // col: 20 offset: 0014
        public byte LipColor;

        // col: 21 offset: 0015
        public byte BustOrTone1;

        // col: 22 offset: 0016
        public byte ExtraFeature1;

        // col: 23 offset: 0017
        public byte ExtraFeature2OrBust;

        // col: 24 offset: 0018
        public byte FacePaint;

        // col: 25 offset: 0019
        public byte FacePaintColor;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Race = parser.ReadOffset< byte >( 0x0 );

            // col: 1 offset: 0001
            Gender = parser.ReadOffset< byte >( 0x1 );

            // col: 2 offset: 0002
            BodyType = parser.ReadOffset< byte >( 0x2 );

            // col: 3 offset: 0003
            Height = parser.ReadOffset< byte >( 0x3 );

            // col: 4 offset: 0004
            Tribe = parser.ReadOffset< byte >( 0x4 );

            // col: 5 offset: 0005
            Face = parser.ReadOffset< byte >( 0x5 );

            // col: 6 offset: 0006
            HairStyle = parser.ReadOffset< byte >( 0x6 );

            // col: 7 offset: 0007
            HairHighlight = parser.ReadOffset< byte >( 0x7 );

            // col: 8 offset: 0008
            SkinColor = parser.ReadOffset< byte >( 0x8 );

            // col: 9 offset: 0009
            EyeHeterochromia = parser.ReadOffset< byte >( 0x9 );

            // col: 10 offset: 000a
            HairColor = parser.ReadOffset< byte >( 0xa );

            // col: 11 offset: 000b
            HairHighlightColor = parser.ReadOffset< byte >( 0xb );

            // col: 12 offset: 000c
            FacialFeature = parser.ReadOffset< byte >( 0xc );

            // col: 13 offset: 000d
            FacialFeatureColor = parser.ReadOffset< byte >( 0xd );

            // col: 14 offset: 000e
            Eyebrows = parser.ReadOffset< byte >( 0xe );

            // col: 15 offset: 000f
            EyeColor = parser.ReadOffset< byte >( 0xf );

            // col: 16 offset: 0010
            EyeShape = parser.ReadOffset< byte >( 0x10 );

            // col: 17 offset: 0011
            Nose = parser.ReadOffset< byte >( 0x11 );

            // col: 18 offset: 0012
            Jaw = parser.ReadOffset< byte >( 0x12 );

            // col: 19 offset: 0013
            Mouth = parser.ReadOffset< byte >( 0x13 );

            // col: 20 offset: 0014
            LipColor = parser.ReadOffset< byte >( 0x14 );

            // col: 21 offset: 0015
            BustOrTone1 = parser.ReadOffset< byte >( 0x15 );

            // col: 22 offset: 0016
            ExtraFeature1 = parser.ReadOffset< byte >( 0x16 );

            // col: 23 offset: 0017
            ExtraFeature2OrBust = parser.ReadOffset< byte >( 0x17 );

            // col: 24 offset: 0018
            FacePaint = parser.ReadOffset< byte >( 0x18 );

            // col: 25 offset: 0019
            FacePaintColor = parser.ReadOffset< byte >( 0x19 );


        }
    }
}