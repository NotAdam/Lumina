// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LeveString", columnHash: 0xdebb20e3 )]
    public class LeveString : IExcelRow
    {
        
        public string Objective;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Objective = parser.ReadColumn< string >( 0 );
        }
    }
}