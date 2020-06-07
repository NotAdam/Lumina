using Lumina.Excel;

namespace Lumina.Example
{
    [Sheet("Condition" )]
    public class Condition : IExcelRow
    {
        public int Index;

        public bool Unknown1;

        public byte Unknown2;

        public uint LogMessageId;
        
        public LazyRow< LogMessage > LogMessage;

        public uint RowId { get; set; }
        public uint SubRowId { get; set; }
        
        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Index = parser.ReadColumn< int >( 0 );
            
            LogMessageId = parser.ReadColumn< uint >( 2 );
            LogMessage = new LazyRow< LogMessage >( lumina, LogMessageId );
        }
    }
}