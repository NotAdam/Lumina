// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Perform", columnHash: 0x7bf81fa9 )]
    public partial class Perform : ExcelRow
    {
        
        public SeString Name { get; set; }
        public bool Unknown1 { get; set; }
        public ulong ModelKey { get; set; }
        public LazyRow< ActionTimeline > AnimationStart { get; set; }
        public LazyRow< ActionTimeline > AnimationEnd { get; set; }
        public LazyRow< ActionTimeline > AnimationIdle { get; set; }
        public LazyRow< ActionTimeline > AnimationPlay01 { get; set; }
        public LazyRow< ActionTimeline > AnimationPlay02 { get; set; }
        public LazyRow< ActionTimeline > StopAnimation { get; set; }
        public SeString Instrument { get; set; }
        public int Order { get; set; }
        public LazyRow< PerformTransient > Transient { get; set; }
        public byte Unknown12 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            ModelKey = parser.ReadColumn< ulong >( 2 );
            AnimationStart = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 3 ), language );
            AnimationEnd = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 4 ), language );
            AnimationIdle = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 5 ), language );
            AnimationPlay01 = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 6 ), language );
            AnimationPlay02 = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 7 ), language );
            StopAnimation = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< int >( 8 ), language );
            Instrument = parser.ReadColumn< SeString >( 9 );
            Order = parser.ReadColumn< int >( 10 );
            Transient = new LazyRow< PerformTransient >( gameData, parser.ReadColumn< byte >( 11 ), language );
            Unknown12 = parser.ReadColumn< byte >( 12 );
        }
    }
}