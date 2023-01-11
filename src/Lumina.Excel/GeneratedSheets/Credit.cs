// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Credit", columnHash: 0x1fe6ec22 )]
    public partial class Credit : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public LazyRow< CreditCast > Roles1 { get; set; }
        public LazyRow< CreditCast > JapaneseCast1 { get; set; }
        public LazyRow< CreditCast > EnglishCast1 { get; set; }
        public LazyRow< CreditCast > FrenchCast1 { get; set; }
        public LazyRow< CreditCast > GermanCast1 { get; set; }
        public LazyRow< CreditCast > Roles2 { get; set; }
        public LazyRow< CreditCast > JapaneseCast2 { get; set; }
        public LazyRow< CreditCast > EnglishCast2 { get; set; }
        public LazyRow< CreditCast > FrenchCast2 { get; set; }
        public LazyRow< CreditCast > GermanCast2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Roles1 = new LazyRow< CreditCast >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            JapaneseCast1 = new LazyRow< CreditCast >( gameData, parser.ReadColumn< ushort >( 2 ), language );
            EnglishCast1 = new LazyRow< CreditCast >( gameData, parser.ReadColumn< ushort >( 3 ), language );
            FrenchCast1 = new LazyRow< CreditCast >( gameData, parser.ReadColumn< ushort >( 4 ), language );
            GermanCast1 = new LazyRow< CreditCast >( gameData, parser.ReadColumn< ushort >( 5 ), language );
            Roles2 = new LazyRow< CreditCast >( gameData, parser.ReadColumn< ushort >( 6 ), language );
            JapaneseCast2 = new LazyRow< CreditCast >( gameData, parser.ReadColumn< ushort >( 7 ), language );
            EnglishCast2 = new LazyRow< CreditCast >( gameData, parser.ReadColumn< ushort >( 8 ), language );
            FrenchCast2 = new LazyRow< CreditCast >( gameData, parser.ReadColumn< ushort >( 9 ), language );
            GermanCast2 = new LazyRow< CreditCast >( gameData, parser.ReadColumn< ushort >( 10 ), language );
        }
    }
}