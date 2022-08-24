// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringPointBase", columnHash: 0xb34093c0 )]
    public partial class GatheringPointBase : ExcelRow
    {
        
        public LazyRow< GatheringType > GatheringType { get; set; }
        public byte GatheringLevel { get; set; }
        public int[] Item { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            GatheringType = new LazyRow< GatheringType >( gameData, parser.ReadColumn< int >( 0 ), language );
            GatheringLevel = parser.ReadColumn< byte >( 1 );
            Item = new int[ 8 ];
            for( var i = 0; i < 8; i++ )
                Item[ i ] = parser.ReadColumn< int >( 2 + i );
        }
    }
}