using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonRoom", columnHash: 0x6be0e840 )]
    public class DeepDungeonRoom : IExcelRow
    {
        
        public LazyRow< Level >[] Level;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Level = new LazyRow< Level >[ 5 ];
            for( var i = 0; i < 5; i++ )
                Level[ i ] = new LazyRow< Level >( lumina, parser.ReadColumn< uint >( 0 + i ) );
        }
    }
}