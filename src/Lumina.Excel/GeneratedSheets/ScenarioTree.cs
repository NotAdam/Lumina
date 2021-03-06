// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ScenarioTree", columnHash: 0x6840e93a )]
    public class ScenarioTree : ExcelRow
    {
        
        public LazyRow< ScenarioType > Type { get; set; }
        public LazyRow< ScreenImage > Image { get; set; }
        public uint Unknown2 { get; set; }
        public uint Unknown540 { get; set; }
        public SeString Unknown541 { get; set; }
        public int Unknown542 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Type = new LazyRow< ScenarioType >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Image = new LazyRow< ScreenImage >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            Unknown2 = parser.ReadColumn< uint >( 2 );
            Unknown540 = parser.ReadColumn< uint >( 3 );
            Unknown541 = parser.ReadColumn< SeString >( 4 );
            Unknown542 = parser.ReadColumn< int >( 5 );
        }
    }
}