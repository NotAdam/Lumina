// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Title", columnHash: 0x83e3f9ba )]
    public class Title : IExcelRow
    {
        
        public string Masculine;
        public string Feminine;
        public bool IsPrefix;
        public ushort Order;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Masculine = parser.ReadColumn< string >( 0 );
            Feminine = parser.ReadColumn< string >( 1 );
            IsPrefix = parser.ReadColumn< bool >( 2 );
            Order = parser.ReadColumn< ushort >( 3 );
        }
    }
}