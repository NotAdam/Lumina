// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TreasureHuntRank", columnHash: 0x3997d502 )]
    public partial class TreasureHuntRank : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public uint Icon { get; set; }
        public LazyRow< Item > ItemName { get; set; }
        public LazyRow< EventItem > KeyItemName { get; set; }
        public LazyRow< EventItem > InstanceMap { get; set; }
        public byte MaxPartySize { get; set; }
        public byte TreasureHuntTexture { get; set; }
        public ushort Unknown7 { get; set; }
        public bool Unknown8 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            ItemName = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 2 ), language );
            KeyItemName = new LazyRow< EventItem >( gameData, parser.ReadColumn< int >( 3 ), language );
            InstanceMap = new LazyRow< EventItem >( gameData, parser.ReadColumn< int >( 4 ), language );
            MaxPartySize = parser.ReadColumn< byte >( 5 );
            TreasureHuntTexture = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< ushort >( 7 );
            Unknown8 = parser.ReadColumn< bool >( 8 );
        }
    }
}