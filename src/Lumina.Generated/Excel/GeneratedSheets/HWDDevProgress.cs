// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDDevProgress", columnHash: 0xcd4cb81c )]
    public class HWDDevProgress : IExcelRow
    {
        
        public bool CanGoNext;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            CanGoNext = parser.ReadColumn< bool >( 0 );
        }
    }
}