// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGM", columnHash: 0xc9fc6953 )]
    public class BGM : ExcelRow
    {
        
        public SeString File;
        public byte Priority;
        public bool DisableRestartTimeOut;
        public bool DisableRestart;
        public bool PassEnd;
        public float DisableRestartResetTime;
        public byte SpecialMode;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            File = parser.ReadColumn< SeString >( 0 );
            Priority = parser.ReadColumn< byte >( 1 );
            DisableRestartTimeOut = parser.ReadColumn< bool >( 2 );
            DisableRestart = parser.ReadColumn< bool >( 3 );
            PassEnd = parser.ReadColumn< bool >( 4 );
            DisableRestartResetTime = parser.ReadColumn< float >( 5 );
            SpecialMode = parser.ReadColumn< byte >( 6 );
        }
    }
}