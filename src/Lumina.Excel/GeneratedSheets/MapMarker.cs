// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MapMarker", columnHash: 0x58f22163 )]
    public partial class MapMarker : ExcelRow
    {
        
        public short X { get; set; }
        public short Y { get; set; }
        public ushort Icon { get; set; }
        public LazyRow< PlaceName > PlaceNameSubtext { get; set; }
        public byte SubtextOrientation { get; set; }
        public LazyRow< MapMarkerRegion > MapMarkerRegion { get; set; }
        public byte Type { get; set; }
        public byte DataType { get; set; }
        public ushort DataKey { get; set; }
        public byte Unknown9 { get; set; }
        public byte Unknown10 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            X = parser.ReadColumn< short >( 0 );
            Y = parser.ReadColumn< short >( 1 );
            Icon = parser.ReadColumn< ushort >( 2 );
            PlaceNameSubtext = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 3 ), language );
            SubtextOrientation = parser.ReadColumn< byte >( 4 );
            MapMarkerRegion = new LazyRow< MapMarkerRegion >( gameData, parser.ReadColumn< byte >( 5 ), language );
            Type = parser.ReadColumn< byte >( 6 );
            DataType = parser.ReadColumn< byte >( 7 );
            DataKey = parser.ReadColumn< ushort >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
            Unknown10 = parser.ReadColumn< byte >( 10 );
        }
    }
}