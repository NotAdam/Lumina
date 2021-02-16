// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RetainerTaskNormal", columnHash: 0x81338da6 )]
    public class RetainerTaskNormal : ExcelRow
    {
        
        public LazyRow< Item > Item;
        public byte Quantity0;
        public byte Quantity1;
        public byte Quantity2;
        public LazyRow< GatheringItem > GatheringLog;
        public short FishingLog;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 0 ), language );
            Quantity0 = parser.ReadColumn< byte >( 1 );
            Quantity1 = parser.ReadColumn< byte >( 2 );
            Quantity2 = parser.ReadColumn< byte >( 3 );
            GatheringLog = new LazyRow< GatheringItem >( gameData, parser.ReadColumn< short >( 4 ), language );
            FishingLog = parser.ReadColumn< short >( 5 );
        }
    }
}