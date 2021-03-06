// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentGauge", columnHash: 0xf678f7f7 )]
    public class ContentGauge : ExcelRow
    {
        
        public SeString Name { get; set; }
        public LazyRow< ContentGaugeColor > Color { get; set; }
        public bool Unknown2 { get; set; }
        public SeString TextString { get; set; }
        public sbyte Unknown4 { get; set; }
        public sbyte Unknown5 { get; set; }
        public byte Unknown6 { get; set; }
        public sbyte Unknown7 { get; set; }
        public sbyte Unknown8 { get; set; }
        public byte Unknown9 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Color = new LazyRow< ContentGaugeColor >( gameData, parser.ReadColumn< byte >( 1 ), language );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            TextString = parser.ReadColumn< SeString >( 3 );
            Unknown4 = parser.ReadColumn< sbyte >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< sbyte >( 7 );
            Unknown8 = parser.ReadColumn< sbyte >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
        }
    }
}