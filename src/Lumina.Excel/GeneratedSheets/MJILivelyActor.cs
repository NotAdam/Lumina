// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJILivelyActor", columnHash: 0xc8ec8dc5 )]
    public partial class MJILivelyActor : ExcelRow
    {
        
        public LazyRow< ENpcResident > ENPC { get; set; }
        public LazyRow< Behavior > Behavior { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float Rot { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ENPC = new LazyRow< ENpcResident >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Behavior = new LazyRow< Behavior >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            X = parser.ReadColumn< float >( 2 );
            Y = parser.ReadColumn< float >( 3 );
            Z = parser.ReadColumn< float >( 4 );
            Rot = parser.ReadColumn< float >( 5 );
        }
    }
}