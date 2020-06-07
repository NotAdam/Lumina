using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ENpcBase", columnHash: 0x74e2be2e )]
    public class ENpcBase : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 02 offset: 0000
        public uint[] ENpcData;

        // col: 65 offset: 0080
        public ulong ModelMainHand;

        // col: 67 offset: 0088
        public ulong ModelOffHand;

        // col: 34 offset: 0090
        public float Scale;

        // col: 69 offset: 0094
        public uint ModelHead;

        // col: 72 offset: 0098
        public uint ModelBody;

        // col: 74 offset: 009c
        public uint ModelHands;

        // col: 76 offset: 00a0
        public uint ModelLegs;

        // col: 78 offset: 00a4
        public uint ModelFeet;

        // col: 80 offset: 00a8
        public uint ModelEars;

        // col: 82 offset: 00ac
        public uint ModelNeck;

        // col: 84 offset: 00b0
        public uint ModelWrists;

        // col: 86 offset: 00b4
        public uint ModelLeftRing;

        // col: 88 offset: 00b8
        public uint ModelRightRing;

        // col: 00 offset: 00bc
        public ushort EventHandler;

        // col: 35 offset: 00be
        public ushort ModelChara;

        // col: 63 offset: 00c0
        public ushort NpcEquip;

        // col: 64 offset: 00c2
        public ushort Behavior;

        // col: 91 offset: 00c4
        public ushort Balloon;

        // col: 36 offset: 00c6
        public byte Race;

        // col: 37 offset: 00c7
        public byte Gender;

        // col: 38 offset: 00c8
        public byte BodyType;

        // col: 39 offset: 00c9
        public byte Height;

        // col: 40 offset: 00ca
        public byte Tribe;

        // col: 41 offset: 00cb
        public byte Face;

        // col: 42 offset: 00cc
        public byte HairStyle;

        // col: 43 offset: 00cd
        public byte HairHighlight;

        // col: 44 offset: 00ce
        public byte SkinColor;

        // col: 45 offset: 00cf
        public byte EyeHeterochromia;

        // col: 46 offset: 00d0
        public byte HairColor;

        // col: 47 offset: 00d1
        public byte HairHighlightColor;

        // col: 48 offset: 00d2
        public byte FacialFeature;

        // col: 49 offset: 00d3
        public byte FacialFeatureColor;

        // col: 50 offset: 00d4
        public byte Eyebrows;

        // col: 51 offset: 00d5
        public byte EyeColor;

        // col: 52 offset: 00d6
        public byte EyeShape;

        // col: 53 offset: 00d7
        public byte Nose;

        // col: 54 offset: 00d8
        public byte Jaw;

        // col: 55 offset: 00d9
        public byte Mouth;

        // col: 56 offset: 00da
        public byte LipColor;

        // col: 57 offset: 00db
        public byte BustOrTone1;

        // col: 58 offset: 00dc
        public byte ExtraFeature1;

        // col: 59 offset: 00dd
        public byte ExtraFeature2OrBust;

        // col: 60 offset: 00de
        public byte FacePaint;

        // col: 61 offset: 00df
        public byte FacePaintColor;

        // col: 62 offset: 00e0
        public byte unknowne0;

        // col: 66 offset: 00e1
        public byte DyeMainHand;

        // col: 68 offset: 00e2
        public byte DyeOffHand;

        // col: 70 offset: 00e3
        public byte DyeHead;

        // col: 73 offset: 00e4
        public byte DyeBody;

        // col: 75 offset: 00e5
        public byte DyeHands;

        // col: 77 offset: 00e6
        public byte DyeLegs;

        // col: 79 offset: 00e7
        public byte DyeFeet;

        // col: 81 offset: 00e8
        public byte DyeEars;

        // col: 83 offset: 00e9
        public byte DyeNeck;

        // col: 85 offset: 00ea
        public byte DyeWrists;

        // col: 87 offset: 00eb
        public byte DyeLeftRing;

        // col: 89 offset: 00ec
        public byte DyeRightRing;

        // col: 90 offset: 00ed
        public byte Invisibility;

        // col: 93 offset: 00ee
        public byte DefaultBalloon;

        // col: 94 offset: 00ef
        public byte unknownef;

        // col: 01 offset: 00f0
        public bool Important;
        public byte packedf0;
        public bool Visor;
        public bool NotRewriteHeight;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            ENpcData = new uint[32];
            ENpcData[0] = parser.ReadOffset< uint >( 0x0 );
            ENpcData[1] = parser.ReadOffset< uint >( 0x4 );
            ENpcData[2] = parser.ReadOffset< uint >( 0x8 );
            ENpcData[3] = parser.ReadOffset< uint >( 0xc );
            ENpcData[4] = parser.ReadOffset< uint >( 0x10 );
            ENpcData[5] = parser.ReadOffset< uint >( 0x14 );
            ENpcData[6] = parser.ReadOffset< uint >( 0x18 );
            ENpcData[7] = parser.ReadOffset< uint >( 0x1c );
            ENpcData[8] = parser.ReadOffset< uint >( 0x20 );
            ENpcData[9] = parser.ReadOffset< uint >( 0x24 );
            ENpcData[10] = parser.ReadOffset< uint >( 0x28 );
            ENpcData[11] = parser.ReadOffset< uint >( 0x2c );
            ENpcData[12] = parser.ReadOffset< uint >( 0x30 );
            ENpcData[13] = parser.ReadOffset< uint >( 0x34 );
            ENpcData[14] = parser.ReadOffset< uint >( 0x38 );
            ENpcData[15] = parser.ReadOffset< uint >( 0x3c );
            ENpcData[16] = parser.ReadOffset< uint >( 0x40 );
            ENpcData[17] = parser.ReadOffset< uint >( 0x44 );
            ENpcData[18] = parser.ReadOffset< uint >( 0x48 );
            ENpcData[19] = parser.ReadOffset< uint >( 0x4c );
            ENpcData[20] = parser.ReadOffset< uint >( 0x50 );
            ENpcData[21] = parser.ReadOffset< uint >( 0x54 );
            ENpcData[22] = parser.ReadOffset< uint >( 0x58 );
            ENpcData[23] = parser.ReadOffset< uint >( 0x5c );
            ENpcData[24] = parser.ReadOffset< uint >( 0x60 );
            ENpcData[25] = parser.ReadOffset< uint >( 0x64 );
            ENpcData[26] = parser.ReadOffset< uint >( 0x68 );
            ENpcData[27] = parser.ReadOffset< uint >( 0x6c );
            ENpcData[28] = parser.ReadOffset< uint >( 0x70 );
            ENpcData[29] = parser.ReadOffset< uint >( 0x74 );
            ENpcData[30] = parser.ReadOffset< uint >( 0x78 );
            ENpcData[31] = parser.ReadOffset< uint >( 0x7c );

            // col: 65 offset: 0080
            ModelMainHand = parser.ReadOffset< ulong >( 0x80 );

            // col: 67 offset: 0088
            ModelOffHand = parser.ReadOffset< ulong >( 0x88 );

            // col: 34 offset: 0090
            Scale = parser.ReadOffset< float >( 0x90 );

            // col: 69 offset: 0094
            ModelHead = parser.ReadOffset< uint >( 0x94 );

            // col: 72 offset: 0098
            ModelBody = parser.ReadOffset< uint >( 0x98 );

            // col: 74 offset: 009c
            ModelHands = parser.ReadOffset< uint >( 0x9c );

            // col: 76 offset: 00a0
            ModelLegs = parser.ReadOffset< uint >( 0xa0 );

            // col: 78 offset: 00a4
            ModelFeet = parser.ReadOffset< uint >( 0xa4 );

            // col: 80 offset: 00a8
            ModelEars = parser.ReadOffset< uint >( 0xa8 );

            // col: 82 offset: 00ac
            ModelNeck = parser.ReadOffset< uint >( 0xac );

            // col: 84 offset: 00b0
            ModelWrists = parser.ReadOffset< uint >( 0xb0 );

            // col: 86 offset: 00b4
            ModelLeftRing = parser.ReadOffset< uint >( 0xb4 );

            // col: 88 offset: 00b8
            ModelRightRing = parser.ReadOffset< uint >( 0xb8 );

            // col: 0 offset: 00bc
            EventHandler = parser.ReadOffset< ushort >( 0xbc );

            // col: 35 offset: 00be
            ModelChara = parser.ReadOffset< ushort >( 0xbe );

            // col: 63 offset: 00c0
            NpcEquip = parser.ReadOffset< ushort >( 0xc0 );

            // col: 64 offset: 00c2
            Behavior = parser.ReadOffset< ushort >( 0xc2 );

            // col: 91 offset: 00c4
            Balloon = parser.ReadOffset< ushort >( 0xc4 );

            // col: 36 offset: 00c6
            Race = parser.ReadOffset< byte >( 0xc6 );

            // col: 37 offset: 00c7
            Gender = parser.ReadOffset< byte >( 0xc7 );

            // col: 38 offset: 00c8
            BodyType = parser.ReadOffset< byte >( 0xc8 );

            // col: 39 offset: 00c9
            Height = parser.ReadOffset< byte >( 0xc9 );

            // col: 40 offset: 00ca
            Tribe = parser.ReadOffset< byte >( 0xca );

            // col: 41 offset: 00cb
            Face = parser.ReadOffset< byte >( 0xcb );

            // col: 42 offset: 00cc
            HairStyle = parser.ReadOffset< byte >( 0xcc );

            // col: 43 offset: 00cd
            HairHighlight = parser.ReadOffset< byte >( 0xcd );

            // col: 44 offset: 00ce
            SkinColor = parser.ReadOffset< byte >( 0xce );

            // col: 45 offset: 00cf
            EyeHeterochromia = parser.ReadOffset< byte >( 0xcf );

            // col: 46 offset: 00d0
            HairColor = parser.ReadOffset< byte >( 0xd0 );

            // col: 47 offset: 00d1
            HairHighlightColor = parser.ReadOffset< byte >( 0xd1 );

            // col: 48 offset: 00d2
            FacialFeature = parser.ReadOffset< byte >( 0xd2 );

            // col: 49 offset: 00d3
            FacialFeatureColor = parser.ReadOffset< byte >( 0xd3 );

            // col: 50 offset: 00d4
            Eyebrows = parser.ReadOffset< byte >( 0xd4 );

            // col: 51 offset: 00d5
            EyeColor = parser.ReadOffset< byte >( 0xd5 );

            // col: 52 offset: 00d6
            EyeShape = parser.ReadOffset< byte >( 0xd6 );

            // col: 53 offset: 00d7
            Nose = parser.ReadOffset< byte >( 0xd7 );

            // col: 54 offset: 00d8
            Jaw = parser.ReadOffset< byte >( 0xd8 );

            // col: 55 offset: 00d9
            Mouth = parser.ReadOffset< byte >( 0xd9 );

            // col: 56 offset: 00da
            LipColor = parser.ReadOffset< byte >( 0xda );

            // col: 57 offset: 00db
            BustOrTone1 = parser.ReadOffset< byte >( 0xdb );

            // col: 58 offset: 00dc
            ExtraFeature1 = parser.ReadOffset< byte >( 0xdc );

            // col: 59 offset: 00dd
            ExtraFeature2OrBust = parser.ReadOffset< byte >( 0xdd );

            // col: 60 offset: 00de
            FacePaint = parser.ReadOffset< byte >( 0xde );

            // col: 61 offset: 00df
            FacePaintColor = parser.ReadOffset< byte >( 0xdf );

            // col: 62 offset: 00e0
            unknowne0 = parser.ReadOffset< byte >( 0xe0 );

            // col: 66 offset: 00e1
            DyeMainHand = parser.ReadOffset< byte >( 0xe1 );

            // col: 68 offset: 00e2
            DyeOffHand = parser.ReadOffset< byte >( 0xe2 );

            // col: 70 offset: 00e3
            DyeHead = parser.ReadOffset< byte >( 0xe3 );

            // col: 73 offset: 00e4
            DyeBody = parser.ReadOffset< byte >( 0xe4 );

            // col: 75 offset: 00e5
            DyeHands = parser.ReadOffset< byte >( 0xe5 );

            // col: 77 offset: 00e6
            DyeLegs = parser.ReadOffset< byte >( 0xe6 );

            // col: 79 offset: 00e7
            DyeFeet = parser.ReadOffset< byte >( 0xe7 );

            // col: 81 offset: 00e8
            DyeEars = parser.ReadOffset< byte >( 0xe8 );

            // col: 83 offset: 00e9
            DyeNeck = parser.ReadOffset< byte >( 0xe9 );

            // col: 85 offset: 00ea
            DyeWrists = parser.ReadOffset< byte >( 0xea );

            // col: 87 offset: 00eb
            DyeLeftRing = parser.ReadOffset< byte >( 0xeb );

            // col: 89 offset: 00ec
            DyeRightRing = parser.ReadOffset< byte >( 0xec );

            // col: 90 offset: 00ed
            Invisibility = parser.ReadOffset< byte >( 0xed );

            // col: 93 offset: 00ee
            DefaultBalloon = parser.ReadOffset< byte >( 0xee );

            // col: 94 offset: 00ef
            unknownef = parser.ReadOffset< byte >( 0xef );

            // col: 1 offset: 00f0
            packedf0 = parser.ReadOffset< byte >( 0xf0, ExcelColumnDataType.UInt8 );

            Important = ( packedf0 & 0x1 ) == 0x1;
            Visor = ( packedf0 & 0x2 ) == 0x2;
            NotRewriteHeight = ( packedf0 & 0x4 ) == 0x4;


        }
    }
}