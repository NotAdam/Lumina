// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MovieSubtitleVoyage", columnHash: 0x07f99ad3 )]
    public partial class MovieSubtitleVoyage : ExcelRow
    {
        
        public float StartTime { get; set; }
        public float EndTime { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            StartTime = parser.ReadColumn< float >( 0 );
            EndTime = parser.ReadColumn< float >( 1 );
        }
    }
}