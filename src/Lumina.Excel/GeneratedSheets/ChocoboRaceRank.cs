// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceRank", columnHash: 0xf840eabf )]
    public partial class ChocoboRaceRank : ExcelRow
    {
        
        public ushort RatingMin { get; set; }
        public ushort RatingMax { get; set; }
        public LazyRow< GoldSaucerTextData > Name { get; set; }
        public ushort Fee { get; set; }
        public int Icon { get; set; }
        
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