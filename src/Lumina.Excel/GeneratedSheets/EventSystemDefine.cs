// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventSystemDefine", columnHash: 0x98fff20a )]
    public class EventSystemDefine : ExcelRow
    {
        
        public SeString Text;
        public uint DefineValue;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Text = parser.ReadColumn< SeString >( 0 );
            DefineValue = parser.ReadColumn< uint >( 1 );
        }
    }
}