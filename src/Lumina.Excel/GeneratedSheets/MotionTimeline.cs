// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MotionTimeline", columnHash: 0xd5952f72 )]
    public class MotionTimeline : ExcelRow
    {
        
        public SeString Filename;
        public byte BlendGroup;
        public bool IsLoop;
        public bool IsBlinkEnable;
        public bool IsLipEnable;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Filename = parser.ReadColumn< SeString >( 0 );
            BlendGroup = parser.ReadColumn< byte >( 1 );
            IsLoop = parser.ReadColumn< bool >( 2 );
            IsBlinkEnable = parser.ReadColumn< bool >( 3 );
            IsLipEnable = parser.ReadColumn< bool >( 4 );
        }
    }
}