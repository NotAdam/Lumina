// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LogKind", columnHash: 0x23b962ed )]
    public class LogKind : IExcelRow
    {
        
        public byte Unknown0;
        public string Format;
        public bool Unknown2;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Format = parser.ReadColumn< string >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
        }
    }
}