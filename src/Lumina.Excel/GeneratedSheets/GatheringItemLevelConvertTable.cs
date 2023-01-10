// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringItemLevelConvertTable", columnHash: 0xde74b4c4 )]
    public partial class GatheringItemLevelConvertTable : ExcelRow
    {
        
        public byte GatheringItemLevel { get; set; }
        public byte Stars { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            GatheringItemLevel = parser.ReadColumn< byte >( 0 );
            Stars = parser.ReadColumn< byte >( 1 );
        }
    }
}