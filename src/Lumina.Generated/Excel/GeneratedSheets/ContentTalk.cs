using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentTalk", columnHash: 0x5eb59ccb )]
    public class ContentTalk : IExcelRow
    {
        
        public LazyRow< ContentTalkParam > ContentTalkParam;
        public string Text;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ContentTalkParam = new LazyRow< ContentTalkParam >( lumina, parser.ReadColumn< byte >( 0 ) );
            Text = parser.ReadColumn< string >( 1 );
        }
    }
}