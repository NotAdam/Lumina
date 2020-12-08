// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ScenarioTree", columnHash: 0x6840e93a )]
    public class ScenarioTree : IExcelRow
    {
        
        public LazyRow< ScenarioType > Type;
        public LazyRow< ScreenImage > Image;
        public uint Unknown2;
        public uint Unknown540;
        public SeString Unknown541;
        public int Unknown542;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Type = new LazyRow< ScenarioType >( lumina, parser.ReadColumn< byte >( 0 ), language );
            Image = new LazyRow< ScreenImage >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            Unknown2 = parser.ReadColumn< uint >( 2 );
            Unknown540 = parser.ReadColumn< uint >( 3 );
            Unknown541 = parser.ReadColumn< SeString >( 4 );
            Unknown542 = parser.ReadColumn< int >( 5 );
        }
    }
}