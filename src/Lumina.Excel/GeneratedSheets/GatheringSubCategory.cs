// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringSubCategory", columnHash: 0x6dac8145 )]
    public partial class GatheringSubCategory : ExcelRow
    {
        
        public LazyRow< GatheringType > GatheringType { get; set; }
        public LazyRow< ClassJob > ClassJob { get; set; }
        public LazyRow< Quest > Quest { get; set; }
        public ushort Division { get; set; }
        public LazyRow< Item > Item { get; set; }
        public SeString FolkloreBook { get; set; }
        public byte Unknown6 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            GatheringType = new LazyRow< GatheringType >( gameData, parser.ReadColumn< byte >( 0 ), language );
            ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadColumn< byte >( 1 ), language );
            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 2 ), language );
            Division = parser.ReadColumn< ushort >( 3 );
            Item = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 4 ), language );
            FolkloreBook = parser.ReadColumn< SeString >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
        }
    }
}