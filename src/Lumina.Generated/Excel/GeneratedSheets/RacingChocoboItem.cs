using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RacingChocoboItem", columnHash: 0xe79dd9d4 )]
    public class RacingChocoboItem : IExcelRow
    {
        
        public LazyRow< Item > Item;
        public byte Category;
        public byte[] Param;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Item = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 0 ) );
            Category = parser.ReadColumn< byte >( 1 );
            for( var i = 0; i < 2; i++ )
                Param[ i ] = parser.ReadColumn< byte >( 2 + i );
        }
    }
}