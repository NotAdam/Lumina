// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemBarterCheck", columnHash: 0x8920dbd8 )]
    public class ItemBarterCheck : IExcelRow
    {
        
        public ushort Category;
        public uint Question;
        public LazyRow< Addon > Confirm;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Category = parser.ReadColumn< ushort >( 0 );
            Question = parser.ReadColumn< uint >( 1 );
            Confirm = new LazyRow< Addon >( lumina, parser.ReadColumn< uint >( 2 ), language );
        }
    }
}