// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FCChestName", columnHash: 0x9ff65ad6 )]
    public class FCChestName : IExcelRow
    {
        
        public SeString Name;
        public byte Unknown1;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
        }
    }
}