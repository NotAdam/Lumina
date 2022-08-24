// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventSystemDefine", columnHash: 0x98fff20a )]
    public partial class EventSystemDefine : ExcelRow
    {
        
        public SeString Text { get; set; }
        public uint DefineValue { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Text = parser.ReadColumn< SeString >( 0 );
            DefineValue = parser.ReadColumn< uint >( 1 );
        }
    }
}