using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MoveTimeline", columnHash: 0xf057da9c )]
    public class MoveTimeline : IExcelRow
    {
        
        public LazyRow< ActionTimeline > Idle;
        public LazyRow< ActionTimeline > MoveForward;
        public LazyRow< ActionTimeline > MoveBack;
        public LazyRow< ActionTimeline > MoveLeft;
        public LazyRow< ActionTimeline > MoveRight;
        public LazyRow< ActionTimeline > MoveUp;
        public LazyRow< ActionTimeline > MoveDown;
        public LazyRow< ActionTimeline > MoveTurnLeft;
        public LazyRow< ActionTimeline > MoveTurnRight;
        public LazyRow< ActionTimeline > Extra;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Idle = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 0 ) );
            MoveForward = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 1 ) );
            MoveBack = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 2 ) );
            MoveLeft = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 3 ) );
            MoveRight = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 4 ) );
            MoveUp = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 5 ) );
            MoveDown = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 6 ) );
            MoveTurnLeft = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 7 ) );
            MoveTurnRight = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 8 ) );
            Extra = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 9 ) );
        }
    }
}