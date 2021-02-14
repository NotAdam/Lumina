// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Perform", columnHash: 0x48a99e9c )]
    public class Perform : ExcelRow
    {
        
        public SeString Name;
        public bool Unknown1;
        public ulong ModelKey;
        public LazyRow< ActionTimeline > AnimationStart;
        public LazyRow< ActionTimeline > AnimationEnd;
        public LazyRow< ActionTimeline > AnimationIdle;
        public LazyRow< ActionTimeline > AnimationPlay01;
        public LazyRow< ActionTimeline > AnimationPlay02;
        public LazyRow< ActionTimeline > StopAnimation;
        public SeString Instrument;
        public int Unknown10;
        public LazyRow< PerformTransient > Transient;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            ModelKey = parser.ReadColumn< ulong >( 2 );
            AnimationStart = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 3 ), language );
            AnimationEnd = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 4 ), language );
            AnimationIdle = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 5 ), language );
            AnimationPlay01 = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 6 ), language );
            AnimationPlay02 = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 7 ), language );
            StopAnimation = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< int >( 8 ), language );
            Instrument = parser.ReadColumn< SeString >( 9 );
            Unknown10 = parser.ReadColumn< int >( 10 );
            Transient = new LazyRow< PerformTransient >( lumina, parser.ReadColumn< byte >( 11 ), language );
        }
    }
}