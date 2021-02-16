// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CustomTalkNestHandlers", columnHash: 0xdbf43666 )]
    public class CustomTalkNestHandlers : ExcelRow
    {
        
        public uint NestHandler;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            NestHandler = parser.ReadColumn< uint >( 0 );
        }
    }
}