using Lumina.Data;
using Lumina.Excel;

namespace Lumina.Example
{
    [Sheet( "LogMessage" )]
    public class LogMessage : ExcelRow
    {
        public string Text;

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Text = parser.ReadColumn< string >( 4 );
        }
    }
}