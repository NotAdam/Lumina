using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Currency", columnHash: 0x072e6fd8 )]
    public class Currency : IExcelRow
    {
        
        public LazyRow< Item > Item;
        public byte Unknown1;
        public byte Unknown2;
        public uint Limit;
        public bool Unknown4;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Item = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 0 ) );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Limit = parser.ReadColumn< uint >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
        }
    }
}