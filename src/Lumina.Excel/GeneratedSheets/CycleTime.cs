// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CycleTime", columnHash: 0x5d58cc84 )]
    public partial class CycleTime : ExcelRow
    {
        
        public uint FirstCycle { get; set; }
        public uint Cycle { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            FirstCycle = parser.ReadColumn< uint >( 0 );
            Cycle = parser.ReadColumn< uint >( 1 );
        }
    }
}