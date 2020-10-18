// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRace", columnHash: 0xde74b4c4 )]
    public class ChocoboRace : IExcelRow
    {
        
        public LazyRow< ChocoboRaceRank > ChocoboRaceRank;
        public LazyRow< ChocoboRaceTerritory > ChocoboRaceTerritory;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ChocoboRaceRank = new LazyRow< ChocoboRaceRank >( lumina, parser.ReadColumn< byte >( 0 ), language );
            ChocoboRaceTerritory = new LazyRow< ChocoboRaceTerritory >( lumina, parser.ReadColumn< byte >( 1 ), language );
        }
    }
}