// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AetheryteSystemDefine", columnHash: 0x98fff20a )]
    public class AetheryteSystemDefine : ExcelRow
    {
        
        public SeString Text;
        public uint DefineValue;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Text = parser.ReadColumn< SeString >( 0 );
            DefineValue = parser.ReadColumn< uint >( 1 );
        }
    }
}