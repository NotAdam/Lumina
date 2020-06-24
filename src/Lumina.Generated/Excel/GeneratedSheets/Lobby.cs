using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Lobby", columnHash: 0x54075f2e )]
    public class Lobby : IExcelRow
    {
        
        public uint TYPE;
        public uint PARAM;
        public uint LINK;
        public string Text;
        public string Unknown4;
        public string Unknown5;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            TYPE = parser.ReadColumn< uint >( 0 );
            PARAM = parser.ReadColumn< uint >( 1 );
            LINK = parser.ReadColumn< uint >( 2 );
            Text = parser.ReadColumn< string >( 3 );
            Unknown4 = parser.ReadColumn< string >( 4 );
            Unknown5 = parser.ReadColumn< string >( 5 );
        }
    }
}