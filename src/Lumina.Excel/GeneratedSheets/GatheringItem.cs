// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringItem", columnHash: 0xd89f1e60 )]
    public partial class GatheringItem : ExcelRow
    {
        
        public int Item { get; set; }
        public LazyRow< GatheringItemLevelConvertTable > GatheringItemLevel { get; set; }
        public bool Unknown2 { get; set; }
        public LazyRow< Quest > Quest { get; set; }
        public uint Unknown4 { get; set; }
        public bool IsHidden { get; set; }
        public uint Unknown6 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = parser.ReadColumn< int >( 0 );
            GatheringItemLevel = new LazyRow< GatheringItemLevelConvertTable >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< ushort >( 3 ), language );
            Unknown4 = parser.ReadColumn< uint >( 4 );
            IsHidden = parser.ReadColumn< bool >( 5 );
            Unknown6 = parser.ReadColumn< uint >( 6 );
        }
    }
}