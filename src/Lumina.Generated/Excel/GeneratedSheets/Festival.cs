using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Festival", columnHash: 0x9ff65ad6 )]
    public class Festival : IExcelRow
    {
        
        public string Name;
        public byte Unknown1;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
        }
    }
}