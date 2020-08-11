// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingExterior", columnHash: 0xb56595e0 )]
    public class HousingExterior : IExcelRow
    {
        
        public byte Unknown0;
        public byte Unknown1;
        public LazyRow< PlaceName > PlaceName;
        public byte HousingSize;
        public string Model;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            PlaceName = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 2 ), language );
            HousingSize = parser.ReadColumn< byte >( 3 );
            Model = parser.ReadColumn< string >( 4 );
        }
    }
}