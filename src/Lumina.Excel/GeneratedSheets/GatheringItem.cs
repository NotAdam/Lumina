// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringItem", columnHash: 0x032ca4ae )]
    public class GatheringItem : ExcelRow
    {
        
        public int Item;
        public LazyRow< GatheringItemLevelConvertTable > GatheringItemLevel;
        public bool Unknown2;
        public uint Unknown3;
        public bool IsHidden;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Item = parser.ReadColumn< int >( 0 );
            GatheringItemLevel = new LazyRow< GatheringItemLevelConvertTable >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< uint >( 3 );
            IsHidden = parser.ReadColumn< bool >( 4 );
        }
    }
}