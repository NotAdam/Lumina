// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGMScene", columnHash: 0x2711a5ea )]
    public partial class BGMScene : ExcelRow
    {
        
        public bool EnableDisableRestart { get; set; }
        public bool Resume { get; set; }
        public bool EnablePassEnd { get; set; }
        public bool ForceAutoReset { get; set; }
        public bool IgnoreBattle { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            EnableDisableRestart = parser.ReadColumn< bool >( 0 );
            Resume = parser.ReadColumn< bool >( 1 );
            EnablePassEnd = parser.ReadColumn< bool >( 2 );
            ForceAutoReset = parser.ReadColumn< bool >( 3 );
            IgnoreBattle = parser.ReadColumn< bool >( 4 );
        }
    }
}