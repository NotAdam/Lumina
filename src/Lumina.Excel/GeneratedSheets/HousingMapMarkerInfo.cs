// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingMapMarkerInfo", columnHash: 0x13236296 )]
    public partial class HousingMapMarkerInfo : ExcelRow
    {
        
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float Unknown3 { get; set; }
        public LazyRow< Map > Map { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            X = parser.ReadColumn< float >( 0 );
            Y = parser.ReadColumn< float >( 1 );
            Z = parser.ReadColumn< float >( 2 );
            Unknown3 = parser.ReadColumn< float >( 3 );
            Map = new LazyRow< Map >( gameData, parser.ReadColumn< ushort >( 4 ), language );
        }
    }
}