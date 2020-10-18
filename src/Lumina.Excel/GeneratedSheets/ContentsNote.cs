// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentsNote", columnHash: 0x748963d8 )]
    public class ContentsNote : IExcelRow
    {
        
        public byte ContentType;
        public int Icon;
        public byte MenuOrder;
        public int RequiredAmount;
        public byte Reward0;
        public int ExpMultiplier;
        public byte Reward1;
        public int GilRward;
        public ushort LevelUnlock;
        public LazyRow< HowTo > HowTo;
        public uint ReqUnlock;
        public SeString Name;
        public SeString Description;
        public int ExpCap;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ContentType = parser.ReadColumn< byte >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            MenuOrder = parser.ReadColumn< byte >( 2 );
            RequiredAmount = parser.ReadColumn< int >( 3 );
            Reward0 = parser.ReadColumn< byte >( 4 );
            ExpMultiplier = parser.ReadColumn< int >( 5 );
            Reward1 = parser.ReadColumn< byte >( 6 );
            GilRward = parser.ReadColumn< int >( 7 );
            LevelUnlock = parser.ReadColumn< ushort >( 8 );
            HowTo = new LazyRow< HowTo >( lumina, parser.ReadColumn< ushort >( 9 ), language );
            ReqUnlock = parser.ReadColumn< uint >( 10 );
            Name = parser.ReadColumn< SeString >( 11 );
            Description = parser.ReadColumn< SeString >( 12 );
            ExpCap = parser.ReadColumn< int >( 13 );
        }
    }
}