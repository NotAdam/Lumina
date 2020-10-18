// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyAction", columnHash: 0xde0dd9cf )]
    public class CompanyAction : IExcelRow
    {
        
        public SeString Name;
        public SeString Description;
        public int Icon;
        public LazyRow< FCRank > FCRank;
        public uint Cost;
        public byte Order;
        public bool Purchasable;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< SeString >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
            Icon = parser.ReadColumn< int >( 2 );
            FCRank = new LazyRow< FCRank >( lumina, parser.ReadColumn< byte >( 3 ), language );
            Cost = parser.ReadColumn< uint >( 4 );
            Order = parser.ReadColumn< byte >( 5 );
            Purchasable = parser.ReadColumn< bool >( 6 );
        }
    }
}