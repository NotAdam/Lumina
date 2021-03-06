// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Achievement", columnHash: 0x24bfffd6 )]
    public class Achievement : ExcelRow
    {
        
        public LazyRow< AchievementCategory > AchievementCategory { get; set; }
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public byte Points { get; set; }
        public LazyRow< Title > Title { get; set; }
        public LazyRow< Item > Item { get; set; }
        public ushort Icon { get; set; }
        public byte Unknown7 { get; set; }
        public byte Type { get; set; }
        public int Key { get; set; }
        public int[] Data { get; set; }
        public ushort Order { get; set; }
        public byte Unknown19 { get; set; }
        public LazyRow< AchievementHideCondition > AchievementHideCondition { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            AchievementCategory = new LazyRow< AchievementCategory >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Name = parser.ReadColumn< SeString >( 1 );
            Description = parser.ReadColumn< SeString >( 2 );
            Points = parser.ReadColumn< byte >( 3 );
            Title = new LazyRow< Title >( gameData, parser.ReadColumn< ushort >( 4 ), language );
            Item = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 5 ), language );
            Icon = parser.ReadColumn< ushort >( 6 );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            Type = parser.ReadColumn< byte >( 8 );
            Key = parser.ReadColumn< int >( 9 );
            Data = new int[ 8 ];
            for( var i = 0; i < 8; i++ )
                Data[ i ] = parser.ReadColumn< int >( 10 + i );
            Order = parser.ReadColumn< ushort >( 18 );
            Unknown19 = parser.ReadColumn< byte >( 19 );
            AchievementHideCondition = new LazyRow< AchievementHideCondition >( gameData, parser.ReadColumn< byte >( 20 ), language );
        }
    }
}