using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Perform", columnHash: 0x48a99e9c )]
    public class Perform : IExcelRow
    {
        
        public string Name;
        public bool Unknown1;
        public ulong ModelKey;
        public LazyRow< ActionTimeline > AnimationStart;
        public LazyRow< ActionTimeline > AnimationEnd;
        public LazyRow< ActionTimeline > AnimationIdle;
        public LazyRow< ActionTimeline > AnimationPlay01;
        public LazyRow< ActionTimeline > AnimationPlay02;
        public LazyRow< ActionTimeline > StopAnimation;
        public string Instrument;
        public int Unknown10;
        public LazyRow< PerformTransient > Transient;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            ModelKey = parser.ReadColumn< ulong >( 2 );
            AnimationStart = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 3 ) );
            AnimationEnd = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 4 ) );
            AnimationIdle = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 5 ) );
            AnimationPlay01 = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 6 ) );
            AnimationPlay02 = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 7 ) );
            StopAnimation = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< int >( 8 ) );
            Instrument = parser.ReadColumn< string >( 9 );
            Unknown10 = parser.ReadColumn< int >( 10 );
            Transient = new LazyRow< PerformTransient >( lumina, parser.ReadColumn< byte >( 11 ) );
        }
    }
}