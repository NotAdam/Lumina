// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Level", columnHash: 0xd3d8d868 )]
    public partial class Level : ExcelRow
    {
        
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float Yaw { get; set; }
        public float Radius { get; set; }
        public byte Type { get; set; }
        public uint Object { get; set; }
        public LazyRow< Map > Map { get; set; }
        public uint EventId { get; set; }
        public LazyRow< TerritoryType > Territory { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            X = parser.ReadColumn< float >( 0 );
            Y = parser.ReadColumn< float >( 1 );
            Z = parser.ReadColumn< float >( 2 );
            Yaw = parser.ReadColumn< float >( 3 );
            Radius = parser.ReadColumn< float >( 4 );
            Type = parser.ReadColumn< byte >( 5 );
            Object = parser.ReadColumn< uint >( 6 );
            Map = new LazyRow< Map >( gameData, parser.ReadColumn< ushort >( 7 ), language );
            EventId = parser.ReadColumn< uint >( 8 );
            Territory = new LazyRow< TerritoryType >( gameData, parser.ReadColumn< ushort >( 9 ), language );
        }
    }
}