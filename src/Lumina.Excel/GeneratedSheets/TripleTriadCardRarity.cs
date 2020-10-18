// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TripleTriadCardRarity", columnHash: 0xdcfd9eba )]
    public class TripleTriadCardRarity : IExcelRow
    {
        
        public byte Stars;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Stars = parser.ReadColumn< byte >( 0 );
        }
    }
}