// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGMFadeType", columnHash: 0xe018b5fa )]
    public partial class BGMFadeType : ExcelRow
    {
        
        public float FadeOutTime { get; set; }
        public float FadeInTime { get; set; }
        public float FadeInStartTime { get; set; }
        public float ResumeFadeInTime { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            FadeOutTime = parser.ReadColumn< float >( 0 );
            FadeInTime = parser.ReadColumn< float >( 1 );
            FadeInStartTime = parser.ReadColumn< float >( 2 );
            ResumeFadeInTime = parser.ReadColumn< float >( 3 );
        }
    }
}