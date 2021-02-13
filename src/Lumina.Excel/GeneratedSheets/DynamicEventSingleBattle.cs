// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DynamicEventSingleBattle", columnHash: 0xe760c985 )]
    public class DynamicEventSingleBattle : ExcelRow
    {
        
        public int ActionIcon;
        public uint Icon;
        public SeString Text;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            ActionIcon = parser.ReadColumn< int >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            Text = parser.ReadColumn< SeString >( 2 );
        }
    }
}