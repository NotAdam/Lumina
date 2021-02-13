using Lumina.Data;
using Lumina.Excel;

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