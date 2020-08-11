// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceRank", columnHash: 0xf840eabf )]
    public class ChocoboRaceRank : IExcelRow
    {
        
        public ushort RatingMin;
        public ushort RatingMax;
        public LazyRow< GoldSaucerTextData > Name;
        public ushort Fee;
        public int Icon;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            RatingMin = parser.ReadColumn< ushort >( 0 );
            RatingMax = parser.ReadColumn< ushort >( 1 );
            Name = new LazyRow< GoldSaucerTextData >( lumina, parser.ReadColumn< ushort >( 2 ), language );
            Fee = parser.ReadColumn< ushort >( 3 );
            Icon = parser.ReadColumn< int >( 4 );
        }
    }
}