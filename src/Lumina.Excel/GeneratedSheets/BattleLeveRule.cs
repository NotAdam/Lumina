// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BattleLeveRule", columnHash: 0xdebb20e3 )]
    public class BattleLeveRule : IExcelRow
    {
        
        public string Rule;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Rule = parser.ReadColumn< string >( 0 );
        }
    }
}