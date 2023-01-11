// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRace", columnHash: 0xde74b4c4 )]
    public partial class ChocoboRace : ExcelRow
    {
        
        public LazyRow< ChocoboRaceRank > ChocoboRaceRank { get; set; }
        public LazyRow< ChocoboRaceTerritory > ChocoboRaceTerritory { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ChocoboRaceRank = new LazyRow< ChocoboRaceRank >( gameData, parser.ReadColumn< byte >( 0 ), language );
            ChocoboRaceTerritory = new LazyRow< ChocoboRaceTerritory >( gameData, parser.ReadColumn< byte >( 1 ), language );
        }
    }
}