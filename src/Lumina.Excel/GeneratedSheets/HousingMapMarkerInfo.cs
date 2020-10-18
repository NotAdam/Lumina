// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingMapMarkerInfo", columnHash: 0x13236296 )]
    public class HousingMapMarkerInfo : IExcelRow
    {
        
        public float X;
        public float Y;
        public float Z;
        public float Unknown3;
        public LazyRow< Map > Map;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            X = parser.ReadColumn< float >( 0 );
            Y = parser.ReadColumn< float >( 1 );
            Z = parser.ReadColumn< float >( 2 );
            Unknown3 = parser.ReadColumn< float >( 3 );
            Map = new LazyRow< Map >( lumina, parser.ReadColumn< ushort >( 4 ), language );
        }
    }
}