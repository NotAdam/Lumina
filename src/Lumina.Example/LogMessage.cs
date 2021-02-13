using Lumina.Data;
using Lumina.Excel;
using Lumina.Text;

namespace Lumina.Example
{
    [Sheet( "LogMessage" )]
    public class LogMessage : ExcelRow
    {
        public string Text;

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Text = parser.ReadColumn< string >( 4 );
        }
    }
}