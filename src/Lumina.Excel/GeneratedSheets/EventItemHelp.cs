// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventItemHelp", columnHash: 0x8e477c70 )]
    public partial class EventItemHelp : ExcelRow
    {
        
        public SeString Description { get; set; }
        public bool Unknown1 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Description = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
        }
    }
}