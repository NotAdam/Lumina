using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "World", columnHash: 0xd4d62b80 )]
    public class World : IExcelRow
    {
        
        public string Name;
        public byte UserType;
        public LazyRow< WorldDCGroupType > DataCenter;
        public bool IsPublic;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            UserType = parser.ReadColumn< byte >( 1 );
            DataCenter = new LazyRow< WorldDCGroupType >( lumina, parser.ReadColumn< byte >( 2 ) );
            IsPublic = parser.ReadColumn< bool >( 3 );
        }
    }
}