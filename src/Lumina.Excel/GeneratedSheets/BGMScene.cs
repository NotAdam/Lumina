// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGMScene", columnHash: 0x2711a5ea )]
    public class BGMScene : ExcelRow
    {
        
        public bool EnableDisableRestart;
        public bool Resume;
        public bool EnablePassEnd;
        public bool ForceAutoReset;
        public bool IgnoreBattle;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            EnableDisableRestart = parser.ReadColumn< bool >( 0 );
            Resume = parser.ReadColumn< bool >( 1 );
            EnablePassEnd = parser.ReadColumn< bool >( 2 );
            ForceAutoReset = parser.ReadColumn< bool >( 3 );
            IgnoreBattle = parser.ReadColumn< bool >( 4 );
        }
    }
}