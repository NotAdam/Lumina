using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringNotebookList", columnHash: 0xa6318a14 )]
    public class GatheringNotebookList : IExcelRow
    {
        
        public byte Unknown0;
        public LazyRow< GatheringItem >[] GatheringItem;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            for( var i = 0; i < 100; i++ )
                GatheringItem[ i ] = new LazyRow< GatheringItem >( lumina, parser.ReadColumn< int >( 1 + i ) );
        }
    }
}