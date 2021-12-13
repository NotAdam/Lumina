// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RetainerTaskNormal", columnHash: 0x644a4310 )]
    public partial class RetainerTaskNormal : ExcelRow
    {
        
        public LazyRow< Item > Item { get; set; }
        public byte Quantity0 { get; set; }
        public byte Quantity1 { get; set; }
        public byte Quantity2 { get; set; }
        public byte Quantity3 { get; set; }
        public byte Quantity4 { get; set; }
        public LazyRow< GatheringItem > GatheringLog { get; set; }
        public short FishingLog { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 0 ), language );
            Quantity0 = parser.ReadColumn< byte >( 1 );
            Quantity1 = parser.ReadColumn< byte >( 2 );
            Quantity2 = parser.ReadColumn< byte >( 3 );
            Quantity3 = parser.ReadColumn< byte >( 4 );
            Quantity4 = parser.ReadColumn< byte >( 5 );
            GatheringLog = new LazyRow< GatheringItem >( gameData, parser.ReadColumn< short >( 6 ), language );
            FishingLog = parser.ReadColumn< short >( 7 );
        }
    }
}