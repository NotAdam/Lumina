// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Fate", columnHash: 0x7448945f )]
    public class Fate : ExcelRow
    {
        
        public byte EurekaFate { get; set; }
        public byte Rule { get; set; }
        public ushort FateRuleEx { get; set; }
        public uint Location { get; set; }
        public byte ClassJobLevel { get; set; }
        public byte ClassJobLevelMax { get; set; }
        public LazyRow< EventItem > EventItem { get; set; }
        public byte[] TypeToDoValue { get; set; }
        public uint IconObjective { get; set; }
        public uint IconMap { get; set; }
        public uint IconInactiveMap { get; set; }
        public LazyRow< BGM > Music { get; set; }
        public uint LGBGuardNPCLocation { get; set; }
        public LazyRow< ScreenImage > ScreenImageAccept { get; set; }
        public LazyRow< ScreenImage > ScreenImageComplete { get; set; }
        public LazyRow< ScreenImage > ScreenImageFailed { get; set; }
        public byte Unknown18 { get; set; }
        public uint Unknown19 { get; set; }
        public bool SpecialFate { get; set; }
        public bool Unknown21 { get; set; }
        public LazyRow< Status > GivenStatus { get; set; }
        public ushort Unknown23 { get; set; }
        public bool AdventEvent { get; set; }
        public bool MoonFaireEvent { get; set; }
        public bool Unknown26 { get; set; }
        public uint FATEChain { get; set; }
        public byte Unknown28 { get; set; }
        public ushort Unknown29 { get; set; }
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public SeString Objective { get; set; }
        public SeString[] StatusText { get; set; }
        public LazyRow< ArrayEventHandler > ArrayIndex { get; set; }
        public uint Unknown37 { get; set; }
        public LazyRow< EventItem > ReqEventItem { get; set; }
        public LazyRow< EventItem > TurnInEventItem { get; set; }
        public ushort[] ObjectiveIcon { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            EurekaFate = parser.ReadColumn< byte >( 0 );
            Rule = parser.ReadColumn< byte >( 1 );
            FateRuleEx = parser.ReadColumn< ushort >( 2 );
            Location = parser.ReadColumn< uint >( 3 );
            ClassJobLevel = parser.ReadColumn< byte >( 4 );
            ClassJobLevelMax = parser.ReadColumn< byte >( 5 );
            EventItem = new LazyRow< EventItem >( gameData, parser.ReadColumn< uint >( 6 ), language );
            TypeToDoValue = new byte[ 3 ];
            for( var i = 0; i < 3; i++ )
                TypeToDoValue[ i ] = parser.ReadColumn< byte >( 7 + i );
            IconObjective = parser.ReadColumn< uint >( 10 );
            IconMap = parser.ReadColumn< uint >( 11 );
            IconInactiveMap = parser.ReadColumn< uint >( 12 );
            Music = new LazyRow< BGM >( gameData, parser.ReadColumn< int >( 13 ), language );
            LGBGuardNPCLocation = parser.ReadColumn< uint >( 14 );
            ScreenImageAccept = new LazyRow< ScreenImage >( gameData, parser.ReadColumn< ushort >( 15 ), language );
            ScreenImageComplete = new LazyRow< ScreenImage >( gameData, parser.ReadColumn< ushort >( 16 ), language );
            ScreenImageFailed = new LazyRow< ScreenImage >( gameData, parser.ReadColumn< ushort >( 17 ), language );
            Unknown18 = parser.ReadColumn< byte >( 18 );
            Unknown19 = parser.ReadColumn< uint >( 19 );
            SpecialFate = parser.ReadColumn< bool >( 20 );
            Unknown21 = parser.ReadColumn< bool >( 21 );
            GivenStatus = new LazyRow< Status >( gameData, parser.ReadColumn< ushort >( 22 ), language );
            Unknown23 = parser.ReadColumn< ushort >( 23 );
            AdventEvent = parser.ReadColumn< bool >( 24 );
            MoonFaireEvent = parser.ReadColumn< bool >( 25 );
            Unknown26 = parser.ReadColumn< bool >( 26 );
            FATEChain = parser.ReadColumn< uint >( 27 );
            Unknown28 = parser.ReadColumn< byte >( 28 );
            Unknown29 = parser.ReadColumn< ushort >( 29 );
            Name = parser.ReadColumn< SeString >( 30 );
            Description = parser.ReadColumn< SeString >( 31 );
            Objective = parser.ReadColumn< SeString >( 32 );
            StatusText = new SeString[ 3 ];
            for( var i = 0; i < 3; i++ )
                StatusText[ i ] = parser.ReadColumn< SeString >( 33 + i );
            ArrayIndex = new LazyRow< ArrayEventHandler >( gameData, parser.ReadColumn< uint >( 36 ), language );
            Unknown37 = parser.ReadColumn< uint >( 37 );
            ReqEventItem = new LazyRow< EventItem >( gameData, parser.ReadColumn< uint >( 38 ), language );
            TurnInEventItem = new LazyRow< EventItem >( gameData, parser.ReadColumn< uint >( 39 ), language );
            ObjectiveIcon = new ushort[ 8 ];
            for( var i = 0; i < 8; i++ )
                ObjectiveIcon[ i ] = parser.ReadColumn< ushort >( 40 + i );
        }
    }
}