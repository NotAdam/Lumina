// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Achievement", columnHash: 0x24bfffd6 )]
    public class Achievement : IExcelRow
    {
        
        public LazyRow< AchievementCategory > AchievementCategory;
        public string Name;
        public string Description;
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
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            AchievementCategory = new LazyRow< AchievementCategory >( lumina, parser.ReadColumn< byte >( 0 ), language );
            Name = parser.ReadColumn< string >( 1 );
            Description = parser.ReadColumn< string >( 2 );
            Points = parser.ReadColumn< byte >( 3 );
            Title = new LazyRow< Title >( lumina, parser.ReadColumn< ushort >( 4 ), language );
            Item = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 5 ), language );
            Icon = parser.ReadColumn< ushort >( 6 );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            Type = parser.ReadColumn< byte >( 8 );
            Key = parser.ReadColumn< int >( 9 );
            Data = new int[ 8 ];
            for( var i = 0; i < 8; i++ )
                Data[ i ] = parser.ReadColumn< int >( 10 + i );
            Order = parser.ReadColumn< ushort >( 18 );
            Unknown19 = parser.ReadColumn< byte >( 19 );
            AchievementHideCondition = new LazyRow< AchievementHideCondition >( lumina, parser.ReadColumn< byte >( 20 ), language );
        }
    }
}