using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringSubCategory", columnHash: 0x6dac8145 )]
    public class GatheringSubCategory : IExcelRow
    {
        
        public LazyRow< GatheringType > GatheringType;
        public LazyRow< ClassJob > ClassJob;
        public uint Unknown2;
        public ushort Division;
        public LazyRow< Item > Item;
        public string FolkloreBook;
        public byte Unknown6;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            GatheringType = new LazyRow< GatheringType >( lumina, parser.ReadColumn< byte >( 0 ), language );
            ClassJob = new LazyRow< ClassJob >( lumina, parser.ReadColumn< byte >( 1 ), language );
            Unknown2 = parser.ReadColumn< uint >( 2 );
            Division = parser.ReadColumn< ushort >( 3 );
            Item = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 4 ), language );
            FolkloreBook = parser.ReadColumn< string >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
        }
    }
}