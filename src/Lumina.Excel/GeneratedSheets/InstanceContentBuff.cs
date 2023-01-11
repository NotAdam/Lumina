// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "InstanceContentBuff", columnHash: 0x2020acf6 )]
    public partial class InstanceContentBuff : ExcelRow
    {
        
        public ushort EchoStart { get; set; }
        public ushort EchoDeath { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            EchoStart = parser.ReadColumn< ushort >( 0 );
            EchoDeath = parser.ReadColumn< ushort >( 1 );
        }
    }
}