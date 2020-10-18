// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringItemLevelConvertTable", columnHash: 0xde74b4c4 )]
    public class GatheringItemLevelConvertTable : IExcelRow
    {
        
        public byte GatheringItemLevel;
        public byte Stars;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            GatheringItemLevel = parser.ReadColumn< byte >( 0 );
            Stars = parser.ReadColumn< byte >( 1 );
        }
    }
}