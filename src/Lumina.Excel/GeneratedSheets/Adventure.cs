// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Adventure", columnHash: 0xf6b785f8 )]
    public partial class Adventure : ExcelRow
    {
        
        public LazyRow< Level > Level { get; set; }
        public int MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        public LazyRow< Emote > Emote { get; set; }
        public ushort MinTime { get; set; }
        public ushort MaxTime { get; set; }
        public LazyRow< PlaceName > PlaceName { get; set; }
        public int IconList { get; set; }
        public int IconDiscovered { get; set; }
        public SeString Name { get; set; }
        public SeString Impression { get; set; }
        public SeString Description { get; set; }
        public int IconUndiscovered { get; set; }
        public bool IsInitial { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Level = new LazyRow< Level >( gameData, parser.ReadColumn< int >( 0 ), language );
            MinLevel = parser.ReadColumn< int >( 1 );
            MaxLevel = parser.ReadColumn< byte >( 2 );
            Emote = new LazyRow< Emote >( gameData, parser.ReadColumn< ushort >( 3 ), language );
            MinTime = parser.ReadColumn< ushort >( 4 );
            MaxTime = parser.ReadColumn< ushort >( 5 );
            PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadColumn< int >( 6 ), language );
            IconList = parser.ReadColumn< int >( 7 );
            IconDiscovered = parser.ReadColumn< int >( 8 );
            Name = parser.ReadColumn< SeString >( 9 );
            Impression = parser.ReadColumn< SeString >( 10 );
            Description = parser.ReadColumn< SeString >( 11 );
            IconUndiscovered = parser.ReadColumn< int >( 12 );
            IsInitial = parser.ReadColumn< bool >( 13 );
        }
    }
}