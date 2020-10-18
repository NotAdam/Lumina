// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringItem", columnHash: 0x032ca4ae )]
    public class GatheringItem : IExcelRow
    {
        
        public int Item;
        public LazyRow< GatheringItemLevelConvertTable > GatheringItemLevel;
        public bool Unknown2;
        public uint IsHidden;
        public bool Unknown4;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Item = parser.ReadColumn< int >( 0 );
            GatheringItemLevel = new LazyRow< GatheringItemLevelConvertTable >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            IsHidden = parser.ReadColumn< uint >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
        }
    }
}