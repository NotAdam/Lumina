// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EurekaMagiaAction", columnHash: 0x5a516458 )]
    public class EurekaMagiaAction : ExcelRow
    {
        
        public LazyRow< Action > Action;
        public byte MaxUses;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Action = new LazyRow< Action >( gameData, parser.ReadColumn< uint >( 0 ), language );
            MaxUses = parser.ReadColumn< byte >( 1 );
        }
    }
}