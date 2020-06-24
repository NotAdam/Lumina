using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TripleTriadRule", columnHash: 0x48d210b8 )]
    public class TripleTriadRule : IExcelRow
    {
        
        public string Name;
        public string Unknown1;
        public byte Unknown2;
        public byte Unknown3;
        public byte Unknown4;
        public int Unknown5;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Unknown1 = parser.ReadColumn< string >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< int >( 5 );
        }
    }
}