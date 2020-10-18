// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyCraftSequence", columnHash: 0x6d444cc1 )]
    public class CompanyCraftSequence : IExcelRow
    {
        
        public LazyRow< Item > ResultItem;
        public int Category;
        public LazyRow< CompanyCraftDraftCategory > CompanyCraftDraftCategory;
        public LazyRow< CompanyCraftType > CompanyCraftType;
        public LazyRow< CompanyCraftDraft > CompanyCraftDraft;
        public LazyRow< CompanyCraftPart >[] CompanyCraftPart;
        public uint Order;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ResultItem = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 0 ), language );
            Category = parser.ReadColumn< int >( 1 );
            CompanyCraftDraftCategory = new LazyRow< CompanyCraftDraftCategory >( lumina, parser.ReadColumn< int >( 2 ), language );
            CompanyCraftType = new LazyRow< CompanyCraftType >( lumina, parser.ReadColumn< int >( 3 ), language );
            CompanyCraftDraft = new LazyRow< CompanyCraftDraft >( lumina, parser.ReadColumn< int >( 4 ), language );
            CompanyCraftPart = new LazyRow< CompanyCraftPart >[ 8 ];
            for( var i = 0; i < 8; i++ )
                CompanyCraftPart[ i ] = new LazyRow< CompanyCraftPart >( lumina, parser.ReadColumn< ushort >( 5 + i ), language );
            Order = parser.ReadColumn< uint >( 13 );
        }
    }
}