// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PartyContentCutscene", columnHash: 0x0d0ff91e )]
    public partial class PartyContentCutscene : ExcelRow
    {
        
        public LazyRow< Cutscene > Cutscene { get; set; }
        public uint Unknown1 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Cutscene = new LazyRow< Cutscene >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Unknown1 = parser.ReadColumn< uint >( 1 );
        }
    }
}