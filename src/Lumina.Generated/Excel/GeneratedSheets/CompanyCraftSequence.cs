using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyCraftSequence", columnHash: 0x6d444cc1 )]
    public class CompanyCraftSequence : IExcelRow
    {
        
        public LazyRow< Item > ResultItem;
        public int Unknown1;
        public LazyRow< CompanyCraftDraftCategory > CompanyCraftDraftCategory;
        public LazyRow< CompanyCraftType > CompanyCraftType;
        public LazyRow< CompanyCraftDraft > CompanyCraftDraft;
        public LazyRow< CompanyCraftPart >[] CompanyCraftPart;
        public uint Unknown13;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ResultItem = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 0 ) );
            Unknown1 = parser.ReadColumn< int >( 1 );
            CompanyCraftDraftCategory = new LazyRow< CompanyCraftDraftCategory >( lumina, parser.ReadColumn< int >( 2 ) );
            CompanyCraftType = new LazyRow< CompanyCraftType >( lumina, parser.ReadColumn< int >( 3 ) );
            CompanyCraftDraft = new LazyRow< CompanyCraftDraft >( lumina, parser.ReadColumn< int >( 4 ) );
            for( var i = 0; i < 8; i++ )
                CompanyCraftPart[ i ] = new LazyRow< CompanyCraftPart >( lumina, parser.ReadColumn< ushort >( 5 + i ) );
            Unknown13 = parser.ReadColumn< uint >( 13 );
        }
    }
}