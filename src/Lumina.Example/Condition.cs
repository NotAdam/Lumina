using Lumina.Data;
using Lumina.Excel;

namespace Lumina.Example
{
    [Sheet( "Condition" )]
    public class Condition : ExcelRow
    {
        public int Index;

        public uint LogMessageId;

        public LazyRow< LogMessage > LogMessage;

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Index = parser.ReadColumn< int >( 0 );

            LogMessageId = parser.ReadColumn< uint >( 2 );
            LogMessage = new LazyRow< LogMessage >( gameData, LogMessageId, language );
        }
    }
}