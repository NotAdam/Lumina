using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BuddyItem", columnHash: 0xfa9fc03d )]
    public class BuddyItem : IExcelRow
    {
        
        public LazyRow< Item > Item;
        public bool UseField;
        public bool UseTraining;
        public bool Unknown3;
        public byte Status;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Item = new LazyRow< Item >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            UseField = parser.ReadColumn< bool >( 1 );
            UseTraining = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Status = parser.ReadColumn< byte >( 4 );
        }
    }
}