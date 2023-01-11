// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Achievement", columnHash: 0x6cfd2977 )]
    public partial class Achievement : ExcelRow
    {
        
        public LazyRow< AchievementCategory > AchievementCategory { get; set; }
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public LazyRow< AchievementTarget > AchievementTarget { get; set; }
        public byte Unknown4 { get; set; }
        public byte Points { get; set; }
        public LazyRow< Title > Title { get; set; }
        public LazyRow< Item > Item { get; set; }
        public byte Unknown8 { get; set; }
        public byte Unknown9 { get; set; }
        public byte Unknown10 { get; set; }
        public ushort Icon { get; set; }
        public byte Unknown12 { get; set; }
        public byte Type { get; set; }
        public int Key { get; set; }
        public int[] Data { get; set; }
        public ushort Order { get; set; }
        public byte Unknown24 { get; set; }
        public LazyRow< AchievementHideCondition > AchievementHideCondition { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            AchievementCategory = new LazyRow< AchievementCategory >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Name = parser.ReadColumn< SeString >( 1 );
            Description = parser.ReadColumn< SeString >( 2 );
            AchievementTarget = new LazyRow< AchievementTarget >( gameData, parser.ReadColumn< byte >( 3 ), language );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Points = parser.ReadColumn< byte >( 5 );
            Title = new LazyRow< Title >( gameData, parser.ReadColumn< ushort >( 6 ), language );
            Item = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 7 ), language );
            Unknown8 = parser.ReadColumn< byte >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
            Unknown10 = parser.ReadColumn< byte >( 10 );
            Icon = parser.ReadColumn< ushort >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            Type = parser.ReadColumn< byte >( 13 );
            Key = parser.ReadColumn< int >( 14 );
            Data = new int[ 8 ];
            for( var i = 0; i < 8; i++ )
                Data[ i ] = parser.ReadColumn< int >( 15 + i );
            Order = parser.ReadColumn< ushort >( 23 );
            Unknown24 = parser.ReadColumn< byte >( 24 );
            AchievementHideCondition = new LazyRow< AchievementHideCondition >( gameData, parser.ReadColumn< byte >( 25 ), language );
        }
    }
}