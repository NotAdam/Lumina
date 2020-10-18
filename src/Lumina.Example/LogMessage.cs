using Lumina.Data;
using Lumina.Excel;
using Lumina.Text;

namespace Lumina.Example
{
    [Sheet( "LogMessage" )]
    public class LogMessage : IExcelRow
    {
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public string Text;

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Text = parser.ReadColumn< string >( 4 );
        }
    }
}