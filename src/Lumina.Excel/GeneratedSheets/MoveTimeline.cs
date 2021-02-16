// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MoveTimeline", columnHash: 0xf057da9c )]
    public class MoveTimeline : ExcelRow
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
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Idle = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            MoveForward = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            MoveBack = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 2 ), language );
            MoveLeft = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 3 ), language );
            MoveRight = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 4 ), language );
            MoveUp = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 5 ), language );
            MoveDown = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 6 ), language );
            MoveTurnLeft = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 7 ), language );
            MoveTurnRight = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 8 ), language );
            Extra = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 9 ), language );
        }
    }
}