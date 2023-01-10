// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIItemPouch", columnHash: 0x471e775e )]
    public partial class MJIItemPouch : ExcelRow
    {
        
        public LazyRow< Item > Item { get; set; }
        public LazyRow< MJIItemCategory > Category { get; set; }
        public LazyRow< MJICropSeed > Crop { get; set; }
        public byte Unknown3 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Category = new LazyRow< MJIItemCategory >( gameData, parser.ReadColumn< int >( 1 ), language );
            Crop = new LazyRow< MJICropSeed >( gameData, parser.ReadColumn< byte >( 2 ), language );
            Unknown3 = parser.ReadColumn< byte >( 3 );
        }
    }
}