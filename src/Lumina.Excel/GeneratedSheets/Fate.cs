// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Fate", columnHash: 0x7448945f )]
    public class Fate : ExcelRow
    {
        
        public byte EurekaFate;
        public byte Rule;
        public ushort FateRuleEx;
        public uint Location;
        public byte ClassJobLevel;
        public byte ClassJobLevelMax;
        public LazyRow< EventItem > EventItem;
        public byte[] TypeToDoValue;
        public uint IconObjective;
        public uint IconMap;
        public uint IconInactiveMap;
        public LazyRow< BGM > Music;
        public uint LGBGuardNPCLocation;
        public LazyRow< ScreenImage > ScreenImageAccept;
        public LazyRow< ScreenImage > ScreenImageComplete;
        public LazyRow< ScreenImage > ScreenImageFailed;
        public byte Unknown18;
        public uint Unknown19;
        public bool SpecialFate;
        public bool Unknown21;
        public LazyRow< Status > GivenStatus;
        public ushort Unknown23;
        public bool AdventEvent;
        public bool MoonFaireEvent;
        public bool Unknown26;
        public uint FATEChain;
        public byte Unknown28;
        public ushort Unknown29;
        public SeString Name;
        public SeString Description;
        public SeString Objective;
        public SeString[] StatusText;
        public LazyRow< ArrayEventHandler > ArrayIndex;
        public uint Unknown37;
        public LazyRow< EventItem > ReqEventItem;
        public LazyRow< EventItem > TurnInEventItem;
        public ushort[] ObjectiveIcon;
        

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