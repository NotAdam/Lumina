// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentsNote", columnHash: 0x748963d8 )]
    public partial class ContentsNote : ExcelRow
    {
        
        public byte ContentType { get; set; }
        public int Icon { get; set; }
        public byte MenuOrder { get; set; }
        public int RequiredAmount { get; set; }
        public byte Reward0 { get; set; }
        public int ExpMultiplier { get; set; }
        public byte Reward1 { get; set; }
        public int GilRward { get; set; }
        public ushort LevelUnlock { get; set; }
        public LazyRow< HowTo > HowTo { get; set; }
        public uint ReqUnlock { get; set; }
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public int ExpCap { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ContentType = parser.ReadColumn< byte >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            MenuOrder = parser.ReadColumn< byte >( 2 );
            RequiredAmount = parser.ReadColumn< int >( 3 );
            Reward0 = parser.ReadColumn< byte >( 4 );
            ExpMultiplier = parser.ReadColumn< int >( 5 );
            Reward1 = parser.ReadColumn< byte >( 6 );
            GilRward = parser.ReadColumn< int >( 7 );
            LevelUnlock = parser.ReadColumn< ushort >( 8 );
            HowTo = new LazyRow< HowTo >( gameData, parser.ReadColumn< ushort >( 9 ), language );
            ReqUnlock = parser.ReadColumn< uint >( 10 );
            Name = parser.ReadColumn< SeString >( 11 );
            Description = parser.ReadColumn< SeString >( 12 );
            ExpCap = parser.ReadColumn< int >( 13 );
        }
    }
}