using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FCRights", columnHash: 0xce73d687 )]
    public class FCRights : IExcelRow
    {
        
        public string Name;
        public string Description;
        public ushort Icon;
        public LazyRow< FCRank > FCRank;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Description = parser.ReadColumn< string >( 1 );
            Icon = parser.ReadColumn< ushort >( 2 );
            FCRank = new LazyRow< FCRank >( lumina, parser.ReadColumn< byte >( 3 ), language );
        }
    }
}