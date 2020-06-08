using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "NpcEquip", columnHash: 0x8659fe79 )]
    public class NpcEquip : IExcelRow
    {
        
        public ulong ModelMainHand;
        public LazyRow< Stain > DyeMainHand;
        public ulong ModelOffHand;
        public LazyRow< Stain > DyeOffHand;
        public uint ModelHead;
        public LazyRow< Stain > DyeHead;
        public bool Visor;
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
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ModelMainHand = parser.ReadColumn< ulong >( 0 );
            DyeMainHand = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 1 ) );
            ModelOffHand = parser.ReadColumn< ulong >( 2 );
            DyeOffHand = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 3 ) );
            ModelHead = parser.ReadColumn< uint >( 4 );
            DyeHead = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 5 ) );
            Visor = parser.ReadColumn< bool >( 6 );
            ModelBody = parser.ReadColumn< uint >( 7 );
            DyeBody = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 8 ) );
            ModelHands = parser.ReadColumn< uint >( 9 );
            DyeHands = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 10 ) );
            ModelLegs = parser.ReadColumn< uint >( 11 );
            DyeLegs = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 12 ) );
            ModelFeet = parser.ReadColumn< uint >( 13 );
            DyeFeet = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 14 ) );
            ModelEars = parser.ReadColumn< uint >( 15 );
            DyeEars = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 16 ) );
            ModelNeck = parser.ReadColumn< uint >( 17 );
            DyeNeck = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 18 ) );
            ModelWrists = parser.ReadColumn< uint >( 19 );
            DyeWrists = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 20 ) );
            ModelLeftRing = parser.ReadColumn< uint >( 21 );
            DyeLeftRing = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 22 ) );
            ModelRightRing = parser.ReadColumn< uint >( 23 );
            DyeRightRing = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 24 ) );
        }
    }
}