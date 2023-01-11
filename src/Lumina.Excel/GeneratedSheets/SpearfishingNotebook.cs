// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SpearfishingNotebook", columnHash: 0x0f196a4a )]
    public partial class SpearfishingNotebook : ExcelRow
    {
        
        public byte GatheringLevel { get; set; }
        public bool IsShadowNode { get; set; }
        public LazyRow< TerritoryType > TerritoryType { get; set; }
        public short X { get; set; }
        public short Y { get; set; }
        public ushort Radius { get; set; }
        public byte Unknown6 { get; set; }
        public LazyRow< PlaceName > PlaceName { get; set; }
        public byte Unknown8 { get; set; }
        public LazyRow< GatheringPointBase > GatheringPointBase { get; set; }
        public ushort Unknown10 { get; set; }
        public ushort Unknown11 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            GatheringLevel = parser.ReadColumn< byte >( 0 );
            IsShadowNode = parser.ReadColumn< bool >( 1 );
            TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadColumn< int >( 2 ), language );
            X = parser.ReadColumn< short >( 3 );
            Y = parser.ReadColumn< short >( 4 );
            Radius = parser.ReadColumn< ushort >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 7 ), language );
            Unknown8 = parser.ReadColumn< byte >( 8 );
            GatheringPointBase = new LazyRow< GatheringPointBase >( gameData, parser.ReadColumn< ushort >( 9 ), language );
            Unknown10 = parser.ReadColumn< ushort >( 10 );
            Unknown11 = parser.ReadColumn< ushort >( 11 );
        }
    }
}