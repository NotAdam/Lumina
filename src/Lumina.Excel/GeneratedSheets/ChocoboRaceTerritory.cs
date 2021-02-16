// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceTerritory", columnHash: 0x39e8d543 )]
    public class ChocoboRaceTerritory : ExcelRow
    {
        
        public LazyRow< GoldSaucerTextData > Name;
        public int Icon;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = new LazyRow< GoldSaucerTextData >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            Icon = parser.ReadColumn< int >( 1 );
        }
    }
}