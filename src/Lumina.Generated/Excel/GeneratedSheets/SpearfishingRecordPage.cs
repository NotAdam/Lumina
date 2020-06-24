using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SpearfishingRecordPage", columnHash: 0x4f78acda )]
    public class SpearfishingRecordPage : IExcelRow
    {
        
        public byte Unknown0;
        public byte Unknown1;
        public byte Unknown2;
        public LazyRow< PlaceName > PlaceName;
        public int Image;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            PlaceName = new LazyRow< PlaceName >( lumina, parser.ReadColumn< int >( 3 ), language );
            Image = parser.ReadColumn< int >( 4 );
        }
    }
}