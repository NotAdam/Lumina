using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ConfigKey", columnHash: 0x927ebfb7 )]
    public class ConfigKey : IExcelRow
    {
        
        public string Label;
        public byte Param;
        public byte Platform;
        public bool Required;
        public byte Category;
        public ushort Unknown5;
        public byte Unknown6;
        public string Text;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Label = parser.ReadColumn< string >( 0 );
            Param = parser.ReadColumn< byte >( 1 );
            Platform = parser.ReadColumn< byte >( 2 );
            Required = parser.ReadColumn< bool >( 3 );
            Category = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            Text = parser.ReadColumn< string >( 7 );
        }
    }
}