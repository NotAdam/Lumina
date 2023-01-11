// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDGathererInspectionReward", columnHash: 0x2020acf6 )]
    public partial class HWDGathererInspectionReward : ExcelRow
    {
        
        public ushort Scrips { get; set; }
        public ushort Points { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Scrips = parser.ReadColumn< ushort >( 0 );
            Points = parser.ReadColumn< ushort >( 1 );
        }
    }
}