using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Credit", columnHash: 0x1fe6ec22 )]
    public class Credit : IExcelRow
    {
        
        public byte Unknown0;
        public LazyRow< CreditCast > Roles1;
        public LazyRow< CreditCast > JapaneseCast1;
        public LazyRow< CreditCast > EnglishCast1;
        public LazyRow< CreditCast > FrenchCast1;
        public LazyRow< CreditCast > GermanCast1;
        public LazyRow< CreditCast > Roles2;
        public LazyRow< CreditCast > JapaneseCast2;
        public LazyRow< CreditCast > EnglishCast2;
        public LazyRow< CreditCast > FrenchCast2;
        public LazyRow< CreditCast > GermanCast2;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Roles1 = new LazyRow< CreditCast >( lumina, parser.ReadColumn< ushort >( 1 ) );
            JapaneseCast1 = new LazyRow< CreditCast >( lumina, parser.ReadColumn< ushort >( 2 ) );
            EnglishCast1 = new LazyRow< CreditCast >( lumina, parser.ReadColumn< ushort >( 3 ) );
            FrenchCast1 = new LazyRow< CreditCast >( lumina, parser.ReadColumn< ushort >( 4 ) );
            GermanCast1 = new LazyRow< CreditCast >( lumina, parser.ReadColumn< ushort >( 5 ) );
            Roles2 = new LazyRow< CreditCast >( lumina, parser.ReadColumn< ushort >( 6 ) );
            JapaneseCast2 = new LazyRow< CreditCast >( lumina, parser.ReadColumn< ushort >( 7 ) );
            EnglishCast2 = new LazyRow< CreditCast >( lumina, parser.ReadColumn< ushort >( 8 ) );
            FrenchCast2 = new LazyRow< CreditCast >( lumina, parser.ReadColumn< ushort >( 9 ) );
            GermanCast2 = new LazyRow< CreditCast >( lumina, parser.ReadColumn< ushort >( 10 ) );
        }
    }
}