// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ScenarioTree", columnHash: 0x6840e93a )]
    public class ScenarioTree : ExcelRow
    {
        
        public LazyRow< ScenarioType > Type;
        public LazyRow< ScreenImage > Image;
        public uint Unknown2;
        public uint Unknown540;
        public SeString Unknown541;
        public int Unknown542;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Type = new LazyRow< ScenarioType >( lumina, parser.ReadColumn< byte >( 0 ), language );
            Image = new LazyRow< ScreenImage >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            Unknown2 = parser.ReadColumn< uint >( 2 );
            Unknown540 = parser.ReadColumn< uint >( 3 );
            Unknown541 = parser.ReadColumn< SeString >( 4 );
            Unknown542 = parser.ReadColumn< int >( 5 );
        }
    }
}