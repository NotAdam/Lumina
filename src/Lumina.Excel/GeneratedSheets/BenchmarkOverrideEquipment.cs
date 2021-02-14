// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BenchmarkOverrideEquipment", columnHash: 0xd0ed99de )]
    public class BenchmarkOverrideEquipment : ExcelRow
    {
        
        public uint Unknown0;
        public uint Unknown1;
        public byte Unknown2;
        public sbyte Unknown3;
        public ulong ModelMainHand;
        public LazyRow< Stain > DyeMainHand;
        public ulong ModelOffHand;
        public LazyRow< Stain > DyeOffHand;
        public ulong Unknown8;
        public byte Unknown9;
        public uint ModelHead;
        public LazyRow< Stain > DyeHead;
        public uint ModelBody;
        public LazyRow< Stain > DyeBody;
        public uint ModelHands;
        public LazyRow< Stain > DyeHands;
        public uint ModelLegs;
        public LazyRow< Stain > DyeLegs;
        public uint ModelFeet;
        public LazyRow< Stain > DyeFeet;
        public uint ModelEars;
        public LazyRow< Stain > DyeEars;
        public uint ModelNeck;
        public LazyRow< Stain > DyeNeck;
        public uint ModelWrists;
        public LazyRow< Stain > DyeWrists;
        public uint ModelLeftRing;
        public LazyRow< Stain > DyeLeftRing;
        public uint ModelRightRing;
        public LazyRow< Stain > DyeRightRing;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< sbyte >( 3 );
            ModelMainHand = parser.ReadColumn< ulong >( 4 );
            DyeMainHand = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 5 ), language );
            ModelOffHand = parser.ReadColumn< ulong >( 6 );
            DyeOffHand = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 7 ), language );
            Unknown8 = parser.ReadColumn< ulong >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
            ModelHead = parser.ReadColumn< uint >( 10 );
            DyeHead = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 11 ), language );
            ModelBody = parser.ReadColumn< uint >( 12 );
            DyeBody = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 13 ), language );
            ModelHands = parser.ReadColumn< uint >( 14 );
            DyeHands = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 15 ), language );
            ModelLegs = parser.ReadColumn< uint >( 16 );
            DyeLegs = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 17 ), language );
            ModelFeet = parser.ReadColumn< uint >( 18 );
            DyeFeet = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 19 ), language );
            ModelEars = parser.ReadColumn< uint >( 20 );
            DyeEars = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 21 ), language );
            ModelNeck = parser.ReadColumn< uint >( 22 );
            DyeNeck = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 23 ), language );
            ModelWrists = parser.ReadColumn< uint >( 24 );
            DyeWrists = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 25 ), language );
            ModelLeftRing = parser.ReadColumn< uint >( 26 );
            DyeLeftRing = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 27 ), language );
            ModelRightRing = parser.ReadColumn< uint >( 28 );
            DyeRightRing = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 29 ), language );
        }
    }
}