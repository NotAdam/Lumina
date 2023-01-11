// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BehaviorPath", columnHash: 0x96572d0d )]
    public partial class BehaviorPath : ExcelRow
    {
        
        public bool IsTurnTransition { get; set; }
        public bool IsFadeOut { get; set; }
        public bool IsFadeIn { get; set; }
        public bool IsWalking { get; set; }
        public bool Unknown4 { get; set; }
        public float Speed { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            IsTurnTransition = parser.ReadColumn< bool >( 0 );
            IsFadeOut = parser.ReadColumn< bool >( 1 );
            IsFadeIn = parser.ReadColumn< bool >( 2 );
            IsWalking = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Speed = parser.ReadColumn< float >( 5 );
        }
    }
}