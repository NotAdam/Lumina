// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Aetheryte", columnHash: 0xcd1e31a4 )]
    public partial class Aetheryte : ExcelRow
    {
        
        public SeString Singular { get; set; }
        public sbyte Adjective { get; set; }
        public SeString Plural { get; set; }
        public sbyte PossessivePronoun { get; set; }
        public sbyte StartsWithVowel { get; set; }
        public sbyte Unknown5 { get; set; }
        public sbyte Pronoun { get; set; }
        public sbyte Article { get; set; }
        public LazyRow< PlaceName > PlaceName { get; set; }
        public LazyRow< PlaceName > AethernetName { get; set; }
        public LazyRow< TerritoryType > Territory { get; set; }
        public LazyRow< Level >[] Level { get; set; }
        public bool IsAetheryte { get; set; }
        public SeString Unknown16 { get; set; }
        public byte AethernetGroup { get; set; }
        public bool Invisible { get; set; }
        public LazyRow< Quest > RequiredQuest { get; set; }
        public LazyRow< Map > Map { get; set; }
        public short AetherstreamX { get; set; }
        public short AetherstreamY { get; set; }
        public byte Order { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Singular = parser.ReadColumn< SeString >( 0 );
            Adjective = parser.ReadColumn< sbyte >( 1 );
            Plural = parser.ReadColumn< SeString >( 2 );
            PossessivePronoun = parser.ReadColumn< sbyte >( 3 );
            StartsWithVowel = parser.ReadColumn< sbyte >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
            Pronoun = parser.ReadColumn< sbyte >( 6 );
            Article = parser.ReadColumn< sbyte >( 7 );
            PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 8 ), language );
            AethernetName = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 9 ), language );
            Territory = new LazyRow< TerritoryType >( gameData, parser.ReadColumn< ushort >( 10 ), language );
            Level = new LazyRow< Level >[ 4 ];
            for( var i = 0; i < 4; i++ )
                Level[ i ] = new LazyRow< Level >( gameData, parser.ReadColumn< uint >( 11 + i ), language );
            IsAetheryte = parser.ReadColumn< bool >( 15 );
            Unknown16 = parser.ReadColumn< SeString >( 16 );
            AethernetGroup = parser.ReadColumn< byte >( 17 );
            Invisible = parser.ReadColumn< bool >( 18 );
            RequiredQuest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 19 ), language );
            Map = new LazyRow< Map >( gameData, parser.ReadColumn< ushort >( 20 ), language );
            AetherstreamX = parser.ReadColumn< short >( 21 );
            AetherstreamY = parser.ReadColumn< short >( 22 );
            Order = parser.ReadColumn< byte >( 23 );
        }
    }
}