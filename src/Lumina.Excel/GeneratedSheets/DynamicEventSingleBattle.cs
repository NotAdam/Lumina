// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DynamicEventSingleBattle", columnHash: 0xe760c985 )]
    public class DynamicEventSingleBattle : IExcelRow
    {
        
        public int ActionIcon;
        public uint Icon;
        public SeString Text;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ActionIcon = parser.ReadColumn< int >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            Text = parser.ReadColumn< SeString >( 2 );
        }
    }
}