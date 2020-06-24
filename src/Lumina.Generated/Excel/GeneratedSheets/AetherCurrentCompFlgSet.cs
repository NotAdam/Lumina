using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AetherCurrentCompFlgSet", columnHash: 0xa562e4cf )]
    public class AetherCurrentCompFlgSet : IExcelRow
    {
        
        public LazyRow< TerritoryType > Territory;
        public byte Unknown1;
        public LazyRow< AetherCurrent >[] AetherCurrent;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Territory = new LazyRow< TerritoryType >( lumina, parser.ReadColumn< int >( 0 ), language );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            AetherCurrent = new LazyRow< AetherCurrent >[ 15 ];
            for( var i = 0; i < 15; i++ )
                AetherCurrent[ i ] = new LazyRow< AetherCurrent >( lumina, parser.ReadColumn< int >( 2 + i ), language );
        }
    }
}