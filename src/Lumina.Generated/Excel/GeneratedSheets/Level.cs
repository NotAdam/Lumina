// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Level", columnHash: 0xd3d8d868 )]
    public class Level : IExcelRow
    {
        
        public float X;
        public float Y;
        public float Z;
        public float Yaw;
        public float Radius;
        public byte Type;
        public uint Object;
        public LazyRow< Map > Map;
        public uint EventId;
        public LazyRow< TerritoryType > Territory;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            X = parser.ReadColumn< float >( 0 );
            Y = parser.ReadColumn< float >( 1 );
            Z = parser.ReadColumn< float >( 2 );
            Yaw = parser.ReadColumn< float >( 3 );
            Radius = parser.ReadColumn< float >( 4 );
            Type = parser.ReadColumn< byte >( 5 );
            Object = parser.ReadColumn< uint >( 6 );
            Map = new LazyRow< Map >( lumina, parser.ReadColumn< ushort >( 7 ), language );
            EventId = parser.ReadColumn< uint >( 8 );
            Territory = new LazyRow< TerritoryType >( lumina, parser.ReadColumn< ushort >( 9 ), language );
        }
    }
}