// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRace", columnHash: 0xde74b4c4 )]
    public class ChocoboRace : ExcelRow
    {
        
        public LazyRow< ChocoboRaceRank > ChocoboRaceRank;
        public LazyRow< ChocoboRaceTerritory > ChocoboRaceTerritory;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            ChocoboRaceRank = new LazyRow< ChocoboRaceRank >( lumina, parser.ReadColumn< byte >( 0 ), language );
            ChocoboRaceTerritory = new LazyRow< ChocoboRaceTerritory >( lumina, parser.ReadColumn< byte >( 1 ), language );
        }
    }
}