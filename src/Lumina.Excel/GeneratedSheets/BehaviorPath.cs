// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BehaviorPath", columnHash: 0x96572d0d )]
    public class BehaviorPath : ExcelRow
    {
        
        public bool IsTurnTransition;
        public bool IsFadeOut;
        public bool IsFadeIn;
        public bool IsWalking;
        public bool Unknown4;
        public float Speed;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            IsTurnTransition = parser.ReadColumn< bool >( 0 );
            IsFadeOut = parser.ReadColumn< bool >( 1 );
            IsFadeIn = parser.ReadColumn< bool >( 2 );
            IsWalking = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Speed = parser.ReadColumn< float >( 5 );
        }
    }
}