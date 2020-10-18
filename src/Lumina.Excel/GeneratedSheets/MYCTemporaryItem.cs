// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MYCTemporaryItem", columnHash: 0x9176820b )]
    public class MYCTemporaryItem : IExcelRow
    {
        
        public LazyRow< MYCTemporaryItemUICategory > Category;
        public byte Type;
        public LazyRow< Action > Action;
        public byte Max;
        public byte Weight;
        public byte Order;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Category = new LazyRow< MYCTemporaryItemUICategory >( lumina, parser.ReadColumn< byte >( 0 ), language );
            Type = parser.ReadColumn< byte >( 1 );
            Action = new LazyRow< Action >( lumina, parser.ReadColumn< uint >( 2 ), language );
            Max = parser.ReadColumn< byte >( 3 );
            Weight = parser.ReadColumn< byte >( 4 );
            Order = parser.ReadColumn< byte >( 5 );
        }
    }
}