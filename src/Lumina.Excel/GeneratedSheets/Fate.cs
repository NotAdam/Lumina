// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Fate", columnHash: 0xc9fc38f1 )]
    public partial class Fate : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public SeString Objective { get; set; }
        public SeString[] StatusText { get; set; }
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
        public byte Unknown24 { get; set; }
        public LazyRow< Quest > RequiredQuest { get; set; }
        public bool SpecialFate { get; set; }
        public bool Unknown27 { get; set; }
        public LazyRow< Status > GivenStatus { get; set; }
        public ushort Unknown29 { get; set; }
        public bool AdventEvent { get; set; }
        public bool MoonFaireEvent { get; set; }
        public bool Unknown32 { get; set; }
        public uint FATEChain { get; set; }
        public byte Unknown34 { get; set; }
        public ushort Unknown35 { get; set; }
        public LazyRow< ArrayEventHandler > ArrayIndex { get; set; }
        public uint Unknown37 { get; set; }
        public LazyRow< EventItem > ReqEventItem { get; set; }
        public LazyRow< EventItem > TurnInEventItem { get; set; }
        public uint Unknown40 { get; set; }
        public uint Unknown41 { get; set; }
        public uint Unknown42 { get; set; }
        public uint[] ObjectiveIcon { get; set; }
        public ushort Unknown51 { get; set; }
        public ushort Unknown52 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
            Objective = parser.ReadColumn< SeString >( 2 );
            StatusText = new SeString[ 3 ];
            for( var i = 0; i < 3; i++ )
                StatusText[ i ] = parser.ReadColumn< SeString >( 3 + i );
            EurekaFate = parser.ReadColumn< byte >( 6 );
            Rule = parser.ReadColumn< byte >( 7 );
            FateRuleEx = parser.ReadColumn< ushort >( 8 );
            Location = parser.ReadColumn< uint >( 9 );
            ClassJobLevel = parser.ReadColumn< byte >( 10 );
            ClassJobLevelMax = parser.ReadColumn< byte >( 11 );
            EventItem = new LazyRow< EventItem >( gameData, parser.ReadColumn< uint >( 12 ), language );
            TypeToDoValue = new byte[ 3 ];
            for( var i = 0; i < 3; i++ )
                TypeToDoValue[ i ] = parser.ReadColumn< byte >( 13 + i );
            IconObjective = parser.ReadColumn< uint >( 16 );
            IconMap = parser.ReadColumn< uint >( 17 );
            IconInactiveMap = parser.ReadColumn< uint >( 18 );
            Music = new LazyRow< BGM >( gameData, parser.ReadColumn< int >( 19 ), language );
            LGBGuardNPCLocation = parser.ReadColumn< uint >( 20 );
            ScreenImageAccept = new LazyRow< ScreenImage >( gameData, parser.ReadColumn< ushort >( 21 ), language );
            ScreenImageComplete = new LazyRow< ScreenImage >( gameData, parser.ReadColumn< ushort >( 22 ), language );
            ScreenImageFailed = new LazyRow< ScreenImage >( gameData, parser.ReadColumn< ushort >( 23 ), language );
            Unknown24 = parser.ReadColumn< byte >( 24 );
            RequiredQuest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 25 ), language );
            SpecialFate = parser.ReadColumn< bool >( 26 );
            Unknown27 = parser.ReadColumn< bool >( 27 );
            GivenStatus = new LazyRow< Status >( gameData, parser.ReadColumn< ushort >( 28 ), language );
            Unknown29 = parser.ReadColumn< ushort >( 29 );
            AdventEvent = parser.ReadColumn< bool >( 30 );
            MoonFaireEvent = parser.ReadColumn< bool >( 31 );
            Unknown32 = parser.ReadColumn< bool >( 32 );
            FATEChain = parser.ReadColumn< uint >( 33 );
            Unknown34 = parser.ReadColumn< byte >( 34 );
            Unknown35 = parser.ReadColumn< ushort >( 35 );
            ArrayIndex = new LazyRow< ArrayEventHandler >( gameData, parser.ReadColumn< uint >( 36 ), language );
            Unknown37 = parser.ReadColumn< uint >( 37 );
            ReqEventItem = new LazyRow< EventItem >( gameData, parser.ReadColumn< uint >( 38 ), language );
            TurnInEventItem = new LazyRow< EventItem >( gameData, parser.ReadColumn< uint >( 39 ), language );
            Unknown40 = parser.ReadColumn< uint >( 40 );
            Unknown41 = parser.ReadColumn< uint >( 41 );
            Unknown42 = parser.ReadColumn< uint >( 42 );
            ObjectiveIcon = new uint[ 8 ];
            for( var i = 0; i < 8; i++ )
                ObjectiveIcon[ i ] = parser.ReadColumn< uint >( 43 + i );
            Unknown51 = parser.ReadColumn< ushort >( 51 );
            Unknown52 = parser.ReadColumn< ushort >( 52 );
        }
    }
}