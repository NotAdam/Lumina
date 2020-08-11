// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Aetheryte", columnHash: 0xcd1e31a4 )]
    public class Aetheryte : IExcelRow
    {
        
        public string Singular;
        public sbyte Adjective;
        public string Plural;
        public sbyte PossessivePronoun;
        public sbyte StartsWithVowel;
        public sbyte Unknown5;
        public sbyte Pronoun;
        public sbyte Article;
        public LazyRow< PlaceName > PlaceName;
        public LazyRow< PlaceName > AethernetName;
        public LazyRow< TerritoryType > Territory;
        public LazyRow< Level >[] Level;
        public bool IsAetheryte;
        public string Unknown16;
        public byte AethernetGroup;
        public bool Unknown18;
        public LazyRow< Quest > RequiredQuest;
        public LazyRow< Map > Map;
        public short AetherstreamX;
        public short AetherstreamY;
        public byte Unknown23;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Singular = parser.ReadColumn< string >( 0 );
            Adjective = parser.ReadColumn< sbyte >( 1 );
            Plural = parser.ReadColumn< string >( 2 );
            PossessivePronoun = parser.ReadColumn< sbyte >( 3 );
            StartsWithVowel = parser.ReadColumn< sbyte >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
            Pronoun = parser.ReadColumn< sbyte >( 6 );
            Article = parser.ReadColumn< sbyte >( 7 );
            PlaceName = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 8 ), language );
            AethernetName = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 9 ), language );
            Territory = new LazyRow< TerritoryType >( lumina, parser.ReadColumn< ushort >( 10 ), language );
            Level = new LazyRow< Level >[ 4 ];
            for( var i = 0; i < 4; i++ )
                Level[ i ] = new LazyRow< Level >( lumina, parser.ReadColumn< uint >( 11 + i ), language );
            IsAetheryte = parser.ReadColumn< bool >( 15 );
            Unknown16 = parser.ReadColumn< string >( 16 );
            AethernetGroup = parser.ReadColumn< byte >( 17 );
            Unknown18 = parser.ReadColumn< bool >( 18 );
            RequiredQuest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 19 ), language );
            Map = new LazyRow< Map >( lumina, parser.ReadColumn< ushort >( 20 ), language );
            AetherstreamX = parser.ReadColumn< short >( 21 );
            AetherstreamY = parser.ReadColumn< short >( 22 );
            Unknown23 = parser.ReadColumn< byte >( 23 );
        }
    }
}