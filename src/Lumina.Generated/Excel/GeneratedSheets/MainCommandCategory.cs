using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MainCommandCategory", columnHash: 0x0c8db36c )]
    public class MainCommandCategory : IExcelRow
    {
        
        public int Unknown0;
        public string Name;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< int >( 0 );
            Name = parser.ReadColumn< string >( 1 );
        }
    }
}