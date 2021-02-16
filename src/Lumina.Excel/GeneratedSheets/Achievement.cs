// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Achievement", columnHash: 0x24bfffd6 )]
    public class Achievement : ExcelRow
    {
        
        public LazyRow< AchievementCategory > AchievementCategory;
        public SeString Name;
        public SeString Description;
        public byte Points;
        public LazyRow< Title > Title;
        public LazyRow< Item > Item;
        public ushort Icon;
        public byte Unknown7;
        public byte Type;
        public int Key;
        public int[] Data;
        public ushort Order;
        public byte Unknown19;
        public LazyRow< AchievementHideCondition > AchievementHideCondition;
        

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