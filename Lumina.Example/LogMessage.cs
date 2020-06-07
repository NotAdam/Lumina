using Lumina.Excel;

namespace Lumina.Example
{
    [Sheet( "LogMessage" )]
    public class LogMessage : IExcelRow
    {
        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public string Text;

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Text = parser.ReadColumn< string >( 4 );
        }
    }
}