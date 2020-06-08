using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MainCommand", columnHash: 0x63da0c66 )]
    public class MainCommand : IExcelRow
    {
        
        public int Icon;
        public byte Category;
        public LazyRow< MainCommandCategory > MainCommandCategory;
        public sbyte SortID;
        public string Name;
        public string Description;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Icon = parser.ReadColumn< int >( 0 );
            Category = parser.ReadColumn< byte >( 1 );
            MainCommandCategory = new LazyRow< MainCommandCategory >( lumina, parser.ReadColumn< byte >( 2 ) );
            SortID = parser.ReadColumn< sbyte >( 3 );
            Name = parser.ReadColumn< string >( 4 );
            Description = parser.ReadColumn< string >( 5 );
        }
    }
}