using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Relic3", columnHash: 0xeb3c566a )]
    public class Relic3 : IExcelRow
    {
        
        public LazyRow< Item > ItemAnimus;
        public LazyRow< Item > ItemScroll;
        public byte MateriaLimit;
        public LazyRow< Item > ItemNovus;
        public int Icon;
        public sbyte Unknown5;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ItemAnimus = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 0 ) );
            ItemScroll = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 1 ) );
            MateriaLimit = parser.ReadColumn< byte >( 2 );
            ItemNovus = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 3 ) );
            Icon = parser.ReadColumn< int >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
        }
    }
}