// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringSubCategory", columnHash: 0x6dac8145 )]
    public class GatheringSubCategory : ExcelRow
    {
        
        public LazyRow< GatheringType > GatheringType;
        public LazyRow< ClassJob > ClassJob;
        public uint Unknown2;
        public ushort Division;
        public LazyRow< Item > Item;
        public SeString FolkloreBook;
        public byte Unknown6;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            GatheringType = new LazyRow< GatheringType >( gameData, parser.ReadColumn< byte >( 0 ), language );
            ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadColumn< byte >( 1 ), language );
            Unknown2 = parser.ReadColumn< uint >( 2 );
            Division = parser.ReadColumn< ushort >( 3 );
            Item = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 4 ), language );
            FolkloreBook = parser.ReadColumn< SeString >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
        }
    }
}