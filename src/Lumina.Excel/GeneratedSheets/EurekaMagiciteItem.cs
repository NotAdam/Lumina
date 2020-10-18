// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EurekaMagiciteItem", columnHash: 0xbc638df5 )]
    public class EurekaMagiciteItem : IExcelRow
    {
        
        public LazyRow< EurekaMagiciteItemType > EurekaMagiciteItemType;
        public LazyRow< ClassJobCategory > ClassJobCategory;
        public LazyRow< Item > Item;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            EurekaMagiciteItemType = new LazyRow< EurekaMagiciteItemType >( lumina, parser.ReadColumn< byte >( 0 ), language );
            ClassJobCategory = new LazyRow< ClassJobCategory >( lumina, parser.ReadColumn< byte >( 1 ), language );
            Item = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 2 ), language );
        }
    }
}