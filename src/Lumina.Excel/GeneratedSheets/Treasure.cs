// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Treasure", columnHash: 0x030e840a )]
    public partial class Treasure : ExcelRow
    {
        
        public SeString Unknown0 { get; set; }
        public sbyte Unknown1 { get; set; }
        public SeString Unknown2 { get; set; }
        public sbyte Unknown3 { get; set; }
        public sbyte Unknown4 { get; set; }
        public sbyte Unknown5 { get; set; }
        public sbyte Unknown6 { get; set; }
        public sbyte Unknown7 { get; set; }
        public LazyRow< ExportedSG > SGB { get; set; }
        public bool Unknown9 { get; set; }
        public bool Unknown10 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< sbyte >( 1 );
            Unknown2 = parser.ReadColumn< SeString >( 2 );
            Unknown3 = parser.ReadColumn< sbyte >( 3 );
            Unknown4 = parser.ReadColumn< sbyte >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
            Unknown6 = parser.ReadColumn< sbyte >( 6 );
            Unknown7 = parser.ReadColumn< sbyte >( 7 );
            SGB = new LazyRow< ExportedSG >( gameData, parser.ReadColumn< uint >( 8 ), language );
            Unknown9 = parser.ReadColumn< bool >( 9 );
            Unknown10 = parser.ReadColumn< bool >( 10 );
        }
    }
}