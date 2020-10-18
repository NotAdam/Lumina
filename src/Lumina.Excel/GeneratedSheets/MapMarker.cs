// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MapMarker", columnHash: 0x58f22163 )]
    public class MapMarker : IExcelRow
    {
        
        public short X;
        public short Y;
        public ushort Icon;
        public LazyRow< PlaceName > PlaceNameSubtext;
        public byte SubtextOrientation;
        public LazyRow< MapMarkerRegion > MapMarkerRegion;
        public byte Type;
        public byte DataType;
        public ushort DataKey;
        public byte Unknown9;
        public byte Unknown10;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            X = parser.ReadColumn< short >( 0 );
            Y = parser.ReadColumn< short >( 1 );
            Icon = parser.ReadColumn< ushort >( 2 );
            PlaceNameSubtext = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 3 ), language );
            SubtextOrientation = parser.ReadColumn< byte >( 4 );
            MapMarkerRegion = new LazyRow< MapMarkerRegion >( lumina, parser.ReadColumn< byte >( 5 ), language );
            Type = parser.ReadColumn< byte >( 6 );
            DataType = parser.ReadColumn< byte >( 7 );
            DataKey = parser.ReadColumn< ushort >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
            Unknown10 = parser.ReadColumn< byte >( 10 );
        }
    }
}