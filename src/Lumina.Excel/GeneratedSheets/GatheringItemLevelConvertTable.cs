// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringItemLevelConvertTable", columnHash: 0xde74b4c4 )]
    public class GatheringItemLevelConvertTable : ExcelRow
    {
        
        public byte GatheringItemLevel;
        public byte Stars;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            GatheringItemLevel = parser.ReadColumn< byte >( 0 );
            Stars = parser.ReadColumn< byte >( 1 );
        }
    }
}