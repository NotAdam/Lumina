// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceRank", columnHash: 0xf840eabf )]
    public class ChocoboRaceRank : ExcelRow
    {
        
        public ushort RatingMin;
        public ushort RatingMax;
        public LazyRow< GoldSaucerTextData > Name;
        public ushort Fee;
        public int Icon;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            RatingMin = parser.ReadColumn< ushort >( 0 );
            RatingMax = parser.ReadColumn< ushort >( 1 );
            Name = new LazyRow< GoldSaucerTextData >( gameData, parser.ReadColumn< ushort >( 2 ), language );
            Fee = parser.ReadColumn< ushort >( 3 );
            Icon = parser.ReadColumn< int >( 4 );
        }
    }
}