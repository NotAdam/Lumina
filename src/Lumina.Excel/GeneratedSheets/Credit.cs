// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
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

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Roles1 = new LazyRow< CreditCast >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            JapaneseCast1 = new LazyRow< CreditCast >( lumina, parser.ReadColumn< ushort >( 2 ), language );
            EnglishCast1 = new LazyRow< CreditCast >( lumina, parser.ReadColumn< ushort >( 3 ), language );
            FrenchCast1 = new LazyRow< CreditCast >( lumina, parser.ReadColumn< ushort >( 4 ), language );
            GermanCast1 = new LazyRow< CreditCast >( lumina, parser.ReadColumn< ushort >( 5 ), language );
            Roles2 = new LazyRow< CreditCast >( lumina, parser.ReadColumn< ushort >( 6 ), language );
            JapaneseCast2 = new LazyRow< CreditCast >( lumina, parser.ReadColumn< ushort >( 7 ), language );
            EnglishCast2 = new LazyRow< CreditCast >( lumina, parser.ReadColumn< ushort >( 8 ), language );
            FrenchCast2 = new LazyRow< CreditCast >( lumina, parser.ReadColumn< ushort >( 9 ), language );
            GermanCast2 = new LazyRow< CreditCast >( lumina, parser.ReadColumn< ushort >( 10 ), language );
        }
    }
}