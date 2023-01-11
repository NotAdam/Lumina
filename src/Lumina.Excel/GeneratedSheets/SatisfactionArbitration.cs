// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SatisfactionArbitration", columnHash: 0x3f77b2e9 )]
    public partial class SatisfactionArbitration : ExcelRow
    {
        
        public byte SatisfactionLevel { get; set; }
        public LazyRow< SatisfactionNpc > SatisfactionNpc { get; set; }
        public LazyRow< Quest > Quest { get; set; }
        public byte Unknown3 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            SatisfactionLevel = parser.ReadColumn< byte >( 0 );
            SatisfactionNpc = new LazyRow< SatisfactionNpc >( gameData, parser.ReadColumn< byte >( 1 ), language );
            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 2 ), language );
            Unknown3 = parser.ReadColumn< byte >( 3 );
        }
    }
}