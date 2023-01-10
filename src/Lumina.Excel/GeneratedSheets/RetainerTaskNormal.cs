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
        public byte[] Quantity { get; set; }
        public LazyRow< GatheringItem > GatheringLog { get; set; }
        public short FishingLog { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 0 ), language );
            Quantity = new byte[ 5 ];
            for( var i = 0; i < 5; i++ )
                Quantity[ i ] = parser.ReadColumn< byte >( 1 + i );
            GatheringLog = new LazyRow< GatheringItem >( gameData, parser.ReadColumn< short >( 6 ), language );
            FishingLog = parser.ReadColumn< short >( 7 );
        }
    }
}