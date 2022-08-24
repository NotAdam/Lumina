// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentGauge", columnHash: 0x55e3560d )]
    public partial class ContentGauge : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public SeString Name { get; set; }
        public LazyRow< ContentGaugeColor > Color { get; set; }
        public bool Unknown3 { get; set; }
        public SeString TextString { get; set; }
        public short Unknown5 { get; set; }
        public sbyte Unknown6 { get; set; }
        public byte Unknown7 { get; set; }
        public short Unknown8 { get; set; }
        public sbyte Unknown9 { get; set; }
        public byte Unknown10 { get; set; }
        public short Unknown11 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Name = parser.ReadColumn< SeString >( 1 );
            Color = new LazyRow< ContentGaugeColor >( gameData, parser.ReadColumn< byte >( 2 ), language );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            TextString = parser.ReadColumn< SeString >( 4 );
            Unknown5 = parser.ReadColumn< short >( 5 );
            Unknown6 = parser.ReadColumn< sbyte >( 6 );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            Unknown8 = parser.ReadColumn< short >( 8 );
            Unknown9 = parser.ReadColumn< sbyte >( 9 );
            Unknown10 = parser.ReadColumn< byte >( 10 );
            Unknown11 = parser.ReadColumn< short >( 11 );
        }
    }
}