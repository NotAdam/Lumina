// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RacingChocoboNameCategory", columnHash: 0x5eb59ccb )]
    public class RacingChocoboNameCategory : IExcelRow
    {
        
        public byte SortKey;
        public SeString Name;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            SortKey = parser.ReadColumn< byte >( 0 );
            Name = parser.ReadColumn< SeString >( 1 );
        }
    }
}