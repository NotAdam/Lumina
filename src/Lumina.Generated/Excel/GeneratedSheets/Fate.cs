using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Fate", columnHash: 0x22c39fbf )]
    public class Fate : IExcelRow
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
        public bool HasWorldMapIcon;
        public bool IsQuest;
        public bool SpecialFate;
        public LazyRow< Status > GivenStatus;
        public ushort Unknown22;
        public bool AdventEvent;
        public bool MoonFaireEvent;
        public bool Unknown25;
        public uint FATEChain;
        public byte Unknown27;
        public ushort Unknown28;
        public string Name;
        public string Description;
        public string Objective;
        public string[] StatusText;
        public LazyRow< ArrayEventHandler > ArrayIndex;
        public uint Unknown36;
        public LazyRow< EventItem > ReqEventItem;
        public LazyRow< EventItem > TurnInEventItem;
        public ushort[] ObjectiveIcon;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            EurekaFate = parser.ReadColumn< byte >( 0 );
            Rule = parser.ReadColumn< byte >( 1 );
            FateRuleEx = parser.ReadColumn< ushort >( 2 );
            Location = parser.ReadColumn< uint >( 3 );
            ClassJobLevel = parser.ReadColumn< byte >( 4 );
            ClassJobLevelMax = parser.ReadColumn< byte >( 5 );
            EventItem = new LazyRow< EventItem >( lumina, parser.ReadColumn< uint >( 6 ) );
            TypeToDoValue = new byte[ 3 ];
            for( var i = 0; i < 3; i++ )
                TypeToDoValue[ i ] = parser.ReadColumn< byte >( 7 + i );
            IconObjective = parser.ReadColumn< uint >( 10 );
            IconMap = parser.ReadColumn< uint >( 11 );
            IconInactiveMap = parser.ReadColumn< uint >( 12 );
            Music = new LazyRow< BGM >( lumina, parser.ReadColumn< int >( 13 ) );
            LGBGuardNPCLocation = parser.ReadColumn< uint >( 14 );
            ScreenImageAccept = new LazyRow< ScreenImage >( lumina, parser.ReadColumn< ushort >( 15 ) );
            ScreenImageComplete = new LazyRow< ScreenImage >( lumina, parser.ReadColumn< ushort >( 16 ) );
            ScreenImageFailed = new LazyRow< ScreenImage >( lumina, parser.ReadColumn< ushort >( 17 ) );
            HasWorldMapIcon = parser.ReadColumn< bool >( 18 );
            IsQuest = parser.ReadColumn< bool >( 19 );
            SpecialFate = parser.ReadColumn< bool >( 20 );
            GivenStatus = new LazyRow< Status >( lumina, parser.ReadColumn< ushort >( 21 ) );
            Unknown22 = parser.ReadColumn< ushort >( 22 );
            AdventEvent = parser.ReadColumn< bool >( 23 );
            MoonFaireEvent = parser.ReadColumn< bool >( 24 );
            Unknown25 = parser.ReadColumn< bool >( 25 );
            FATEChain = parser.ReadColumn< uint >( 26 );
            Unknown27 = parser.ReadColumn< byte >( 27 );
            Unknown28 = parser.ReadColumn< ushort >( 28 );
            Name = parser.ReadColumn< string >( 29 );
            Description = parser.ReadColumn< string >( 30 );
            Objective = parser.ReadColumn< string >( 31 );
            StatusText = new string[ 3 ];
            for( var i = 0; i < 3; i++ )
                StatusText[ i ] = parser.ReadColumn< string >( 32 + i );
            ArrayIndex = new LazyRow< ArrayEventHandler >( lumina, parser.ReadColumn< uint >( 35 ) );
            Unknown36 = parser.ReadColumn< uint >( 36 );
            ReqEventItem = new LazyRow< EventItem >( lumina, parser.ReadColumn< uint >( 37 ) );
            TurnInEventItem = new LazyRow< EventItem >( lumina, parser.ReadColumn< uint >( 38 ) );
            ObjectiveIcon = new ushort[ 8 ];
            for( var i = 0; i < 8; i++ )
                ObjectiveIcon[ i ] = parser.ReadColumn< ushort >( 39 + i );
        }
    }
}